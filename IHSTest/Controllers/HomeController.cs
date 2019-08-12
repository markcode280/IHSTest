using IHSTest.Models;
using IHSTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IHSTest.Controllers
{
    public class HomeController : Controller
    {
        private IFileService fileServicer;
        private IMapService mapService;

        public HomeController()
        {
            fileServicer = new TextFileService(Environment.CurrentDirectory+"\\TextFile.txt");
            mapService = new MapService(fileServicer);
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LocationBySearch data)
        {
            mapService.SaveLocation(new MapLocation()
            {
                CityName = data.display_name.Split(',').FirstOrDefault(),
                CountryName = data.display_name.Split(',').LastOrDefault(),
                PostCode= data.display_name.Split(',').Skip(3).FirstOrDefault(),
                Lat = data.lat,
                Long= data.lon
            });
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}