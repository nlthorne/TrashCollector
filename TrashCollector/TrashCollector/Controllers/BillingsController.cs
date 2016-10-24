using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using static TrashCollector.Controllers.ManageController;

namespace TrashCollector.Controllers
{
    [Authorize(Roles = "Admin, Customer")]
    public class BillingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Billings
        public ActionResult Index()
        {
            return View(db.Billing.ToList());
        }

        // GET: Billings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Billing billing = db.Billing.Find(id);
            if (billing == null)
            {
                return HttpNotFound();
            }
            return View(billing);
        }
        //public ActionResult HasCreditCard(int? CreditCardID)
        //{
        //    if (CreditCardID == null)
        //    {
        //        return View(db.Credit_Card.Create());
        //    }
        //    Credit_Card creditCard = db.Credit_Card.Find(CreditCardID);
        //    if (creditCard == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(creditCard);
        //}
        // GET: Billings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Billings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Recurring")] Billing billing)
        {
            if (ModelState.IsValid)
            {
                db.Billing.Add(billing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(billing);
        }

        // GET: Billings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Billing billing = db.Billing.Find(id);
            if (billing == null)
            {
                return HttpNotFound();
            }
            return View(billing);
        }

        // POST: Billings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Recurring,credit_CardID,online_MethodsID")] Billing billing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(billing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(billing);
        }

        // GET: Billings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Billing billing = db.Billing.Find(id);
            if (billing == null)
            {
                return HttpNotFound();
            }
            return View(billing);
        }

        // POST: Billings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Billing billing = db.Billing.Find(id);
            db.Billing.Remove(billing);
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
