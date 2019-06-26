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
    public class BODEGASController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: BODEGAS
        [Authorize]
        public ActionResult Index()
        {
            return View(db.BODEGAS.ToList());
        }

        // GET: BODEGAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BODEGAS bODEGAS = db.BODEGAS.Find(id);
            if (bODEGAS == null)
            {
                return HttpNotFound();
            }
            return View(bODEGAS);
        }

        // GET: BODEGAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BODEGAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_BODEGA,NOMBRE,CAPACIDAD_MAX")] BODEGAS bODEGAS)
        {
            if (ModelState.IsValid)
            {
                db.BODEGAS.Add(bODEGAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bODEGAS);
        }

        // GET: BODEGAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BODEGAS bODEGAS = db.BODEGAS.Find(id);
            if (bODEGAS == null)
            {
                return HttpNotFound();
            }
            return View(bODEGAS);
        }

        // POST: BODEGAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_BODEGA,NOMBRE,CAPACIDAD_MAX")] BODEGAS bODEGAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bODEGAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bODEGAS);
        }

        // GET: BODEGAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BODEGAS bODEGAS = db.BODEGAS.Find(id);
            if (bODEGAS == null)
            {
                return HttpNotFound();
            }
            return View(bODEGAS);
        }

        // POST: BODEGAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BODEGAS bODEGAS = db.BODEGAS.Find(id);
            db.BODEGAS.Remove(bODEGAS);
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
