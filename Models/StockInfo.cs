using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataCharsPoc.Models
{
    public class StockInfo
    {
        public string date { get { return Fulldate.ToString("dd-MMM-yy"); } }

        public DateTime Fulldate { get; set; }
        public float close { get; set; }
        public float open { get; set; }
    }
}