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
    public class UBICACIONESController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: UBICACIONES
        public ActionResult Index()
        {
            var uBICACIONES = db.UBICACIONES.Include(u => u.BODEGAS);
            return View(uBICACIONES.ToList());
        }

        // GET: UBICACIONES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UBICACIONES uBICACIONES = db.UBICACIONES.Find(id);
            if (uBICACIONES == null)
            {
                return HttpNotFound();
            }
            return View(uBICACIONES);
        }

        // GET: UBICACIONES/Create
        public ActionResult Create()
        {
            ViewBag.ID_BODEGA = new SelectList(db.BODEGAS, "ID_BODEGA", "NOMBRE");
            return View();
        }

        // POST: UBICACIONES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_UBICACION,ID_BODEGA,NIVEL,NUMERO_PARQUEO")] UBICACIONES uBICACIONES)
        {
            if (ModelState.IsValid)
            {
                db.UBICACIONES.Add(uBICACIONES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_BODEGA = new SelectList(db.BODEGAS, "ID_BODEGA", "NOMBRE", uBICACIONES.ID_BODEGA);
            return View(uBICACIONES);
        }

        // GET: UBICACIONES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UBICACIONES uBICACIONES = db.UBICACIONES.Find(id);
            if (uBICACIONES == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_BODEGA = new SelectList(db.BODEGAS, "ID_BODEGA", "NOMBRE", uBICACIONES.ID_BODEGA);
            return View(uBICACIONES);
        }

        // POST: UBICACIONES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_UBICACION,ID_BODEGA,NIVEL,NUMERO_PARQUEO")] UBICACIONES uBICACIONES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uBICACIONES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_BODEGA = new SelectList(db.BODEGAS, "ID_BODEGA", "NOMBRE", uBICACIONES.ID_BODEGA);
            return View(uBICACIONES);
        }

        // GET: UBICACIONES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UBICACIONES uBICACIONES = db.UBICACIONES.Find(id);
            if (uBICACIONES == null)
            {
                return HttpNotFound();
            }
            return View(uBICACIONES);
        }

        // POST: UBICACIONES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UBICACIONES uBICACIONES = db.UBICACIONES.Find(id);
            db.UBICACIONES.Remove(uBICACIONES);
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
