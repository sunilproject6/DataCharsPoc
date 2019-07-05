using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataCharsPoc.Models;

namespace DataCharsPoc.Controllers
{
    public class ChartDataJsonController : Controller
    {
        // GET: ChartDataJson
        public JsonResult MultilineChartData()
        {
            List<StockInfo> lst = new List<StockInfo>();
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 5, 1), close = (float)68.3, open = (float)34.12 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 4, 30), close = (float)63.98, open = (float)45.56 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 12, 27), close = (float)67.00, open = (float)67.89 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 12, 27), close = (float)67.00, open = (float)67.89 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 26), close = (float)89.70, open = (float)78.54 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 25), close = (float)99.00, open = (float)89.23 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 24), close = (float)130.28, open = (float)99.23 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 23), close = (float)166.70, open = (float)101.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 20), close = (float)234.98, open = (float)122.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 19), close = (float)345.44, open = (float)134.56 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 18), close = (float)443.34, open = (float)160.45 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 17), close = (float)543.70, open = (float)180.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 16), close = (float)580.13, open = (float)210.23 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 13), close = (float)605.23, open = (float)223.45 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 12), close = (float)622.77, open = (float)201.56 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 11), close = (float)626.20, open = (float)212.67 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 10), close = (float)628.44, open = (float)310.45 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 09), close = (float)628.44, open = (float)350.45 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 05), close = (float)633.68, open = (float)410.23 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 04), close = (float)624.31, open = (float)430.56 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 03), close = (float)629.32, open = (float)460.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 04, 02), close = (float)618.63, open = (float)510.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 03, 30), close = (float)599.55, open = (float)534.23 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 03, 29), close = (float)609.86, open = (float)578.23 });

            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 03, 28), close = (float)617.62, open = (float)590.12 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 03, 27), close = (float)614.48, open = (float)560.34 });
            lst.Add(new StockInfo() { Fulldate = new DateTime(2012, 03, 26), close = (float)606.98, open = (float)580.12 });



            JsonResult res = new JsonResult() { JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            res.Data = lst;
            return res;
        }

        // GET: ChartDataJson/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChartDataJson/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChartDataJson/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChartDataJson/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChartDataJson/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ChartDataJson/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChartDataJson/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
