using System.Web.Mvc;

// Use FusionCharts.Charts name space
using FusionCharts.Charts;

namespace DotNetCharts.Controllers
{
    public class FusionChartController : Controller
    {
        //Library Link : https://www.fusioncharts.com/charts/column-bar-charts/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BarChart()
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

        public ActionResult PieChart()
        {
            return View();
        }

        public ActionResult DonutChart()
        {
            return View();
        }

        public ActionResult StackedChart()
        {
            return View();
        }

        public ActionResult CombinedChart()
        {
            return View();
        }

        public ActionResult BubbleChart()
        {
            return View();
        }

        public ActionResult MarketShareChart()
        {
            return View();
        }

        public ActionResult ParetoChart()
        {
             return View();
        }

        public ActionResult ChartCombination()
        {
            return View();
        }
    }
}