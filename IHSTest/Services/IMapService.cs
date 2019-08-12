using IHSTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSTest.Services
{
    public interface IMapService
    {
        void SaveLocation(MapLocation location);
        MapLocation GetLocation();
        
           
    }
}
