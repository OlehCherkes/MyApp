using MyApp.Bussiness.EntityConfiguration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AirContext db = new AirContext();
        [Authorize]
        public ActionResult Index()
        {
            var airs = db.AirInfos;
            ViewBag.Airs = airs;
            return View();
        }
    }
}