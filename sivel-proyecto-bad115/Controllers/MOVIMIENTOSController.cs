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
    public class MOVIMIENTOSController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: MOVIMIENTOS
        public ActionResult Index()
        {
            var mOVIMIENTOS = db.MOVIMIENTOS.Include(m => m.IMPORTACIONES).Include(m => m.TIPO_MOVIMIENTOS).Include(m => m.TIPO_REMOLQUES).Include(m => m.TALLERES);
            return View(mOVIMIENTOS.ToList());
        }

        // GET: MOVIMIENTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Create
        public ActionResult Create()
        {
            ViewBag.ID_IMPORTACION = new SelectList(db.IMPORTACIONES, "ID_IMPORTACION", "DESPERFECTO");
            ViewBag.ID_TMOVIMIENTO = new SelectList(db.TIPO_MOVIMIENTOS, "ID_TMOVIMIENTO", "TIPO_MOVIMIENTO");
            ViewBag.ID_TREMOLQUE = new SelectList(db.TIPO_REMOLQUES, "ID_TREMOLQUE", "TIPO_REMOLQUE");
            ViewBag.ID_TALLER = new SelectList(db.TALLERES, "ID_TALLER", "NOMBRE");
            return View();
        }

        // POST: MOVIMIENTOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MOVIMIENTO,ID_TALLER,ID_IMPORTACION,ID_TMOVIMIENTO,ID_TREMOLQUE,FECHA")] MOVIMIENTOS mOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.MOVIMIENTOS.Add(mOVIMIENTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_IMPORTACION = new SelectList(db.IMPORTACIONES, "ID_IMPORTACION", "DESPERFECTO", mOVIMIENTOS.ID_IMPORTACION);
            ViewBag.ID_TMOVIMIENTO = new SelectList(db.TIPO_MOVIMIENTOS, "ID_TMOVIMIENTO", "TIPO_MOVIMIENTO", mOVIMIENTOS.ID_TMOVIMIENTO);
            ViewBag.ID_TREMOLQUE = new SelectList(db.TIPO_REMOLQUES, "ID_TREMOLQUE", "TIPO_REMOLQUE", mOVIMIENTOS.ID_TREMOLQUE);
            ViewBag.ID_TALLER = new SelectList(db.TALLERES, "ID_TALLER", "NOMBRE", mOVIMIENTOS.ID_TALLER);
            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_IMPORTACION = new SelectList(db.IMPORTACIONES, "ID_IMPORTACION", "DESPERFECTO", mOVIMIENTOS.ID_IMPORTACION);
            ViewBag.ID_TMOVIMIENTO = new SelectList(db.TIPO_MOVIMIENTOS, "ID_TMOVIMIENTO", "TIPO_MOVIMIENTO", mOVIMIENTOS.ID_TMOVIMIENTO);
            ViewBag.ID_TREMOLQUE = new SelectList(db.TIPO_REMOLQUES, "ID_TREMOLQUE", "TIPO_REMOLQUE", mOVIMIENTOS.ID_TREMOLQUE);
            ViewBag.ID_TALLER = new SelectList(db.TALLERES, "ID_TALLER", "NOMBRE", mOVIMIENTOS.ID_TALLER);
            return View(mOVIMIENTOS);
        }

        // POST: MOVIMIENTOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MOVIMIENTO,ID_TALLER,ID_IMPORTACION,ID_TMOVIMIENTO,ID_TREMOLQUE,FECHA")] MOVIMIENTOS mOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mOVIMIENTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_IMPORTACION = new SelectList(db.IMPORTACIONES, "ID_IMPORTACION", "DESPERFECTO", mOVIMIENTOS.ID_IMPORTACION);
            ViewBag.ID_TMOVIMIENTO = new SelectList(db.TIPO_MOVIMIENTOS, "ID_TMOVIMIENTO", "TIPO_MOVIMIENTO", mOVIMIENTOS.ID_TMOVIMIENTO);
            ViewBag.ID_TREMOLQUE = new SelectList(db.TIPO_REMOLQUES, "ID_TREMOLQUE", "TIPO_REMOLQUE", mOVIMIENTOS.ID_TREMOLQUE);
            ViewBag.ID_TALLER = new SelectList(db.TALLERES, "ID_TALLER", "NOMBRE", mOVIMIENTOS.ID_TALLER);
            return View(mOVIMIENTOS);
        }

        // GET: MOVIMIENTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            if (mOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(mOVIMIENTOS);
        }

        // POST: MOVIMIENTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MOVIMIENTOS mOVIMIENTOS = db.MOVIMIENTOS.Find(id);
            db.MOVIMIENTOS.Remove(mOVIMIENTOS);
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
