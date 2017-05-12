using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardrobeMVCProject.Models;

namespace WardrobeMVCProject.Controllers
{
    public class OutfitsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Outfits
        public ActionResult Index()
        {
            var outfits = db.Outfits.Include(o => o.Article).Include(o => o.Article1).Include(o => o.Article2).Include(o => o.Article3).Include(o => o.Article4).Include(o => o.Article5).Include(o => o.Article6).Include(o => o.Article7).Include(o => o.Article8).Include(o => o.Article9).Include(o => o.Article10).Include(o => o.Article11);
            return View(outfits.ToList());
        }

        // GET: Outfits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outfit outfit = db.Outfits.Find(id);
            if (outfit == null)
            {
                return HttpNotFound();
            }
            return View(outfit);
        }

        // GET: Outfits/Create
        public ActionResult Create()
        {
            ViewBag.ArticleID1 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID2 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID11 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID12 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID3 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID4 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID5 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID6 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID7 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID8 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID9 = new SelectList(db.Articles, "ArticleID", "Name");
            ViewBag.ArticleID10 = new SelectList(db.Articles, "ArticleID", "Name");
            return View();
        }

        // POST: Outfits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OutfitID,ArticleID1,ArticleID2,ArticleID3,ArticleID4,ArticleID5,ArticleID6,ArticleID7,ArticleID8,ArticleID9,ArticleID10,ArticleID11,ArticleID12")] Outfit outfit)
        {
            if (ModelState.IsValid)
            {
                db.Outfits.Add(outfit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArticleID1 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID1);
            ViewBag.ArticleID2 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID2);
            ViewBag.ArticleID11 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID11);
            ViewBag.ArticleID12 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID12);
            ViewBag.ArticleID3 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID3);
            ViewBag.ArticleID4 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID4);
            ViewBag.ArticleID5 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID5);
            ViewBag.ArticleID6 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID6);
            ViewBag.ArticleID7 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID7);
            ViewBag.ArticleID8 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID8);
            ViewBag.ArticleID9 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID9);
            ViewBag.ArticleID10 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID10);
            return View(outfit);
        }

        // GET: Outfits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outfit outfit = db.Outfits.Find(id);
            if (outfit == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArticleID1 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID1);
            ViewBag.ArticleID2 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID2);
            ViewBag.ArticleID11 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID11);
            ViewBag.ArticleID12 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID12);
            ViewBag.ArticleID3 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID3);
            ViewBag.ArticleID4 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID4);
            ViewBag.ArticleID5 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID5);
            ViewBag.ArticleID6 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID6);
            ViewBag.ArticleID7 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID7);
            ViewBag.ArticleID8 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID8);
            ViewBag.ArticleID9 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID9);
            ViewBag.ArticleID10 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID10);
            return View(outfit);
        }

        // POST: Outfits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OutfitID,ArticleID1,ArticleID2,ArticleID3,ArticleID4,ArticleID5,ArticleID6,ArticleID7,ArticleID8,ArticleID9,ArticleID10,ArticleID11,ArticleID12")] Outfit outfit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outfit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArticleID1 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID1);
            ViewBag.ArticleID2 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID2);
            ViewBag.ArticleID11 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID11);
            ViewBag.ArticleID12 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID12);
            ViewBag.ArticleID3 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID3);
            ViewBag.ArticleID4 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID4);
            ViewBag.ArticleID5 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID5);
            ViewBag.ArticleID6 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID6);
            ViewBag.ArticleID7 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID7);
            ViewBag.ArticleID8 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID8);
            ViewBag.ArticleID9 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID9);
            ViewBag.ArticleID10 = new SelectList(db.Articles, "ArticleID", "Name", outfit.ArticleID10);
            return View(outfit);
        }

        // GET: Outfits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outfit outfit = db.Outfits.Find(id);
            if (outfit == null)
            {
                return HttpNotFound();
            }
            return View(outfit);
        }

        // POST: Outfits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Outfit outfit = db.Outfits.Find(id);
            db.Outfits.Remove(outfit);
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
