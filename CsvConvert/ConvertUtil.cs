using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OpenBveApi;
using OpenBveApi.Math;
using OpenBveApi.Textures;
using OpenBveApi.Objects;
using OpenBveApi.Colors;

namespace CsvConvert {
  
	public static class ConvertUtil {
		
		public enum Message {
			SequenceStarted,
			FileStarted,
			SequenceDone,
			FileDone,
			GeneralError,
            GeneralWarning,
            GeneralInfo,
			Reading,
			OptimizingObject,
			OptimizingMaterial,
			PreProcessing,
			PostProcessing,
			Writing,
			Dimension,
            TextureHint,
            SketchupHack,
			ObjectNotReadable
		}
		
		public enum Face2Method {
			None,
			Command,
			DoubleFace
		}
		
		public struct Bool3 {
			public bool X, Y, Z;
			public Bool3(bool x, bool y, bool z) {
				X = x;
				Y = y;
				Z = z;
			}

			#region Equals and GetHashCode implementation
			public override bool Equals(object obj) {
				return (obj is Bool3) && Equals((Bool3)obj);
			}

			public bool Equals(Bool3 other) {
				return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
			}

			public override int GetHashCode() {
				int hashCode = 0;
				unchecked {
					hashCode += 1000000007 * X.GetHashCode();
					hashCode += 1000000009 * Y.GetHashCode();
					hashCode += 1000000021 * Z.GetHashCode();
				}
				return hashCode;
			}

			public static bool operator ==(Bool3 lhs, Bool3 rhs) {
				return lhs.Equals(rhs);
			}

			public static bool operator !=(Bool3 lhs, Bool3 rhs) {
				return !(lhs == rhs);
			}

			#endregion
		}
		
		public struct ConvertOption {
			public Vector3 Translation;
			public Vector3 Rotation;
			public Vector3 Scale;
			public Bool3 Mirror;
			public Face2Method Face2Method;
            public bool OutputNormals;
            public int RoundV, RoundVN, RoundVT;
            public Color24? TransparentColor;
            public bool UseLocalEncoding;
		}
		
		public delegate void LogHandler(Message msg, object formatArgs = null);
		
		public static void ProcessFile(string[] pathIn, string extension, ConvertOption option, LogHandler callback) {
			callback(Message.SequenceStarted);
			foreach (var file in pathIn) {
				string pathOut = file + extension;
				ProcessFile(file, pathOut, option, callback);
			}
			callback(Message.SequenceDone);
		}
  
		public static void ProcessFile(string pathIn, string pathOut, ConvertOption option, LogHandler callback) {
			callback(Message.FileStarted, pathIn);
			UnifiedObject unifiedObj = null;
			callback(Message.Reading);
            PluginManager.logHandler = callback;
            Encoding encoding = option.UseLocalEncoding ? Encoding.Default : TextEncoding.GetSystemEncodingFromFile(pathIn);
            bool isSketchupObjFile = IsSketchupObjFile(pathIn, encoding);
            if (PluginManager.LoadObject(pathIn, encoding, out unifiedObj)) {
                var staticObj = unifiedObj as StaticObject;

				callback(Message.OptimizingObject);
				staticObj.OptimizeObject(false, 0, true);

				callback(Message.OptimizingMaterial);
				OptimizeMaterial(ref staticObj.Mesh);

				callback(Message.PostProcessing);
                if (isSketchupObjFile) {
                    callback(Message.SketchupHack);
                    option.Mirror.Z ^= true;
                }
				if (option.Mirror != default(Bool3)) {
					staticObj.ApplyMirror(option.Mirror.X, option.Mirror.Y, option.Mirror.Z,
						option.Mirror.X, option.Mirror.Y, option.Mirror.Z);
				}
				if (option.Scale != default(Vector3) && option.Scale != new Vector3(1, 1, 1)) {
					staticObj.ApplyScale(option.Scale.X, option.Scale.Y, option.Scale.Z);
				}
				if (option.Rotation != default(Vector3)) {
					// TODO: This doesn't seem to be the correct way to apply euler angle rotation!
					if (option.Rotation.X != 0.0)
						staticObj.ApplyRotation(new Vector3(1, 0, 0), option.Rotation.X);
					if (option.Rotation.Y != 0.0)
						staticObj.ApplyRotation(new Vector3(0, 1, 0), option.Rotation.X);
					if (option.Rotation.Z != 0.0)
						staticObj.ApplyRotation(new Vector3(0, 0, 1), option.Rotation.X);
				}
                if (option.Translation != default(Vector3)) {
                    staticObj.ApplyTranslation(option.Translation.X, option.Translation.Y, option.Translation.Z);
                }
				//var dimension = "[" + string.Join(", ", staticObj.Mesh.BoundingBox.Select(v => string.Format("({0}, {1}, {2})", v.X, v.Y, v.Z))) + "]";
				//callback(Message.Dimension, dimension);
				
				if (pathOut.EndsWith(".csv", StringComparison.OrdinalIgnoreCase)) {
					callback(Message.Writing);
					CsvWriter.Save(staticObj, pathOut, option, callback);
				} else if (pathOut.EndsWith(".hmmo", StringComparison.OrdinalIgnoreCase)) {
					callback(Message.PostProcessing);
					staticObj.Mesh.Faces = Triangulate(staticObj.Mesh.Faces);
					callback(Message.Writing);
					// TODO: Hmmo Writer
				}
			} else {
				callback(Message.ObjectNotReadable);
			}
			callback(Message.FileDone, pathOut);
		}

