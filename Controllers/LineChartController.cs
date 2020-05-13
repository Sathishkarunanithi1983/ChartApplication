using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chartApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace chartApplication.Controllers
{
    public class LineChartController : Controller
    {
        // GET: /<controller>/  
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult PopulationChart()
        {
            var populationList = PopulationDataAccessaLayer.GetCityPopulationList();
            return Json(populationList);
        }
    }
}