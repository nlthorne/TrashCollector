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
    [Authorize(Roles = "Admin, Employee")]
    public class PickupAddressesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PickupAddresses
        public ActionResult Index()
        {
            return View(db.PickupAddresses.ToList());
        }

        // GET: PickupAddresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupAddress pickupAddress = db.PickupAddresses.Find(id);
            if (pickupAddress == null)
            {
                return HttpNotFound();
            }
            return View(pickupAddress);
        }

        // GET: PickupAddresses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PickupAddresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] PickupAddress pickupAddress)
        {
            if (ModelState.IsValid)
            {
                db.PickupAddresses.Add(pickupAddress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pickupAddress);
        }

        // GET: PickupAddresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupAddress pickupAddress = db.PickupAddresses.Find(id);
            if (pickupAddress == null)
            {
                return HttpNotFound();
            }
            return View(pickupAddress);
        }

        // POST: PickupAddresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID")] PickupAddress pickupAddress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pickupAddress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pickupAddress);
        }

        // GET: PickupAddresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PickupAddress pickupAddress = db.PickupAddresses.Find(id);
            if (pickupAddress == null)
            {
                return HttpNotFound();
            }
            return View(pickupAddress);
        }

        // POST: PickupAddresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PickupAddress pickupAddress = db.PickupAddresses.Find(id);
            db.PickupAddresses.Remove(pickupAddress);
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
