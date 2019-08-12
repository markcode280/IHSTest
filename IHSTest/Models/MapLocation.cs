using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHSTest.Models
{
    public class MapLocation
    {
        
        public string Lat { get; set; }
        public string Long { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string PostCode { get; set; }
    }

    public enum FileFormat
    {
        json,
        text
    }
}