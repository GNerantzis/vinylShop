using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VinylShop.Models;

namespace VinylShop.Controllers
{
    public class myCartController : Controller
    {

        private VinylShopDBContext db = new VinylShopDBContext();


        // GET: myCart
        public ActionResult Index()
        {
            Customer customer = db.Customers.Find(1);

            return View(customer);
        }

        public ActionResult DeleteFromCart(int? customerId, int vinylId)
        {
            var customer = db.Customers.Find(customerId);

            var temp = customer.Vinyls.Where(v => v.ID == vinylId).ToList();

            foreach (var item in temp)
            {
                if (item.ID == vinylId)
                {
                    customer.Vinyls.Remove(item);
                }
            }

            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}