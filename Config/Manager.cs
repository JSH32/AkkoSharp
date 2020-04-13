using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Akko.Config
{
    public class Manager
    {
        public Model Load()
        {
            string configfile = File.ReadAllText("config.json");
            Model config = JsonConvert.DeserializeObject<Model>(configfile);

            return config;
        }
        
    }
}