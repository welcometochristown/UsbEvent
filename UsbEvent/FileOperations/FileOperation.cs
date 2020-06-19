using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsbActioner.FileOperations
{
    public static class FileOperation
    {
        public static void SaveContent<T>(T obj, string filename)
        {
            using(var sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
               sw.Write(JsonConvert.SerializeObject(obj, Formatting.Indented));
            }
        }

        public static T LoadObject<T>(string filename)
        {
            using (var sr = new StreamReader(filename, Encoding.UTF8))
            {
                string content = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(content);
            }
        }
    }
}
