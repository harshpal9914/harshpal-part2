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
    [Authorize]
    public class ApplesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Apples
        public ActionResult Index()
        {
            return View(db.Apples.ToList());
        }

        // GET: Apples/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apple apple = db.Apples.Find(id);
            if (apple == null)
            {
                return HttpNotFound();
            }
            return View(apple);
        }

        // GET: Apples/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Apples/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "phones,Iphone1,Iphone2,Iphone3")] Apple apple)
        {
            if (ModelState.IsValid)
            {
                db.Apples.Add(apple);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apple);
        }

        // GET: Apples/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apple apple = db.Apples.Find(id);
            if (apple == null)
            {
                return HttpNotFound();
            }
            return View(apple);
        }

        // POST: Apples/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "phones,Iphone1,Iphone2,Iphone3")] Apple apple)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apple).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apple);
        }

        // GET: Apples/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apple apple = db.Apples.Find(id);
            if (apple == null)
            {
                return HttpNotFound();
            }
            return View(apple);
        }

        // POST: Apples/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apple apple = db.Apples.Find(id);
            db.Apples.Remove(apple);
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
