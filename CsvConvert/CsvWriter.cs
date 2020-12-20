using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using OpenBveApi.Colors;
using OpenBveApi.Objects;
using OpenBveApi.Textures;
using System.Reflection;

namespace CsvConvert {
  
	public static class CsvWriter {
  
		public static void Save(StaticObject obj, string pathOut, ConvertUtil.ConvertOption option, ConvertUtil.LogHandler callback) {
			var writer = new StreamWriter(pathOut, false, Encoding.UTF8);
            Mesh mesh = obj.Mesh;

            writer.WriteLine(string.Format(@"; Generated by CsvConvert {0}
; CsvConvert (C) zbx1425 2020 (GPLv3)
; Website: www.zbx1425.cn; Email: zbx1425@outlook.com", Assembly.GetExecutingAssembly().GetName().Version));
            foreach (IGrouping<ushort, MeshFace> grouping in obj.Mesh.Faces.GroupBy(f => f.Material)) {
                MeshMaterial mtl = mesh.Materials[(int)grouping.Key];
                writer.WriteLine("CreateMeshBuilder");

                uint[] vidArray = null;
                MeshFaceVertex[] vertArray = null;
                if (option.OutputNormals) {
                    var vertSet = new HashSet<MeshFaceVertex>();
                    foreach (MeshFace meshFace in grouping) {
                        foreach (MeshFaceVertex vertex in meshFace.Vertices) {
                            vertSet.Add(vertex);
                        }
                    }
                    vertArray = vertSet.ToArray();
                    for (int i = 0; i < vertArray.Length; i++) {
                        var vertex = vertArray[i];
                        var template = mesh.Vertices[vertex.Index];
                        writer.WriteLine(string.Format("AddVertex,{0},{1},{2},{3},{4},{5}",
                            Math.Round(template.Coordinates.X, option.RoundV),
                            Math.Round(template.Coordinates.Y, option.RoundV),
                            Math.Round(template.Coordinates.Z, option.RoundV),
                            Math.Round(vertex.Normal.X, option.RoundVN),
                            Math.Round(vertex.Normal.Y, option.RoundVN),
                            Math.Round(vertex.Normal.Z, option.RoundVN)
                        ));
                        if (mtl.DaytimeTexture != null) {
                            writer.WriteLine(string.Format("SetTextureCoordinates,{0},{1},{2}",
                                i,
                                Math.Round(template.TextureCoordinates.X, option.RoundVT),
                                Math.Round(template.TextureCoordinates.Y, option.RoundVT)
                            ));
                        }
                    }
                } else {
                    var vidSet = new HashSet<uint>();
                    foreach (MeshFace meshFace in grouping) {
                        foreach (MeshFaceVertex vertex in meshFace.Vertices) {
                            vidSet.Add(vertex.Index);
                        }
                    }
                    vidArray = vidSet.OrderBy(v => v).ToArray();
                    for (int i = 0; i < vidArray.Length; i++) {
                        var vertex = vidArray[i];
                        var template = mesh.Vertices[vertex];
                        writer.WriteLine(string.Format("AddVertex,{0},{1},{2}",
                            Math.Round(template.Coordinates.X, option.RoundV),
                            Math.Round(template.Coordinates.Y, option.RoundV),
                            Math.Round(template.Coordinates.Z, option.RoundV)
                        ));
                        if (mtl.DaytimeTexture != null) {
                            writer.WriteLine(string.Format("SetTextureCoordinates,{0},{1},{2}",
                                i,
                                Math.Round(template.TextureCoordinates.X, option.RoundVT),
                                Math.Round(template.TextureCoordinates.Y, option.RoundVT)
                            ));
                        }
                    }
                }

				foreach (MeshFace meshFace in grouping) {
                    string paramStr, paramStrRev;
                    if (option.OutputNormals) {
                        paramStr = string.Join(",", meshFace.Vertices.Select(v => Array.IndexOf(vertArray, v)));
                        paramStrRev = string.Join(",", meshFace.Vertices.Reverse().Select(v => Array.IndexOf(vertArray, v)));
                    } else {
                        paramStr = string.Join(",", meshFace.Vertices.Select(v => Array.IndexOf(vidArray, v.Index)));
                        paramStrRev = string.Join(",", meshFace.Vertices.Reverse().Select(v => Array.IndexOf(vidArray, v.Index)));
                    }
                    if (option.Face2Method == ConvertUtil.Face2Method.Command || meshFace.Flags.HasFlag(FaceFlags.Face2Mask)) {
						writer.WriteLine("AddFace2," + paramStr);
					} else {
						writer.WriteLine("AddFace," + paramStr);
                        if (option.Face2Method == ConvertUtil.Face2Method.DoubleFace) writer.WriteLine("AddFace," + paramStrRev);
                    }
				}
				
				if (mtl.Color != new Color32(0, 0, 0, 255)) {
					writer.WriteLine(string.Format("SetColor,{0},{1},{2},{3}",
						mtl.Color.R, mtl.Color.G, mtl.Color.B, mtl.Color.A));
				}
				if (mtl.Flags.HasFlag(MaterialFlags.Emissive)) {
					writer.WriteLine(string.Format("SetEmissiveColor,{0},{1},{2}",
						mtl.EmissiveColor.R, mtl.EmissiveColor.G, mtl.EmissiveColor.B));
				}
				if (mtl.Flags.HasFlag(MaterialFlags.TransparentColor) || option.TransparentColor.HasValue) {
                    if (mtl.Flags.HasFlag(MaterialFlags.TransparentColor)) {
                        writer.WriteLine(string.Format("SetDecalTransparentColor,{0},{1},{2}",
                            mtl.TransparentColor.R, mtl.TransparentColor.G, mtl.TransparentColor.B));
                    } else {
                        writer.WriteLine(string.Format("SetDecalTransparentColor,{0},{1},{2}",
                            option.TransparentColor?.R, option.TransparentColor?.G, option.TransparentColor?.B));
                    }
				}
				if (mtl.DaytimeTexture != null && mtl.NighttimeTexture != null) {
                    var dayPath = MakeRelativePath(Path.GetDirectoryName(pathOut), (mtl.DaytimeTexture.Origin as PathOrigin).Path);
                    var nightPath = MakeRelativePath(Path.GetDirectoryName(pathOut), (mtl.NighttimeTexture.Origin as PathOrigin).Path);
                    writer.WriteLine(string.Format("LoadTexture,{0},{1}", dayPath, nightPath));
                    callback(ConvertUtil.Message.TextureHint, dayPath);
                    callback(ConvertUtil.Message.TextureHint, nightPath);
                } else if (mtl.DaytimeTexture != null) {
                    var dayPath = MakeRelativePath(Path.GetDirectoryName(pathOut), (mtl.DaytimeTexture.Origin as PathOrigin).Path);
                    writer.WriteLine(string.Format("LoadTexture,{0}", dayPath));
                    callback(ConvertUtil.Message.TextureHint, dayPath);
                }
			}
            writer.Close();

        }

        public static string MakeRelativePath(string workingDirectory, string fullPath) {
            string result = string.Empty;
            int offset;

            // this is the easy case.  The file is inside of the working directory.
            if (fullPath.StartsWith(workingDirectory)) {
                return fullPath.Substring(workingDirectory.Length + 1);
            }

            // the hard case has to back out of the working directory
            string[] baseDirs = workingDirectory.Split(new char[] { ':', '\\', '/' });
            string[] fileDirs = fullPath.Split(new char[] { ':', '\\', '/' });

            // if we failed to split (empty strings?) or the drive letter does not match
            if (baseDirs.Length <= 0 || fileDirs.Length <= 0 || baseDirs[0] != fileDirs[0]) {
                // can't create a relative path between separate harddrives/partitions.
                return fullPath;
            }

            // skip all leading directories that match
            for (offset = 1; offset < baseDirs.Length; offset++) {
                if (baseDirs[offset] != fileDirs[offset])
                    break;
            }

            // back out of the working directory
            for (int i = 0; i < (baseDirs.Length - offset); i++) {
                result += "..\\";
            }

            // step into the file path
            for (int i = offset; i < fileDirs.Length - 1; i++) {
                result += fileDirs[i] + "\\";
            }

            // append the file
            result += fileDirs[fileDirs.Length - 1];

            return result;
        }
    }
}