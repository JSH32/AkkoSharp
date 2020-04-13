using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Akko.Config
{
    public class Manager
    {
        public static void Load()
        {
            if (File.Exists("config.json"))
            {
                string configfile = File.ReadAllText("config.json");
                var config = (JObject)JsonConvert.DeserializeObject(configfile);
                
                // Setting config values to global
                Config.Prefix = config["Prefix"].Value<string>();
                Config.Token = config["Token"].Value<string>();
                Config.MongoURL = config["MongoURL"].Value<string>();
                Config.DBName = config["DBName"].Value<string>();
            }
            else
            {
                Console.WriteLine("No config found!");
                System.Environment.Exit(0);
            }
        }
        
    }
}