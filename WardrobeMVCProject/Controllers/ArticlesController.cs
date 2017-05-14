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

        // GET: Articles - SUITS
        public ActionResult Suits()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);

            List<Article> articleList = new List<Article>();

            foreach(Article a in articles)
            {
                if(a.ArticleType.ArticleType1.Contains("Suit"))
                {
                    articleList.Add(a);
                }
            }

            return View(articleList);
        }

        // GET: Articles - CAPES
        public ActionResult Capes()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);

            List<Article> articleList = new List<Article>();

            foreach(Article a in articles)
            {
                if (a.ArticleType.ArticleType1.Contains("Cape"))
                {
                    articleList.Add(a);
                }
            }
            return View(articleList);
        }

        // GET: Articles - SHOES
        public ActionResult Shoes()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);

            List<Article> articleList = new List<Article>();

            foreach(Article a in articles)
            {
                if(a.ArticleType.ArticleType1.Contains("Shoes"))
                {
                    articleList.Add(a);
                }
            }

            return View(articleList);
        }

        // GET: Articles - ACCESSORIES
        public ActionResult ACCESSORIES()
        {
            var articles = db.Articles.Include(a => a.ArticleType).Include(a => a.Color).Include(a => a.Occasion).Include(a => a.Season);

            List<Article> articleList = new List<Article>();

            foreach(Article a in articles)
            {
                if(a.ArticleType.ArticleType1.Contains("Accessories"))
                {
                    articleList.Add(a);
                }
            }

            return View(articleList);
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

        // GET: Articles/CreateSuits
        public ActionResult CreateSuits()
        {
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1");
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            return View();
        }

        // POST: Articles/CreateSuits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSuits([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Suits");
            }

            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/CreateCapes
        public ActionResult CreateCapes()
        {
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1");
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            return View();
        }

        // POST: Articles/CreateSuits
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCapes([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Capes");
            }

            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/CreateShoes
        public ActionResult CreateShoes()
        {
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1");
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            return View();
        }

        // POST: Articles/CreateShoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateShoes([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Shoes");
            }

            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/CreateAccessories
        public ActionResult CreateAccessories()
        {
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1");
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1");
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1");
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1");
            return View();
        }

        // POST: Articles/CreateAccessories
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccessories([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Accessories");
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

        // GET: Articles/Suits/Edit/5
        public ActionResult EditSuits(int? id)
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

        // POST: Articles/Suits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSuits([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Suits");
            }
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/Shoes/Edit/5
        public ActionResult EditShoes(int? id)
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

        // POST: Articles/Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditShoes([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Shoes");
            }
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/Capes/Edit/5
        public ActionResult EditCapes(int? id)
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

        // POST: Articles/Capes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCapes([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Capes");
            }
            ViewBag.ArticleTypeID = new SelectList(db.ArticleTypes, "ArticleTypeID", "ArticleType1", article.ArticleTypeID);
            ViewBag.ColorID = new SelectList(db.Colors, "ColorID", "Color1", article.ColorID);
            ViewBag.OccasionID = new SelectList(db.Occasions, "OccasionID", "Occasion1", article.OccasionID);
            ViewBag.SeasonID = new SelectList(db.Seasons, "SeasonID", "Season1", article.SeasonID);
            return View(article);
        }

        // GET: Articles/Accessories/Edit/5
        public ActionResult EditAccessories(int? id)
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

        // POST: Articles/Accessories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditAccessories([Bind(Include = "ArticleID,Name,Photo,ArticleTypeID,ColorID,SeasonID,OccasionID")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Accessories");
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

        // GET: Articles/Suits/Delete/5
        public ActionResult DeleteSuits(int? id)
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

        // POST: Articles/Suits/Delete/5
        [HttpPost, ActionName("DeleteSuits")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteSuitsConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Suits");
        }

        // GET: Articles/Shoes/Delete/5
        public ActionResult DeleteShoes(int? id)
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

        // POST: Articles/Shoes/Delete/5
        [HttpPost, ActionName("DeleteShoes")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteShoesConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Shoes");
        }

        // GET: Articles/Capes/Delete/5
        public ActionResult DeleteCapes(int? id)
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

        // POST: Articles/Capes/Delete/5
        [HttpPost, ActionName("DeleteCapes")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCapesConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Capes");
        }

        // GET: Articles/Accessories/Delete/5
        public ActionResult DeleteAccessories(int? id)
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

        // POST: Articles/Accessories/Delete/5
        [HttpPost, ActionName("DeleteAccessories")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAccessoriesConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Accessories");
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
