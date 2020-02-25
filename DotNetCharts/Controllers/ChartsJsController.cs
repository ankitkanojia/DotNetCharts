using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class ChartsJsController : Controller
    {
        // GET: ChartsJs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LineChart()
        {
            return View();
        }
    }
}