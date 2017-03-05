using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;

namespace ClashofClansPatcher
{
    public class Keys
    {
        private static string KeyURl = ConfigurationManager.AppSettings["keysrcurl"];
        private static string DataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\\CoCPatcher";
        private static string DataFile  = Path.Combine(DataFolder, "keys.json");
        
        /// <summary>
        /// Get a clash of clans key from version
        /// </summary>
        /// <param name="version">Clash of Clans version</param>
        /// <returns>The key we found</returns>
        public static string GetKey(string version)
        {
            Dictionary<string,string> dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(DataFile));
            dic.TryGetValue(version, out string key);
            return key;

        }
        public static string[] Versions
        {
            get
            {
                if (!File.Exists(DataFile))
                {
                    DownloadKeys();
                }
                Dictionary<string, string> dic = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(DataFile));
                List<string> versions = new List<string>();
                foreach(string key in dic.Keys)
                {
                    versions.Add(key);
                }
                return versions.ToArray();
            }
        }
        public static void CheckFolderDirectory()
        {
            if (!Directory.Exists(DataFolder))
                Directory.CreateDirectory(DataFolder);
        }
        public static void DownloadKeys()
        {
            CheckFolderDirectory();
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(KeyURl), DataFile);
            }
        }
    }
}
