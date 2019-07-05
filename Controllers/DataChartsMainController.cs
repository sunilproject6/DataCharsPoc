using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataCharsPoc.Controllers
{
    public class DataChartsMainController : Controller
    {
        // GET: DataChartsMain
        public ActionResult PieChart()
        {
            return View();
        }

        public ActionResult Donut()
        {
            return View();
        }

        public ActionResult ScaleLinerChart()
        {
            return View();
        }

        public ActionResult MultiLineChart()
        {
            return View();
        }

        public ActionResult HorizontalBarCharts()
        {
            return View();
        }

        public ActionResult PieChartWithLegend()
        {
            return View();
        }

        public ActionResult GroupedBarChart()
        {
            return View();
        }

        public ActionResult GroupedBarchartWithLegend()
        {
            return View();
        }
    }
}
