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
    public class VEHICULOSController : Controller
    {
        private bad115Entidades db = new bad115Entidades();

        // GET: VEHICULOS
        public ActionResult Index()
        {
            return View(db.VEHICULOS.ToList());

        }

        // GET: VEHICULOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);

            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VEHICULOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_VEHICULO,MARCA,MODELO,ANO")] VEHICULOS vEHICULOS)
        {
            if (ModelState.IsValid)
            {
                db.InsertarVehiculo(vEHICULOS.MARCA,vEHICULOS.MODELO,vEHICULOS.ANO);
                //db.VEHICULOS.Add(vEHICULOS);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            
            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // POST: VEHICULOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_VEHICULO,MARCA,MODELO,ANO")] VEHICULOS vEHICULOS)
        {
            if (ModelState.IsValid)
            {
                db.ActualizarVehiculos(vEHICULOS.ID_VEHICULO,vEHICULOS.MARCA,vEHICULOS.MODELO,vEHICULOS.ANO);
                //db.Entry(vEHICULOS).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vEHICULOS);
        }

        // GET: VEHICULOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            if (vEHICULOS == null)
            {
                return HttpNotFound();
            }
            return View(vEHICULOS);
        }

        // POST: VEHICULOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VEHICULOS vEHICULOS = db.VEHICULOS.Find(id);
            db.EliminarVehiculos(id);
            //db.VEHICULOS.Remove(vEHICULOS);
            //db.SaveChanges();
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
