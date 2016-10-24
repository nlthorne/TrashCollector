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
    [Authorize(Roles = "Admin, Customer")]
    public class Credit_CardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Credit_Card
        public ActionResult Index()
        {
            return View(db.Credit_Card.ToList());
        }

        // GET: Credit_Card/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Card credit_Card = db.Credit_Card.Find(id);
            if (credit_Card == null)
            {
                return HttpNotFound();
            }
            return View(credit_Card);
        }

        // GET: Credit_Card/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Credit_Card/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Provider,Full_Name,Number,Exp_Date,CVC,addressID")] Credit_Card credit_Card)
        {
            if (ModelState.IsValid)
            {
                db.Credit_Card.Add(credit_Card);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(credit_Card);
        }

        // GET: Credit_Card/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Card credit_Card = db.Credit_Card.Find(id);
            if (credit_Card == null)
            {
                return HttpNotFound();
            }
            return View(credit_Card);
        }

        // POST: Credit_Card/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Provider,Full_Name,Number,Exp_Date,CVC,addressID")] Credit_Card credit_Card)
        {
            if (ModelState.IsValid)
            {
                db.Entry(credit_Card).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(credit_Card);
        }

        // GET: Credit_Card/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Credit_Card credit_Card = db.Credit_Card.Find(id);
            if (credit_Card == null)
            {
                return HttpNotFound();
            }
            return View(credit_Card);
        }

        // POST: Credit_Card/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Credit_Card credit_Card = db.Credit_Card.Find(id);
            db.Credit_Card.Remove(credit_Card);
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
