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
    public class ArticleTypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: ArticleTypes
        public ActionResult Index()
        {
            return View(db.ArticleTypes.ToList());
        }

        // GET: ArticleTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleTypes.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // GET: ArticleTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArticleTypeID,ArticleType1")] ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                db.ArticleTypes.Add(articleType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(articleType);
        }

        // GET: ArticleTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleTypes.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // POST: ArticleTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArticleTypeID,ArticleType1")] ArticleType articleType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(articleType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(articleType);
        }

        // GET: ArticleTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArticleType articleType = db.ArticleTypes.Find(id);
            if (articleType == null)
            {
                return HttpNotFound();
            }
            return View(articleType);
        }

        // POST: ArticleTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArticleType articleType = db.ArticleTypes.Find(id);
            db.ArticleTypes.Remove(articleType);
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
