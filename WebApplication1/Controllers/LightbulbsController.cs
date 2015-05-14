using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LightbulbsController : Controller
    {
        private HowTo db = new HowTo();

        // GET: Lightbulbs
        public ActionResult Index()
        {
            return View(db.ALightBulb.ToList<Lightbulb>());
        }

        // GET: Lightbulbs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lightbulb lightbulb = db.ALightBulb.Find(id);
            if (lightbulb == null)
            {
                return HttpNotFound();
            }
            return View(lightbulb);
        }

        // GET: Lightbulbs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lightbulbs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,TableName,Step,Description")] Lightbulb lightbulb)
        {
            if (ModelState.IsValid)
            {
                db.ALightBulb.Add(lightbulb);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lightbulb);
        }

        // GET: Lightbulbs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lightbulb lightbulb = db.ALightBulb.Find(id);
            if (lightbulb == null)
            {
                return HttpNotFound();
            }
            return View(lightbulb);
        }

        // POST: Lightbulbs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,TableName,Step,Description")] Lightbulb lightbulb)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lightbulb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lightbulb);
        }

        // GET: Lightbulbs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lightbulb lightbulb = db.ALightBulb.Find(id);
            if (lightbulb == null)
            {
                return HttpNotFound();
            }
            return View(lightbulb);
        }

        // POST: Lightbulbs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lightbulb lightbulb = db.ALightBulb.Find(id);
            db.ALightBulb.Remove(lightbulb);
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
