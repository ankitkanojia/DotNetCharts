using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class d3ChartController : Controller
    {
        //Library Link : https://www.d3-graph-gallery.com

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }

        public ActionResult AreaChart()
        {
            return View();
        }

        public ActionResult PieChart()
        {
            return View();
        }
    }
}