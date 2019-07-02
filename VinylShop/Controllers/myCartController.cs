using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VinylShop.Controllers
{
    public class myCartController : Controller
    {
        // GET: myCart
        public ActionResult Index()
        {
            return View();
        }
    }
}