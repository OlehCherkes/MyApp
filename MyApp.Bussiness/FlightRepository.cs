using MyApp.Bussiness.EntityConfiguration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Bussiness
{
    public interface IFlightRepository
    {
        void AddPurchase(Purchase purchase);
    }

    public class FlightRepository: IFlightRepository
    {
        AirContext db = new AirContext();

        public void AddPurchase(Purchase purchase)
        {
            db.Purchases.Add(purchase);
            db.SaveChanges();
        }
    }
}
