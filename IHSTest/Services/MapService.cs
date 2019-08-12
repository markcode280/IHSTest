using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHSTest.Models;
using IHSTest.Extentions;
namespace IHSTest.Services
{
    public class MapService:IMapService
    {
        private IFileService fileService;

        public MapService(IFileService FileService)
        {
            fileService = FileService;
        }

        public MapLocation GetLocation()
        {
            throw new NotImplementedException();
        }

        public void SaveLocation(MapLocation location)
        {
           
            fileService.Save(location);
        }
    }
}