using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class SamsungsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Samsungs
        public ActionResult Index()
        {
            return View(db.Samsungs.ToList());
        }

        // GET: Samsungs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samsung samsung = db.Samsungs.Find(id);
            if (samsung == null)
            {
                return HttpNotFound();
            }
            return View(samsung);
        }

        // GET: Samsungs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Samsungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "phones,Galaxy1,Galaxy2,Galaxy3")] Samsung samsung)
        {
            if (ModelState.IsValid)
            {
                db.Samsungs.Add(samsung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(samsung);
        }

        // GET: Samsungs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samsung samsung = db.Samsungs.Find(id);
            if (samsung == null)
            {
                return HttpNotFound();
            }
            return View(samsung);
        }

        // POST: Samsungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "phones,Galaxy1,Galaxy2,Galaxy3")] Samsung samsung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(samsung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(samsung);
        }

        // GET: Samsungs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Samsung samsung = db.Samsungs.Find(id);
            if (samsung == null)
            {
                return HttpNotFound();
            }
            return View(samsung);
        }

        // POST: Samsungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Samsung samsung = db.Samsungs.Find(id);
            db.Samsungs.Remove(samsung);
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
