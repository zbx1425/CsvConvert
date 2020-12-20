using System;
using OpenBveApi.Hosts;
using OpenBveApi.Interface;
using OpenBveApi.Textures;

namespace CsvConvert {
  
	public class DummyHostInterface : HostInterface {
		
		private readonly ConvertUtil.LogHandler callback;
  		
		public DummyHostInterface(ConvertUtil.LogHandler callback) : base(HostApplication.OpenBve) {
			this.callback = callback;
		}
		
		public override void ReportProblem(ProblemType type, string text) {
			callback(ConvertUtil.Message.GeneralError, text);
		}

        public override void AddMessage(MessageType type, bool FileNotFound, string text) {
            //HACK: Ignore this false warning
            if (text == "Unrecognised command o") return;

            switch (type) {
                case MessageType.Critical:
                    callback(ConvertUtil.Message.GeneralError, text); break;
                case MessageType.Error:
                    callback(ConvertUtil.Message.GeneralError, text); break;
                case MessageType.Warning:
                    callback(ConvertUtil.Message.GeneralWarning, text); break;
                case MessageType.Information:
                    callback(ConvertUtil.Message.GeneralInfo, text); break;
            }
            
        }

        public override bool RegisterTexture(string path, TextureParameters parameters, out Texture handle) {
            handle = new Texture(path, parameters, this);
            return true;
            // return base.RegisterTexture(path, parameters, out handle);
        }

        public override OpenBveApi.Trains.AbstractTrain ParseTrackFollowingObject(string objectPath, string tfoFile) {
			throw new NotImplementedException();
		}
	}
}
