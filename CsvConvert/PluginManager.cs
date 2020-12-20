using OpenBveApi.FileSystem;
using OpenBveApi.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvConvert {

    public static class PluginManager {

        public static ObjectInterface[] interfaces;

        public static ConvertUtil.LogHandler logHandler;

        private static void callbackFunc(ConvertUtil.Message msg, object param) {
            Console.WriteLine(param);
            logHandler?.Invoke(msg, param);
        }

        static PluginManager() {
            var plugins = Directory.GetFiles(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "*.dll")
                .Where(f => Path.GetFileName(f).StartsWith("object.", StringComparison.OrdinalIgnoreCase));
            var types = plugins
                .SelectMany(f => Assembly.LoadFile(Path.GetFullPath(f)).ExportedTypes
                    .Where(t => typeof(ObjectInterface).IsAssignableFrom(t)));
            interfaces = types.Select(t => (ObjectInterface)Activator.CreateInstance(t)).ToArray();
            var host = new DummyHostInterface(callbackFunc);
            var fileSystem = (FileSystem)Activator.CreateInstance(typeof(FileSystem), true);
            foreach (var intf in interfaces) {
                try {
                    intf.Load(host, fileSystem);
                } catch (Exception ex) {
                    callbackFunc(ConvertUtil.Message.GeneralError, ex.ToString());
                }
            }
        }

        public static bool LoadObject(string path, Encoding encoding, out UnifiedObject obj) {
            foreach (var intf in interfaces) {
                if (intf.CanLoadObject(path) && intf.LoadObject(path, encoding, out obj)) return true;
            }
            obj = null;
            return false;
        }
    }
}
