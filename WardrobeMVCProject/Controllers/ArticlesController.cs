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
    public class ArticlesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Articles
        public ActionResult Index()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);
            return View(articles.ToList());
        }

        // GET: Articles - TOPS
        public ActionResult Tops()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);
            return View(articles.ToList());
        }

        // GET: Articles - BOTTOMS
        public ActionResult Bottoms()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);
            return View(articles.ToList());
        }

        // GET: Articles - SHOES
        public ActionResult Shoes()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);
            return View(articles.ToList());
        }

        // GET: Articles - ACCESSORIES
        public ActionResult ACCESSORIES()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);
            return View(articles.ToList());
        }

        // GET: Articles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // GET: Articles/Create
        public ActionResult Create()
        {
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1");
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            return View();
        }

        // POST: Articles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
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
