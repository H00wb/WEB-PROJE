using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AkdenizAirlines.Data;
using AkdenizAirlines.Models;

namespace AkdenizAirlines.Controllers
{
    public class BaggagesController : Controller
    {
        private AkdenizAirlinesContext db = new AkdenizAirlinesContext();

        // GET: Baggages
        public ActionResult Index()
        {
            return View(db.Baggages.ToList());
        }

        // GET: Baggages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baggage baggage = db.Baggages.Find(id);
            if (baggage == null)
            {
                return HttpNotFound();
            }
            return View(baggage);
        }

        // GET: Baggages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Baggages/Create
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BaggageId,weight,volume,baggage_type")] Baggage baggage)
        {
            if (ModelState.IsValid)
            {
                db.Baggages.Add(baggage);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(baggage);
        }

        // GET: Baggages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baggage baggage = db.Baggages.Find(id);
            if (baggage == null)
            {
                return HttpNotFound();
            }
            return View(baggage);
        }

        // POST: Baggages/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BaggageId,weight,volume,baggage_type")] Baggage baggage)
        {
            if (ModelState.IsValid)
            {
                db.Entry(baggage).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(baggage);
        }

        // GET: Baggages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Baggage baggage = db.Baggages.Find(id);
            if (baggage == null)
            {
                return HttpNotFound();
            }
            return View(baggage);
        }

        // POST: Baggages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Baggage baggage = db.Baggages.Find(id);
            db.Baggages.Remove(baggage);
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
