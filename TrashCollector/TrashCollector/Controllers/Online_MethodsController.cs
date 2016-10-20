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
    public class Online_MethodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Online_Methods
        public ActionResult Index()
        {
            return View(db.Online_Methods.ToList());
        }

        // GET: Online_Methods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Online_Methods online_Methods = db.Online_Methods.Find(id);
            if (online_Methods == null)
            {
                return HttpNotFound();
            }
            return View(online_Methods);
        }

        // GET: Online_Methods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Online_Methods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Provider,Login")] Online_Methods online_Methods)
        {
            if (ModelState.IsValid)
            {
                db.Online_Methods.Add(online_Methods);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(online_Methods);
        }

        // GET: Online_Methods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Online_Methods online_Methods = db.Online_Methods.Find(id);
            if (online_Methods == null)
            {
                return HttpNotFound();
            }
            return View(online_Methods);
        }

        // POST: Online_Methods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Provider,Login")] Online_Methods online_Methods)
        {
            if (ModelState.IsValid)
            {
                db.Entry(online_Methods).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(online_Methods);
        }

        // GET: Online_Methods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Online_Methods online_Methods = db.Online_Methods.Find(id);
            if (online_Methods == null)
            {
                return HttpNotFound();
            }
            return View(online_Methods);
        }

        // POST: Online_Methods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Online_Methods online_Methods = db.Online_Methods.Find(id);
            db.Online_Methods.Remove(online_Methods);
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
