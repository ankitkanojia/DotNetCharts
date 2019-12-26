using System.Web.Mvc;

namespace DotNetCharts.Controllers
{
    public class HighChartController : Controller
    {
        //Library Link : https://www.highcharts.com/demo

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ColumnChart()
        {
            return View();
        }

        public ActionResult BarChart()
        {
            return View();
        }
    }
}