using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class Pickup_TimesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Pickup_Times
        public ActionResult Index()
        {
            return View(db.Pickup_Times.ToList());
        }

        // GET: Pickup_Times/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup_Times pickup_Times = db.Pickup_Times.Find(id);
            if (pickup_Times == null)
            {
                return HttpNotFound();
            }
            return View(pickup_Times);
        }

        // GET: Pickup_Times/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pickup_Times/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Day,Vacation")] Pickup_Times pickup_Times)
        {
            if (ModelState.IsValid)
            {
                db.Pickup_Times.Add(pickup_Times);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickup_Times);
        }

        // GET: Pickup_Times/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup_Times pickup_Times = db.Pickup_Times.Find(id);
            if (pickup_Times == null)
            {
                return HttpNotFound();
            }
            return View(pickup_Times);
        }

        // POST: Pickup_Times/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Day,Vacation")] Pickup_Times pickup_Times)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickup_Times).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickup_Times);
        }

        // GET: Pickup_Times/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pickup_Times pickup_Times = db.Pickup_Times.Find(id);
            if (pickup_Times == null)
            {
                return HttpNotFound();
            }
            return View(pickup_Times);
        }

        // POST: Pickup_Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pickup_Times pickup_Times = db.Pickup_Times.Find(id);
            db.Pickup_Times.Remove(pickup_Times);
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
