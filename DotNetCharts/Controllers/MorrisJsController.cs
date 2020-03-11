using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class MorrisJsController : Controller
    {
        //Library Link : https://morrisjs.github.io/morris.js/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }

        public ActionResult LineChart()
        {
            return View();
        }

        public ActionResult AreaChart()
        {
            return View();
        }

        public ActionResult DonutChart()
        {
            return View();
        }

        public ActionResult PieChart()
        {
            return View();
        }
    }
}