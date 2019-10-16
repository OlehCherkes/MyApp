using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyApp.Models;

namespace MyApp.Bussiness.EntityConfiguration.Models
{
    public class AirContext : DbContext
    {
        public DbSet <AirInfo> AirInfos { get; set; }
        public DbSet <Purchase> Purchases { get; set; }
        public DbSet<User> Users { get; set; }

        public void DeleteObject(AirInfo airinfoDelete)
        {
            throw new NotImplementedException();
        }
    }
    public class AirDbInitializer : DropCreateDatabaseAlways<AirContext>
    {
        protected override void Seed (AirContext db)
        {
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 16, 0, 0), Direction = "Mosskow", Var = 1313, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = "Delay", Price1 = 150, Price2 = 100 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 16, 30, 0), Direction = "Prague", Var = 1211, Avia = "MAU", Posadka = DateTime.Today, Perron = "M2", Status = " ", Price1 = 240, Price2 = 210 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 17, 15, 0), Direction = "Paris", Var = 1111, Avia = "Air France", Posadka = DateTime.Today, Perron = "M3", Status = "Delay", Price1 = 280, Price2 = 240 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 17, 30, 0), Direction = "Belgium", Var = 4476, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = " ", Price1 = 220, Price2 = 180 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 18, 0, 0), Direction = "New York", Var = 8899, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = " ", Price1 = 550, Price2 = 480 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 19, 15, 0), Direction = "Warszawa", Var = 4455, Avia = "MAU", Posadka = DateTime.Today, Perron = "M2", Status = " ", Price1 = 110, Price2 = 75 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 21, 0, 0), Direction = "Tokio", Var = 7654, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = "Canceled", Price1 = 770, Price2 = 660 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 21, 30, 0), Direction = "Roma", Var = 8819, Avia = "MAU", Posadka = DateTime.Today, Perron = "M2", Status = " ", Price1 = 540, Price2 = 440 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 22, 0, 0), Direction = "Tbilisi", Var = 1199, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = " ", Price1 = 220, Price2 = 180 });
            db.AirInfos.Add(new AirInfo {Time = new DateTime(2018, 12, 20, 23, 30, 0), Direction = "Cyprus", Var = 8339, Avia = "MAU", Posadka = DateTime.Today, Perron = "M1", Status = " ", Price1 = 570, Price2 = 490 });


            db.Purchases.Add(new Purchase {Person = "Богдан", LastName = "Ступка", Address = "bogdan@gmail.com", Date = DateTime.Today, Class = 1, Serial ="AA883373"});
            db.Purchases.Add(new Purchase {Person = "Петро", LastName = "Порошенко", Address = "roshen@gmail.com", Date = DateTime.Today, Class = 1,  Serial = "EA883921" });
            db.Purchases.Add(new Purchase {Person = "Онопа", LastName = "Карина", Address = "onkar@mail.ru", Date = DateTime.Today, Class = 2, Serial = "UI127734" });
            db.Purchases.Add(new Purchase {Person = "Ян", LastName = "Максимов", Address = "o2@mail.ru", Date = DateTime.Today, Class = 2, Serial = "AA883271" });
            db.Purchases.Add(new Purchase {Person = "Друзь", LastName = "Мария", Address = "3kar@mail.ru", Date = DateTime.Today, Class = 2, Serial = "AW994522" });
            db.Purchases.Add(new Purchase {Person = "Гребенюк", LastName = "Дмитрий", Address = "34kar@mail.ru", Date = DateTime.Today, Class = 2, Serial = "AA844333" });
            db.Purchases.Add(new Purchase {Person = "Сергей", LastName = "Притула", Address = "55r@mail.ru", Date = DateTime.Today, Class = 1, Serial = "CX883243" });
            db.Purchases.Add(new Purchase {Person = "Бока", LastName = "Анастасия", Address = "4r@mail.ru", Date = DateTime.Today, Class = 2, Serial = "AA883129" });
            db.Purchases.Add(new Purchase {Person = "Кудзь", LastName = "Юлия", Address = "on4@mail.ru", Date = DateTime.Today, Class = 1, Serial = "AA883199" });
            db.Purchases.Add(new Purchase {Person = "Петров", LastName = "Игорь", Address = "on4ar@mail.ru", Date = DateTime.Today, Class = 1, Serial = "OL889967" });


            db.Users.Add(new User { Email = "Admin", Password = "1234" });
        }
    }
}   