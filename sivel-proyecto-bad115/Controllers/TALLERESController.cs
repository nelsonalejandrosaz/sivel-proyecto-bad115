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
    public class TALLERESController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: TALLERES
        public ActionResult Index()
        {
            return View(db.TALLERES.ToList());
        }

        // GET: TALLERES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLERES tALLERES = db.TALLERES.Find(id);
            if (tALLERES == null)
            {
                return HttpNotFound();
            }
            return View(tALLERES);
        }

        // GET: TALLERES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TALLERES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TALLER,NOMBRE")] TALLERES tALLERES)
        {
            if (ModelState.IsValid)
            {
                db.TALLERES.Add(tALLERES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tALLERES);
        }

        // GET: TALLERES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLERES tALLERES = db.TALLERES.Find(id);
            if (tALLERES == null)
            {
                return HttpNotFound();
            }
            return View(tALLERES);
        }

        // POST: TALLERES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TALLER,NOMBRE")] TALLERES tALLERES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tALLERES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tALLERES);
        }

        // GET: TALLERES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALLERES tALLERES = db.TALLERES.Find(id);
            if (tALLERES == null)
            {
                return HttpNotFound();
            }
            return View(tALLERES);
        }

        // POST: TALLERES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TALLERES tALLERES = db.TALLERES.Find(id);
            db.TALLERES.Remove(tALLERES);
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
