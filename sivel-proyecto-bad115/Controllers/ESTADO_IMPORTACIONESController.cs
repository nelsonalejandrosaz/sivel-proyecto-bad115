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
    public class ESTADO_IMPORTACIONESController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: ESTADO_IMPORTACIONES
        public ActionResult Index()
        {
            return View(db.ESTADO_IMPORTACIONES.ToList());
        }

        // GET: ESTADO_IMPORTACIONES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES = db.ESTADO_IMPORTACIONES.Find(id);
            if (eSTADO_IMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            return View(eSTADO_IMPORTACIONES);
        }

        // GET: ESTADO_IMPORTACIONES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ESTADO_IMPORTACIONES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_EIMPORTACION,ESTADO_IMPORTACION")] ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES)
        {
            if (ModelState.IsValid)
            {
                
                db.ESTADO_IMPORTACIONES.Add(eSTADO_IMPORTACIONES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eSTADO_IMPORTACIONES);
        }

        // GET: ESTADO_IMPORTACIONES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES = db.ESTADO_IMPORTACIONES.Find(id);
            if (eSTADO_IMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            return View(eSTADO_IMPORTACIONES);
        }

        // POST: ESTADO_IMPORTACIONES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_EIMPORTACION,ESTADO_IMPORTACION")] ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eSTADO_IMPORTACIONES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eSTADO_IMPORTACIONES);
        }

        // GET: ESTADO_IMPORTACIONES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES = db.ESTADO_IMPORTACIONES.Find(id);
            if (eSTADO_IMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            return View(eSTADO_IMPORTACIONES);
        }

        // POST: ESTADO_IMPORTACIONES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ESTADO_IMPORTACIONES eSTADO_IMPORTACIONES = db.ESTADO_IMPORTACIONES.Find(id);
            db.ESTADO_IMPORTACIONES.Remove(eSTADO_IMPORTACIONES);
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
