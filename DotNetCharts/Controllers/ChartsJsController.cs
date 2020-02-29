using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class ChartsJsController : Controller
    {
        //Library Link : https://www.chartjs.org/docs/latest/getting-started/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LineChart()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }

        public ActionResult RadarChart()
        {
            return View();
        }

        public ActionResult AreaChart()
        {
            return View();
        }

        public ActionResult PolarChart()
        {
            return View();
        }

        public ActionResult BubbleChart()
        {
            return View();
        }
    }
}