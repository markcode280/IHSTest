using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IHSTest.Services
{
    public class JsonService : IFileService
    {
        private string fileLocation;

        public JsonService(string FileLocation)
        {
            fileLocation = FileLocation;
        }

        public void Save(object text)
        {
            
           var jsonSerializer = new JsonSerializer();
           var result= JsonConvert.SerializeObject(text);

            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation);
            }
                using (StreamWriter writer = File.CreateText(Environment.CurrentDirectory + "/Locations.json"))
                {
                        jsonSerializer.Serialize(writer, result);
                }
        }
    }
}