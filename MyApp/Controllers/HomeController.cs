using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyApp.Bussiness;
using MyApp.Bussiness.EntityConfiguration.Models;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        IFlightRepository flightRepository;

        public HomeController()
        {
            flightRepository = new FlightRepository();
        }

        AirContext db = new AirContext();
        public ActionResult Index(int page = 1)
        {
            var airs = db.AirInfos;
            ViewBag.Airs = airs;


                int pageSize = 3; // количество объектов на страницу
                IEnumerable<AirInfo> airinfosPerPages = airinfo.Skip((page - 1) * pageSize).Take(pageSize);
                PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = phones.Count };
                IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Phones = phonesPerPages };
                return View(ivm);


            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.AirId = id;
            return View();
        }

        [HttpPost]
        public ActionResult Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;


            flightRepository.AddPurchase(purchase);

            if (purchase.Person == null || purchase.LastName == null)
            {
                //return "Информация не была введена!";
                return Redirect("/Home/Buy");
            }
            return Content("Спасибо, " + purchase.Person + ' ' + purchase.LastName + ", за покупку!)");
        }


        AirContext dbPassengers = new AirContext();
        [Authorize]
        public ActionResult Info(int id)
        {
            var purchases = dbPassengers.Purchases;
            ViewBag.Purchases = purchases;
            return View();
        }


        //Поиск
        [HttpPost]
        public ActionResult AirSearch(string name, DateTime name2)
        {
            var allAirs = db.AirInfos.Where(a => a.Direction.Equals(name, StringComparison.InvariantCultureIgnoreCase)).ToList();
            var allAirs2 = db.AirInfos.Where(a => DbFunctions.TruncateTime(a.Time).Value.Equals(name2)).ToList();
            //if (allAirs.Count <= 0)
            //{
            //    return HttpNotFound();
            //}
            if (allAirs.Count >= 0 && allAirs2.Count <= 0)
            {
                return Content("Рейс не найден!");
            }
            else if (allAirs.Count <= 0 && allAirs2.Count >= 0)
            {
                return Content("Рейс не найден!");
            }
            return View(allAirs);
        }



        public ActionResult Create()
        {
            AirInfo airinfo = new AirInfo();
            return View(airinfo);
        }

        //Добавление нового рейса
        [HttpPost]
        public ActionResult Create(AirInfo airinfo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.AirInfos.Add(airinfo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(String.Empty, ex);
            }
            return View(airinfo);
        }


        public ActionResult Edit(int Id)
        {
            var airinfoEdit = (from airinfo in db.AirInfos
                               where airinfo.Id == Id
                               select airinfo).First();
            return View(airinfoEdit);
        }

        [HttpPost]
        public ActionResult Edit(int Id, FormCollection collection)
        {
            var airinfoEdit = (from airinfo in db.AirInfos
                               where airinfo.Id == Id
                               select airinfo).First();

            try
            {
                UpdateModel(airinfoEdit);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(airinfoEdit);
            }
            
        }

        public ActionResult Delete(int Id)
        {
            var airinfoDelete = (from airinfo in db.AirInfos
                               where airinfo.Id == Id
                               select airinfo).First();

            return View(airinfoDelete);
        }

        [HttpPost]
        public ActionResult Delete(int Id, FormCollection collection)
        {
            var airinfoDelete = (from airinfo in db.AirInfos
                                 where airinfo.Id == Id
                                 select airinfo).First();

            try
            {
                db.DeleteObject(airinfoDelete);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(airinfoDelete);
            }

        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Authorization()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}