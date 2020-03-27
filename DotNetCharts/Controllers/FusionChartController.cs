﻿using System.Web.Mvc;

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
            // This page demonstrates the ease of generating charts using FusionCharts.
            // For this chart, we've used a pre-defined Data.xml (contained in /Data/ folder)
            // Ideally, you would NOT use a physical data file. Instead you'll have
            // your own ASP.NET scripts virtually relay the XML data document.
            // FusionCharts supports various data format, please comment the code for
            // current data format (Chart.DataFormat.xmlurl) and uncomment the required format to view respective examples.
            // For a head-start, we've kept this example very simple.

            // Create the chart - pareto2d Chart with data from Data/Data.xml
            Chart sales = new Chart();

            // Setting chart id
            sales.SetChartParameter(Chart.ChartParameter.chartId, "myChart");

            // Setting chart type to pareto2d chart
            sales.SetChartParameter(Chart.ChartParameter.chartType, "pareto2d");

            // Setting chart width to 600px
            sales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");

            // Setting chart height to 350px
            sales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");

            // Setting chart data as JSON String (Uncomment below line
            sales.SetData("{\n  \"chart\": {\n    \"caption\": \"Late arrivals by reported cause\",\n    \"subcaption\": \"Last month\",\n    \"pyaxisname\": \"No. of Occurrence\",\n    \"theme\": \"fusion\",\n    \"showsecondarylimits\": \"0\",\n    \"showdivlinesecondaryvalue\": \"0\",\n    \"plottooltext\": \"Due to $label, late arrivals count is : <b>$dataValue</b> of the total <b>$sum</b> employees\",\n    \"drawcrossline\": \"1\"\n  },\n  \"data\": [\n    {\n      \"label\": \"Traffic\",\n      \"value\": \"5680\"\n    },\n    {\n      \"label\": \"Family Engagement\",\n      \"value\": \"1036\"\n    },\n    {\n      \"label\": \"Public Transport\",\n      \"value\": \"950\"\n    },\n    {\n      \"label\": \"Weather\",\n      \"value\": \"500\"\n    },\n    {\n      \"label\": \"Emergency\",\n      \"value\": \"140\"\n    },\n    {\n      \"label\": \"Others\",\n      \"value\": \"68\"\n    }\n  ]\n}", Chart.DataFormat.json);

            ViewData["Chart"] = sales.Render();

            //Return the view
            return View();
        }

        public ActionResult ChartCombination()
        {
            Chart sales = new Chart();
            sales.SetChartParameter(Chart.ChartParameter.chartId, "chartBar");
            sales.SetChartParameter(Chart.ChartParameter.chartType, "bar2d");
            sales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");
            sales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");
            sales.SetData("{\n  \"chart\": {\n    \"caption\": \"Lead sources by industry\",\n    \"yaxisname\": \"Number of Leads\",\n    \"aligncaptionwithcanvas\": \"0\",\n    \"plottooltext\": \"<b>$dataValue</b> leads received\",\n    \"theme\": \"fusion\"\n  },\n  \"data\": [\n    {\n      \"label\": \"Travel & Leisure\",\n      \"value\": \"41\"\n    },\n    {\n      \"label\": \"Advertising/Marketing/PR\",\n      \"value\": \"39\"\n    },\n    {\n      \"label\": \"Other\",\n      \"value\": \"38\"\n    },\n    {\n      \"label\": \"Real Estate\",\n      \"value\": \"32\"\n    },\n    {\n      \"label\": \"Communications/Cable/Phone\",\n      \"value\": \"26\"\n    },\n    {\n      \"label\": \"Construction\",\n      \"value\": \"25\"\n    },\n    {\n      \"label\": \"Entertainment\",\n      \"value\": \"25\"\n    },\n    {\n      \"label\": \"Staffing Firm/Full Time/Temporary\",\n      \"value\": \"24\"\n    },\n    {\n      \"label\": \"Transportation/Logistics\",\n      \"value\": \"23\"\n    },\n    {\n      \"label\": \"Utilities\",\n      \"value\": \"22\"\n    },\n    {\n      \"label\": \"Aerospace/Defense Products\",\n      \"value\": \"18\"\n    },\n    {\n      \"label\": \"Banking/Finance/Securities\",\n      \"value\": \"16\"\n    },\n    {\n      \"label\": \"Consumer Products - Non-Durables\",\n      \"value\": \"15\"\n    },\n    {\n      \"label\": \"Distribution\",\n      \"value\": \"13\"\n    },\n    {\n      \"label\": \"Education\",\n      \"value\": \"12\"\n    },\n    {\n      \"label\": \"Health Products & Services\",\n      \"value\": \"11\"\n    },\n    {\n      \"label\": \"Hospitality & Hotels\",\n      \"value\": \"10\"\n    },\n    {\n      \"label\": \"Non-Business/Residential\",\n      \"value\": \"6\"\n    },\n    {\n      \"label\": \"Pharmaceutical\",\n      \"value\": \"4\"\n    },\n    {\n      \"label\": \"Printing & Publishing\",\n      \"value\": \"1\"\n    },\n    {\n      \"label\": \"Professional Services\",\n      \"value\": \"1\"\n    },\n    {\n      \"label\": \"VAR/ISV\",\n      \"value\": \"1\"\n    },\n    {\n      \"label\": \"Warranty Administrators\",\n      \"value\": \"1\"\n    }\n  ]\n}", Chart.DataFormat.json);
            ViewData["chartBar"] = sales.Render();
           
            Chart pieSales = new Chart();
            pieSales.SetChartParameter(Chart.ChartParameter.chartId, "chartPie");
            pieSales.SetChartParameter(Chart.ChartParameter.chartType, "pie3d");
            pieSales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");
            pieSales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");
            pieSales.SetData("{\n  \"chart\": {\n    \"caption\": \"Recommended Portfolio Split\",\n    \"subcaption\": \"For a net-worth of $1M\",\n    \"showvalues\": \"1\",\n    \"showpercentintooltip\": \"0\",\n    \"numberprefix\": \"$\",\n    \"enablemultislicing\": \"1\",\n    \"theme\": \"fusion\"\n  },\n  \"data\": [\n    {\n      \"label\": \"Equity\",\n      \"value\": \"300000\"\n    },\n    {\n      \"label\": \"Debt\",\n      \"value\": \"230000\"\n    },\n    {\n      \"label\": \"Bullion\",\n      \"value\": \"180000\"\n    },\n    {\n      \"label\": \"Real-estate\",\n      \"value\": \"270000\"\n    },\n    {\n      \"label\": \"Insurance\",\n      \"value\": \"20000\"\n    }\n  ]\n}", Chart.DataFormat.json);
            ViewData["chartPie"] = pieSales.Render();

            Chart columnsales = new Chart();
            columnsales.SetChartParameter(Chart.ChartParameter.chartId, "chartColumn");
            columnsales.SetChartParameter(Chart.ChartParameter.chartType, "column2d");
            columnsales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");
            columnsales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");
            columnsales.SetData("{\n  \"chart\": {\n    \"caption\": \"Countries With Most Oil Reserves [2017-18]\",\n    \"subcaption\": \"In MMbbl = One Million barrels\",\n    \"xaxisname\": \"Country\",\n    \"yaxisname\": \"Reserves (MMbbl)\",\n    \"numbersuffix\": \"K\",\n    \"theme\": \"fusion\"\n  },\n  \"data\": [\n    {\n      \"label\": \"Venezuela\",\n      \"value\": \"290\"\n    },\n    {\n      \"label\": \"Saudi\",\n      \"value\": \"260\"\n    },\n    {\n      \"label\": \"Canada\",\n      \"value\": \"180\"\n    },\n    {\n      \"label\": \"Iran\",\n      \"value\": \"140\"\n    },\n    {\n      \"label\": \"Russia\",\n      \"value\": \"115\"\n    },\n    {\n      \"label\": \"UAE\",\n      \"value\": \"100\"\n    },\n    {\n      \"label\": \"US\",\n      \"value\": \"30\"\n    },\n    {\n      \"label\": \"China\",\n      \"value\": \"30\"\n    }\n  ]\n}", Chart.DataFormat.json);
            ViewData["chartColumn"] = columnsales.Render();

            Chart linesales = new Chart();
            linesales.SetChartParameter(Chart.ChartParameter.chartId, "chartLine");
            linesales.SetChartParameter(Chart.ChartParameter.chartType, "scrollline2d");
            linesales.SetChartParameter(Chart.ChartParameter.chartWidth, "600");
            linesales.SetChartParameter(Chart.ChartParameter.chartHeight, "350");
            linesales.SetData("{\n  \"chart\": {\n    \"caption\": \"Deaths reported because of mosquito bites in India\",\n    \"subcaption\": \"(As per government records)\",\n    \"showvalues\": \"0\",\n    \"numvisibleplot\": \"12\",\n    \"plottooltext\": \"<b>$dataValue</b> people died because of mosquito bites in $label\",\n    \"theme\": \"fusion\"\n  },\n  \"categories\": [\n    {\n      \"category\": [\n        {\n          \"label\": \"1994\"\n        },\n        {\n          \"label\": \"1995\"\n        },\n        {\n          \"label\": \"1996\"\n        },\n        {\n          \"label\": \"1997\"\n        },\n        {\n          \"label\": \"1998\"\n        },\n        {\n          \"label\": \"1999\"\n        },\n        {\n          \"label\": \"2000\"\n        },\n        {\n          \"label\": \"2001\"\n        },\n        {\n          \"label\": \"2002\"\n        },\n        {\n          \"label\": \"2003\"\n        },\n        {\n          \"label\": \"2004\"\n        },\n        {\n          \"label\": \"2005\"\n        },\n        {\n          \"label\": \"2006\"\n        },\n        {\n          \"label\": \"2007\"\n        },\n        {\n          \"label\": \"2008\"\n        },\n        {\n          \"label\": \"2009\"\n        },\n        {\n          \"label\": \"2010\"\n        },\n        {\n          \"label\": \"2011\"\n        },\n        {\n          \"label\": \"2012\"\n        },\n        {\n          \"label\": \"2013\"\n        },\n        {\n          \"label\": \"2014\"\n        },\n        {\n          \"label\": \"2015\"\n        },\n        {\n          \"label\": \"2016\"\n        },\n        {\n          \"label\": \"2017\"\n        }\n      ]\n    }\n  ],\n  \"dataset\": [\n    {\n      \"data\": [\n        {\n          \"value\": \"15622\"\n        },\n        {\n          \"value\": \"10612\"\n        },\n        {\n          \"value\": \"15820\"\n        },\n        {\n          \"value\": \"26723\"\n        },\n        {\n          \"value\": \"35415\"\n        },\n        {\n          \"value\": \"25555\"\n        },\n        {\n          \"value\": \"81803\"\n        },\n        {\n          \"value\": \"47950\"\n        },\n        {\n          \"value\": \"42396\"\n        },\n        {\n          \"value\": \"19435\"\n        },\n        {\n          \"value\": \"9780\"\n        },\n        {\n          \"value\": \"23243\"\n        },\n        {\n          \"value\": \"28619\"\n        },\n        {\n          \"value\": \"8477\"\n        },\n        {\n          \"value\": \"3503\"\n        },\n        {\n          \"value\": \"14278\"\n        },\n        {\n          \"value\": \"30522\"\n        },\n        {\n          \"value\": \"61518\"\n        },\n        {\n          \"value\": \"24819\"\n        },\n        {\n          \"value\": \"16437\"\n        },\n        {\n          \"value\": \"21171\"\n        },\n        {\n          \"value\": \"1690\"\n        },\n        {\n          \"value\": \"2418\"\n        },\n        {\n          \"value\": \"11253\"\n        }\n      ]\n    }\n  ]\n}", Chart.DataFormat.json);
            ViewData["chartLine"] = linesales.Render();

            return View();
        }
    }
}