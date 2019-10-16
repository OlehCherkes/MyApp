using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Bussiness.EntityConfiguration.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int AirId { get; set; }
        public int Class { get; set; }
        public string Serial { get; set; }
        public DateTime Date { get; set; }
    }
}