        private static bool IsSketchupObjFile(string path, Encoding encoding) {
            if (!path.ToLowerInvariant().EndsWith(".obj")) return false;
            int lineNum = 0;
            foreach (string line in System.IO.File.ReadLines(path, encoding)) {
                lineNum++;
                if (lineNum > 5) return false;
                int c = line.IndexOf("#", StringComparison.Ordinal);
                if (c >= 0) {
                    int hash = line.IndexOf('#');
                    int skp = line.IndexOf("SketchUp", StringComparison.InvariantCultureIgnoreCase);
                    if (hash != -1 && skp != -1) {
                        string afterHash = line.Substring(hash + 1).Trim();
                        if (afterHash.StartsWith("Exported from SketchUp", StringComparison.InvariantCultureIgnoreCase)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
		
		private static MeshFace[] Triangulate(MeshFace[] Source) {
			List<MeshFace> list = new List<MeshFace>(Source.Length);
			foreach (MeshFace meshFace in Source) {
				MeshFace[] array;
				if ((meshFace.Flags & FaceFlags.Face2Mask) != 0) {
					MeshFace meshFace2 = new MeshFace((MeshFaceVertex[])meshFace.Vertices.Clone(), meshFace.Material);
					meshFace2.Flip();
					array = new MeshFace[] {
						meshFace,
						meshFace2
					};
				} else {
					array = new MeshFace[] {
						meshFace
					};
				}
				foreach (MeshFace meshFace3 in array) {
					if (meshFace3.Vertices.Length > 3) {
						for (int k = 2; k < meshFace3.Vertices.Length; k++) {
							list.Add(new MeshFace(new int[] {
								(int)meshFace3.Vertices[0].Index,
								(int)meshFace3.Vertices[k - 1].Index,
								(int)meshFace3.Vertices[k].Index
							}) {
								Material = meshFace3.Material,
								Flags = meshFace3.Flags
							});
						}
					} else {
						list.Add(meshFace3);
					}
				}
			}
			return list.ToArray();
		}
		
		private static void OptimizeMaterial(ref Mesh mesh) {
			MeshMaterial[] array = mesh.Materials.Distinct(meshMaterialComparer).ToArray<MeshMaterial>();
			for (int i = 0; i < mesh.Faces.Length; i++) {
				for (int j = 0; j < array.Length; j++) {
					if (meshMaterialComparer.Equals(mesh.Materials[(int)mesh.Faces[i].Material], array[j])) {
						mesh.Faces[i].Material = (ushort)j;
						break;
					}
				}
			}
			mesh.Materials = array;
		}
		
		private readonly static MeshMaterialComparer meshMaterialComparer = new MeshMaterialComparer();
		
		private class MeshMaterialComparer : IEqualityComparer<MeshMaterial> {
			// Token: 0x0600005B RID: 91 RVA: 0x000051EC File Offset: 0x000033EC
			public bool Equals(MeshMaterial A, MeshMaterial B) {
				if (A.Flags != B.Flags) {
					return false;
				}
				if (A.Color.R != B.Color.R | A.Color.G != B.Color.G | A.Color.B != B.Color.B | A.Color.A != B.Color.A) {
					return false;
				}
				if (A.TransparentColor.R != B.TransparentColor.R | A.TransparentColor.G != B.TransparentColor.G | A.TransparentColor.B != B.TransparentColor.B) {
					return false;
				}
				if (A.EmissiveColor.R != B.EmissiveColor.R | A.EmissiveColor.G != B.EmissiveColor.G | A.EmissiveColor.B != B.EmissiveColor.B) {
					return false;
				}
				if (A.DaytimeTexture != null && B.DaytimeTexture != null) {
					if (A.DaytimeTexture.Origin != B.DaytimeTexture.Origin) {
						return false;
					}
				} else if (A.DaytimeTexture != null || B.DaytimeTexture != null) {
					return false;
				}
				if (A.NighttimeTexture != null && B.NighttimeTexture != null) {
					if (A.NighttimeTexture.Origin != B.NighttimeTexture.Origin) {
						return false;
					}
				} else if (A.NighttimeTexture != null || B.NighttimeTexture != null) {
					return false;
				}
				if (A.BlendMode != B.BlendMode) {
					return false;
				}
				if (A.GlowAttenuationData != B.GlowAttenuationData) {
					return false;
				}
				OpenGlTextureWrapMode? wrapMode = A.WrapMode;
				OpenGlTextureWrapMode? wrapMode2 = B.WrapMode;
				return wrapMode.GetValueOrDefault() == wrapMode2.GetValueOrDefault() & wrapMode != null == (wrapMode2 != null);
			}

			public int GetHashCode(MeshMaterial obj) {
				return obj.GetHashCode();
			}
		}
	}
}
