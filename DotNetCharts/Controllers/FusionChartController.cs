using System.Web.Mvc;

// Use FusionCharts.Charts name space
using FusionCharts.Charts;

namespace DotNetCharts.Controllers
{
    public class FusionChartController : Controller
    {
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
            // This page demonstrates the ease of generating charts using FusionCharts.
            // For this chart, we've used a pre-defined Data.xml (contained in /Data/ folder)
            // Ideally, you would NOT use a physical data file. Instead you'll have
            // your own ASP.NET scripts virtually relay the XML data document.
            // FusionCharts supports various data format, please comment the code for
            // current data format (Chart.DataFormat.xmlurl) and uncomment the required format to view respective examples.
            // For a head-start, we've kept this example very simple.

            // Create the chart - scrollline2d Chart with data from Data/Data.xml
            Chart sales = new Chart();

            // Setting chart id
            sales.SetChartParameter(Chart.ChartParameter.chartId, "myChart");

            // Setting chart type to scrollline2d chart
            sales.SetChartParameter(Chart.ChartParameter.chartType, "scrollline2d");

            // Setting chart width to 600px
            sales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

            // Setting chart height to 350px
            sales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");

            // Setting chart data as JSON String (Uncomment below line
            sales.SetData("{\n  \"chart\": {\n    \"caption\": \"Deaths reported because of mosquito bites in India\",\n    \"subcaption\": \"(As per government records)\",\n    \"showvalues\": \"0\",\n    \"numvisibleplot\": \"12\",\n    \"plottooltext\": \"<b>$dataValue</b> people died because of mosquito bites in $label\",\n    \"theme\": \"fusion\"\n  },\n  \"categories\": [\n    {\n      \"category\": [\n        {\n          \"label\": \"1994\"\n        },\n        {\n          \"label\": \"1995\"\n        },\n        {\n          \"label\": \"1996\"\n        },\n        {\n          \"label\": \"1997\"\n        },\n        {\n          \"label\": \"1998\"\n        },\n        {\n          \"label\": \"1999\"\n        },\n        {\n          \"label\": \"2000\"\n        },\n        {\n          \"label\": \"2001\"\n        },\n        {\n          \"label\": \"2002\"\n        },\n        {\n          \"label\": \"2003\"\n        },\n        {\n          \"label\": \"2004\"\n        },\n        {\n          \"label\": \"2005\"\n        },\n        {\n          \"label\": \"2006\"\n        },\n        {\n          \"label\": \"2007\"\n        },\n        {\n          \"label\": \"2008\"\n        },\n        {\n          \"label\": \"2009\"\n        },\n        {\n          \"label\": \"2010\"\n        },\n        {\n          \"label\": \"2011\"\n        },\n        {\n          \"label\": \"2012\"\n        },\n        {\n          \"label\": \"2013\"\n        },\n        {\n          \"label\": \"2014\"\n        },\n        {\n          \"label\": \"2015\"\n        },\n        {\n          \"label\": \"2016\"\n        },\n        {\n          \"label\": \"2017\"\n        }\n      ]\n    }\n  ],\n  \"dataset\": [\n    {\n      \"data\": [\n        {\n          \"value\": \"15622\"\n        },\n        {\n          \"value\": \"10612\"\n        },\n        {\n          \"value\": \"15820\"\n        },\n        {\n          \"value\": \"26723\"\n        },\n        {\n          \"value\": \"35415\"\n        },\n        {\n          \"value\": \"25555\"\n        },\n        {\n          \"value\": \"81803\"\n        },\n        {\n          \"value\": \"47950\"\n        },\n        {\n          \"value\": \"42396\"\n        },\n        {\n          \"value\": \"19435\"\n        },\n        {\n          \"value\": \"9780\"\n        },\n        {\n          \"value\": \"23243\"\n        },\n        {\n          \"value\": \"28619\"\n        },\n        {\n          \"value\": \"8477\"\n        },\n        {\n          \"value\": \"3503\"\n        },\n        {\n          \"value\": \"14278\"\n        },\n        {\n          \"value\": \"30522\"\n        },\n        {\n          \"value\": \"61518\"\n        },\n        {\n          \"value\": \"24819\"\n        },\n        {\n          \"value\": \"16437\"\n        },\n        {\n          \"value\": \"21171\"\n        },\n        {\n          \"value\": \"1690\"\n        },\n        {\n          \"value\": \"2418\"\n        },\n        {\n          \"value\": \"11253\"\n        }\n      ]\n    }\n  ]\n}", Chart.DataFormat.json);

            // Set chart rendering string in ViewData as a key-value pair
            ViewData["Chart"] = sales.Render();

            // Return the view
            return View();
        }
    }
}