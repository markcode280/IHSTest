using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using IHSTest.Extentions;

namespace IHSTest.Services
{
    public class TextFileService : IFileService
    {
        private string fileLocation;

        public TextFileService(string FileLocation)
        {
            fileLocation = FileLocation;
        }
        public void Save(object text) 
        {
            var items = text.ConvertPropertyToStringObj();
            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation);
            }
                using (StreamWriter writer = File.CreateText(fileLocation))
                {
                    foreach (var item in items)
                    {
                  
                        writer.WriteLine(item);
                       
                    }

                }
                    
                
            }
        }
    }
