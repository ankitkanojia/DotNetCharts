using FusionCharts.DataEngine;
using FusionCharts.Visualization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Helpers;
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
            DataTable ChartData = new DataTable();
            ChartData.Columns.Add("Programming Language", typeof(System.String));
            ChartData.Columns.Add("Users", typeof(System.Double));
            ChartData.Rows.Add("Java", 62000);
            ChartData.Rows.Add("Python", 46000);
            ChartData.Rows.Add("Javascript", 38000);
            ChartData.Rows.Add("C++", 31000);
            ChartData.Rows.Add("C#", 27000);
            ChartData.Rows.Add("PHP", 14000);
            ChartData.Rows.Add("Perl", 14000);
            // Create static source with this data table

            StaticSource source = new StaticSource(ChartData);

            // Create instance of DataModel class
            DataModel model = new DataModel();

            // Add DataSource to the DataModel
            model.DataSources.Add(source);

            // Instantiate bar Chart
            Charts.BarChart bar = new Charts.BarChart("bar_chart");

            // Set Chart's width and height
            bar.Width.Pixel(500);
            bar.Height.Pixel(400);

            // Set DataModel instance as the data source of the chart
            bar.Data.Source = model;

            // Set Chart Title
            bar.Caption.Text = "Most popular programming language";
            ViewData["Chart"] = bar.Render();
            return View();
        }

        public ActionResult ColumnChart()
        {
            // Create data table to store data
            DataTable ChartData = new DataTable();

            // Add columns to data table
            ChartData.Columns.Add("Programming Language", typeof(System.String));
            ChartData.Columns.Add("Users", typeof(System.Double));

            // Add rows to data table
            ChartData.Rows.Add("Java", 62000);
            ChartData.Rows.Add("Python", 46000);
            ChartData.Rows.Add("Javascript", 38000);
            ChartData.Rows.Add("C++", 31000);
            ChartData.Rows.Add("C#", 27000);
            ChartData.Rows.Add("PHP", 14000);
            ChartData.Rows.Add("Perl", 14000);

            // Create static source with this data table
            StaticSource source = new StaticSource(ChartData);

            // Create instance of DataModel class
            DataModel model = new DataModel();

            // Add DataSource to the DataModel
            model.DataSources.Add(source);

            // Instantiate Column Chart
            Charts.ColumnChart column = new Charts.ColumnChart("firstchart");

            // Set the width and the height of the chart
            column.Width.Pixel(700);
            column.Height.Pixel(400);

            // Set DataModel instance as the data source of the chart
            column.Data.Source = model;

            // Set Chart Caption
            column.Caption.Text = "Most popular programming language";

            // Set Chart Subcaption
            column.SubCaption.Text = "2017-2018";

            // Hide Chart Legend
            column.Legend.Show = false;

            // Set X-axis Text
            column.XAxis.Text = "Programming Language";

            // Set Y-axis title
            column.YAxis.Text = "User";

            // Set chart theme
            column.ThemeName = FusionChartsTheme.ThemeName.FUSION;

            // Set chart rendering string in ViewData as a key-value pair
            ViewData["Chart"] = column.Render();

            // Return the view
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
            FusionCharts.Charts.Chart sales = new FusionCharts.Charts.Chart();

            // Setting chart id
            sales.SetChartParameter(FusionCharts.Charts.Chart.ChartParameter.chartId, "myChart");

            // Setting chart type to scrollline2d chart
            sales.SetChartParameter(FusionCharts.Charts.Chart.ChartParameter.chartType, "scrollline2d");

            // Setting chart width to 600px
            sales.SetChartParameter(FusionCharts.Charts.Chart.ChartParameter.chartWidth, "600");

            // Setting chart height to 350px
            sales.SetChartParameter(FusionCharts.Charts.Chart.ChartParameter.chartHeight, "350");

            // Setting chart data as JSON String (Uncomment below line
            sales.SetData("{\n  \"chart\": {\n    \"caption\": \"Deaths reported because of mosquito bites in India\",\n    \"subcaption\": \"(As per government records)\",\n    \"showvalues\": \"0\",\n    \"numvisibleplot\": \"12\",\n    \"plottooltext\": \"<b>$dataValue</b> people died because of mosquito bites in $label\",\n    \"theme\": \"fusion\"\n  },\n  \"categories\": [\n    {\n      \"category\": [\n        {\n          \"label\": \"1994\"\n        },\n        {\n          \"label\": \"1995\"\n        },\n        {\n          \"label\": \"1996\"\n        },\n        {\n          \"label\": \"1997\"\n        },\n        {\n          \"label\": \"1998\"\n        },\n        {\n          \"label\": \"1999\"\n        },\n        {\n          \"label\": \"2000\"\n        },\n        {\n          \"label\": \"2001\"\n        },\n        {\n          \"label\": \"2002\"\n        },\n        {\n          \"label\": \"2003\"\n        },\n        {\n          \"label\": \"2004\"\n        },\n        {\n          \"label\": \"2005\"\n        },\n        {\n          \"label\": \"2006\"\n        },\n        {\n          \"label\": \"2007\"\n        },\n        {\n          \"label\": \"2008\"\n        },\n        {\n          \"label\": \"2009\"\n        },\n        {\n          \"label\": \"2010\"\n        },\n        {\n          \"label\": \"2011\"\n        },\n        {\n          \"label\": \"2012\"\n        },\n        {\n          \"label\": \"2013\"\n        },\n        {\n          \"label\": \"2014\"\n        },\n        {\n          \"label\": \"2015\"\n        },\n        {\n          \"label\": \"2016\"\n        },\n        {\n          \"label\": \"2017\"\n        }\n      ]\n    }\n  ],\n  \"dataset\": [\n    {\n      \"data\": [\n        {\n          \"value\": \"15622\"\n        },\n        {\n          \"value\": \"10612\"\n        },\n        {\n          \"value\": \"15820\"\n        },\n        {\n          \"value\": \"26723\"\n        },\n        {\n          \"value\": \"35415\"\n        },\n        {\n          \"value\": \"25555\"\n        },\n        {\n          \"value\": \"81803\"\n        },\n        {\n          \"value\": \"47950\"\n        },\n        {\n          \"value\": \"42396\"\n        },\n        {\n          \"value\": \"19435\"\n        },\n        {\n          \"value\": \"9780\"\n        },\n        {\n          \"value\": \"23243\"\n        },\n        {\n          \"value\": \"28619\"\n        },\n        {\n          \"value\": \"8477\"\n        },\n        {\n          \"value\": \"3503\"\n        },\n        {\n          \"value\": \"14278\"\n        },\n        {\n          \"value\": \"30522\"\n        },\n        {\n          \"value\": \"61518\"\n        },\n        {\n          \"value\": \"24819\"\n        },\n        {\n          \"value\": \"16437\"\n        },\n        {\n          \"value\": \"21171\"\n        },\n        {\n          \"value\": \"1690\"\n        },\n        {\n          \"value\": \"2418\"\n        },\n        {\n          \"value\": \"11253\"\n        }\n      ]\n    }\n  ]\n}", FusionCharts.Charts.Chart.DataFormat.json);

            // Set chart rendering string in ViewData as a key-value pair
            ViewData["Chart"] = sales.Render();

            // Return the view
            return View();
        }
    }
}