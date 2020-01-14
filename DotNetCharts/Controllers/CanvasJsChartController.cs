using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class CanvasJsChartController : Controller
    {
        //Library Link : https://canvasjs.com/javascript-charts

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ColumnChart()
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
    }
}