using Brain_Pathology;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brain_Pathology
{
    internal class ServerInfo
    {
        public int Status { get; set; }
        public More Server { get; set; }
        public string Message { get; set; }
        public int ImagesCount { get; set; }
        public ModelInfo Model { get; set; }

        public static ServerInfo FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ServerInfo>(json);
        }
    }

    public class More
    {
        public string Name { get; set; }
        public int Port { get; set; }
    }

    public class ModelInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
    }
}


