﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class MorrisJsController : Controller
    {
        //Library Link : https://www.chartjs.org/docs/latest/getting-started/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }
    }
}