using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Bussiness.EntityConfiguration.Models
{
    public class AirInfo
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Direction { get; set; }
        public int Var { get; set; }
        public string Avia { get; set; }
        public DateTime Posadka { get; set; }
        public string Perron { get; set; }
        public string Status { get; set; }
        public int Price1 { get; set; }
        public int Price2 { get; set; }
    }
}