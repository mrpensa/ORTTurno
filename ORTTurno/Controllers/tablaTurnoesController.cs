using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ORTTurno;

namespace ORTTurno.Controllers
{
    public class tablaTurnoesController : Controller
    {
        private TurnoMedicoEntities db = new TurnoMedicoEntities();

        // GET: tablaTurnoes
        public ActionResult Index()
        {
            return View(db.tablaTurnos.ToList());
        }

        // GET: tablaTurnoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablaTurno tablaTurno = db.tablaTurnos.Find(id);
            if (tablaTurno == null)
            {
                return HttpNotFound();
            }
            return View(tablaTurno);
        }

        // GET: tablaTurnoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tablaTurnoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Especialidad,Sede,Fecha,Nombre,Dni,Email")] tablaTurno tablaTurno)
        {
            if (ModelState.IsValid)
            {
                db.tablaTurnos.Add(tablaTurno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tablaTurno);
        }

        // GET: tablaTurnoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablaTurno tablaTurno = db.tablaTurnos.Find(id);
            if (tablaTurno == null)
            {
                return HttpNotFound();
            }
            return View(tablaTurno);
        }

        // POST: tablaTurnoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Especialidad,Sede,Fecha,Nombre,Dni,Email")] tablaTurno tablaTurno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tablaTurno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tablaTurno);
        }

        // GET: tablaTurnoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tablaTurno tablaTurno = db.tablaTurnos.Find(id);
            if (tablaTurno == null)
            {
                return HttpNotFound();
            }
            return View(tablaTurno);
        }

        // POST: tablaTurnoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tablaTurno tablaTurno = db.tablaTurnos.Find(id);
            db.tablaTurnos.Remove(tablaTurno);
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
