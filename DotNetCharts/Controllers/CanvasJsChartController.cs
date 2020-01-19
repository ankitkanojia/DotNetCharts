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

        public ActionResult BarChart()
        {
            return View();
        }

        public ActionResult PieChart()
        {
            return View();
        }

        public ActionResult FunnelChart()
        {
            return View();
        }

        public ActionResult FinancialChart()
        {
            return View();
        }

        public ActionResult BoxWhiskerChart()
        {
            return View();
        }

        public ActionResult ScatterChart()
        {
            return View();
        }

        public ActionResult BubbleChart()
        {
            return View();
        }
    }
}