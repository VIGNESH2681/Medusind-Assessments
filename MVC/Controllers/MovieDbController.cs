using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data;

using System.Net;

namespace WebApplication1.Controllers
{
    public class MovieDbController : Controller
    {
        // GET: MovieDb
        TrainingDBEntities1 db = new TrainingDBEntities1();
        public ActionResult Index()
        {
            List<Movie12> movie = db.Movie12.ToList();
            return View(movie);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public ActionResult Insert([Bind(Include = "Mid, Moviename, DateofRelease")] Movie12 movie)
        {
            if (ModelState.IsValid)
            {
                db.Movie12.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie12 movie = db.Movie12.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mid, Moviename, DateofRelease")] Movie12 movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = (System.Data.Entity.EntityState)System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie12 movie = db.Movie12.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken, ActionName("Delete")]
        public ActionResult DeleteConfirm(int? id)
        {
            Movie12 movie = db.Movie12.Find(id);
            db.Movie12.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult FindMoviesByYear(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                int n = Convert.ToInt32(dateTime);
                IEnumerable<Movie12> movie = from m in db.Movie12
                                               where m.DateofRelease.Equals(n)
                                               select m;
                return View(movie);
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
    }
}