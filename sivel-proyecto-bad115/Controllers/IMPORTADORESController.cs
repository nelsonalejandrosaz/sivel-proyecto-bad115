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
    public class IMPORTADORESController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: IMPORTADORES
        public ActionResult Index()
        {
            return View(db.IMPORTADORES.ToList());
        }

        // GET: IMPORTADORES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTADORES iMPORTADORES = db.IMPORTADORES.Find(id);
            if (iMPORTADORES == null)
            {
                return HttpNotFound();
            }
            return View(iMPORTADORES);
        }

        // GET: IMPORTADORES/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IMPORTADORES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_IMPORTADOR,NIT,NOMBRES,APELLIDOS,APELLIDO_CASADA,GENERO,FECHA_NACIMIENTO,DIRECCION,PERSONA_RESPONSABLE,TELEFONO_RESPONSABLE,EMAIL")] IMPORTADORES iMPORTADORES)
        {
            if (ModelState.IsValid)
            {
                db.IMPORTADORES.Add(iMPORTADORES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iMPORTADORES);
        }

        // GET: IMPORTADORES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTADORES iMPORTADORES = db.IMPORTADORES.Find(id);
            if (iMPORTADORES == null)
            {
                return HttpNotFound();
            }
            return View(iMPORTADORES);
        }

        // POST: IMPORTADORES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_IMPORTADOR,NIT,NOMBRES,APELLIDOS,APELLIDO_CASADA,GENERO,FECHA_NACIMIENTO,DIRECCION,PERSONA_RESPONSABLE,TELEFONO_RESPONSABLE,EMAIL")] IMPORTADORES iMPORTADORES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iMPORTADORES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iMPORTADORES);
        }

        // GET: IMPORTADORES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMPORTADORES iMPORTADORES = db.IMPORTADORES.Find(id);
            if (iMPORTADORES == null)
            {
                return HttpNotFound();
            }
            return View(iMPORTADORES);
        }

        // POST: IMPORTADORES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IMPORTADORES iMPORTADORES = db.IMPORTADORES.Find(id);
            db.IMPORTADORES.Remove(iMPORTADORES);
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
