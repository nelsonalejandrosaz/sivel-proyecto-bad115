using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sivel_proyecto_bad115;

namespace sivel_proyecto_bad115.Models
{
    public class IMPORTACIONESController : Controller
    {
        private bad115Entities db = new bad115Entities();

        // GET: IMPORTACIONES
        public ActionResult Index()
        {
            var iMPORTACIONES = db.IMPORTACIONES.Include(i => i.ESTADO_IMPORTACIONES).Include(i => i.VEHICULOS).Include(i => i.IMPORTADORES).Include(i => i.UBICACIONES);
            return View(iMPORTACIONES.ToList());
        }

        // GET: IMPORTACIONES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTACIONES iMPORTACIONES = db.IMPORTACIONES.Find(id);
            if (iMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            return View(iMPORTACIONES);
        }

        // GET: IMPORTACIONES/Create
        public ActionResult Create()
        {
            ViewBag.ID_EIMPORTACION = new SelectList(db.ESTADO_IMPORTACIONES, "ID_EIMPORTACION", "ESTADO_IMPORTACION");
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "MARCA");
            ViewBag.ID_IMPORTADOR = new SelectList(db.IMPORTADORES, "ID_IMPORTADOR", "NOMBRES");
            ViewBag.ID_UBICACION = new SelectList(db.UBICACIONES, "ID_UBICACION", "ID_UBICACION");
            return View();
        }

        // POST: IMPORTACIONES/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_IMPORTACION,ID_UBICACION,ID_EIMPORTACION,ID_IMPORTADOR,ID_VEHICULO,FECHA,DESPERFECTO,PRECIO_VENTA")] IMPORTACIONES iMPORTACIONES)
        {
            if (ModelState.IsValid)
            {
                db.IMPORTACIONES.Add(iMPORTACIONES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_EIMPORTACION = new SelectList(db.ESTADO_IMPORTACIONES, "ID_EIMPORTACION", "ESTADO_IMPORTACION", iMPORTACIONES.ID_EIMPORTACION);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "MARCA", iMPORTACIONES.ID_VEHICULO);
            ViewBag.ID_IMPORTADOR = new SelectList(db.IMPORTADORES, "ID_IMPORTADOR", "NOMBRES", iMPORTACIONES.ID_IMPORTADOR);
            ViewBag.ID_UBICACION = new SelectList(db.UBICACIONES, "ID_UBICACION", "ID_UBICACION", iMPORTACIONES.ID_UBICACION);
            return View(iMPORTACIONES);
        }

        // GET: IMPORTACIONES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTACIONES iMPORTACIONES = db.IMPORTACIONES.Find(id);
            if (iMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_EIMPORTACION = new SelectList(db.ESTADO_IMPORTACIONES, "ID_EIMPORTACION", "ESTADO_IMPORTACION", iMPORTACIONES.ID_EIMPORTACION);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "MARCA", iMPORTACIONES.ID_VEHICULO);
            ViewBag.ID_IMPORTADOR = new SelectList(db.IMPORTADORES, "ID_IMPORTADOR", "NOMBRES", iMPORTACIONES.ID_IMPORTADOR);
            ViewBag.ID_UBICACION = new SelectList(db.UBICACIONES, "ID_UBICACION", "ID_UBICACION", iMPORTACIONES.ID_UBICACION);
            return View(iMPORTACIONES);
        }

        // POST: IMPORTACIONES/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_IMPORTACION,ID_UBICACION,ID_EIMPORTACION,ID_IMPORTADOR,ID_VEHICULO,FECHA,DESPERFECTO,PRECIO_VENTA")] IMPORTACIONES iMPORTACIONES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iMPORTACIONES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_EIMPORTACION = new SelectList(db.ESTADO_IMPORTACIONES, "ID_EIMPORTACION", "ESTADO_IMPORTACION", iMPORTACIONES.ID_EIMPORTACION);
            ViewBag.ID_VEHICULO = new SelectList(db.VEHICULOS, "ID_VEHICULO", "MARCA", iMPORTACIONES.ID_VEHICULO);
            ViewBag.ID_IMPORTADOR = new SelectList(db.IMPORTADORES, "ID_IMPORTADOR", "NOMBRES", iMPORTACIONES.ID_IMPORTADOR);
            ViewBag.ID_UBICACION = new SelectList(db.UBICACIONES, "ID_UBICACION", "ID_UBICACION", iMPORTACIONES.ID_UBICACION);
            return View(iMPORTACIONES);
        }

        // GET: IMPORTACIONES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTACIONES iMPORTACIONES = db.IMPORTACIONES.Find(id);
            if (iMPORTACIONES == null)
            {
                return HttpNotFound();
            }
            return View(iMPORTACIONES);
        }

        // POST: IMPORTACIONES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IMPORTACIONES iMPORTACIONES = db.IMPORTACIONES.Find(id);
            db.IMPORTACIONES.Remove(iMPORTACIONES);
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
