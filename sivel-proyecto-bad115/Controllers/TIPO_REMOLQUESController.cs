using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sivel_proyecto_bad115.Models;

namespace sivel_proyecto_bad115.Controllers
{
    public class TIPO_REMOLQUESController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: TIPO_REMOLQUES
        public ActionResult Index()
        {
            return View(db.TIPO_REMOLQUES.ToList());
        }

        // GET: TIPO_REMOLQUES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_REMOLQUES tIPO_REMOLQUES = db.TIPO_REMOLQUES.Find(id);
            if (tIPO_REMOLQUES == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_REMOLQUES);
        }

        // GET: TIPO_REMOLQUES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_REMOLQUES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TREMOLQUE,TIPO_REMOLQUE,CAPACIDAD_REMOLQUE")] TIPO_REMOLQUES tIPO_REMOLQUES)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_REMOLQUES.Add(tIPO_REMOLQUES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_REMOLQUES);
        }

        // GET: TIPO_REMOLQUES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_REMOLQUES tIPO_REMOLQUES = db.TIPO_REMOLQUES.Find(id);
            if (tIPO_REMOLQUES == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_REMOLQUES);
        }

        // POST: TIPO_REMOLQUES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TREMOLQUE,TIPO_REMOLQUE,CAPACIDAD_REMOLQUE")] TIPO_REMOLQUES tIPO_REMOLQUES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_REMOLQUES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_REMOLQUES);
        }

        // GET: TIPO_REMOLQUES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_REMOLQUES tIPO_REMOLQUES = db.TIPO_REMOLQUES.Find(id);
            if (tIPO_REMOLQUES == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_REMOLQUES);
        }

        // POST: TIPO_REMOLQUES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_REMOLQUES tIPO_REMOLQUES = db.TIPO_REMOLQUES.Find(id);
            db.TIPO_REMOLQUES.Remove(tIPO_REMOLQUES);
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
