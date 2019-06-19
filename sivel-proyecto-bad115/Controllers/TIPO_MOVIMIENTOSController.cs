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
    public class TIPO_MOVIMIENTOSController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: TIPO_MOVIMIENTOS
        public ActionResult Index()
        {
            return View(db.TIPO_MOVIMIENTOS.ToList());
        }

        // GET: TIPO_MOVIMIENTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS = db.TIPO_MOVIMIENTOS.Find(id);
            if (tIPO_MOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_MOVIMIENTOS);
        }

        // GET: TIPO_MOVIMIENTOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_MOVIMIENTOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TMOVIMIENTO,TIPO_MOVIMIENTO")] TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_MOVIMIENTOS.Add(tIPO_MOVIMIENTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_MOVIMIENTOS);
        }

        // GET: TIPO_MOVIMIENTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS = db.TIPO_MOVIMIENTOS.Find(id);
            if (tIPO_MOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_MOVIMIENTOS);
        }

        // POST: TIPO_MOVIMIENTOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TMOVIMIENTO,TIPO_MOVIMIENTO")] TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_MOVIMIENTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_MOVIMIENTOS);
        }

        // GET: TIPO_MOVIMIENTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS = db.TIPO_MOVIMIENTOS.Find(id);
            if (tIPO_MOVIMIENTOS == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_MOVIMIENTOS);
        }

        // POST: TIPO_MOVIMIENTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_MOVIMIENTOS tIPO_MOVIMIENTOS = db.TIPO_MOVIMIENTOS.Find(id);
            db.TIPO_MOVIMIENTOS.Remove(tIPO_MOVIMIENTOS);
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
