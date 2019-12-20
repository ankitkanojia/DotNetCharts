using FusionCharts.DataEngine;
using FusionCharts.Visualization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            Charts.BarChart bar = new Charts.BarChart("column_chart");

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
    }
}