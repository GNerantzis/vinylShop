using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VinylShop.Models;

namespace VinylShop.Controllers
{
    public class VinylsController : Controller
    {
        private VinylShopDBContext db = new VinylShopDBContext();

        // GET: Vinyls
        public ActionResult Index()
        {
            return View(db.Vinyls.ToList());

        }

        // GET: Vinyls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Vinyl vinyl = db.Vinyls.Find(id);

            if (vinyl == null)
            {
                return HttpNotFound();
            }
            return View(vinyl);
        }

        // GET: Vinyls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vinyls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Artist,Title,ReleaseYear,Label,Genre,Price,image")] Vinyl vinyl)
        {
            if (ModelState.IsValid)
            {
                db.Vinyls.Add(vinyl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vinyl);
        }

        // GET: Vinyls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Vinyl vinyl = db.Vinyls.Find(id);
            if (vinyl == null)
            {
                return HttpNotFound();
            }
            return View(vinyl);
        }

        public ActionResult ToCart(int? id)
        {
            Vinyl vinyl = db.Vinyls.Find(id);
            Customer customer = db.Customers.Find(1);

            customer.Vinyls.Add(vinyl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        // POST: Vinyls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Artist,Title,ReleaseYear,Label,Genre,Price,image")] Vinyl vinyl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vinyl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vinyl);
        }

        // GET: Vinyls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vinyl vinyl = db.Vinyls.Find(id);
            if (vinyl == null)
            {
                return HttpNotFound();
            }
            return View(vinyl);
        }

        // POST: Vinyls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vinyl vinyl = db.Vinyls.Find(id);
            db.Vinyls.Remove(vinyl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
