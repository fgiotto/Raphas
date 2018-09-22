using RaphasMovieReview.Models;
using RaphasMovieReview.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaphasMovieReview.Controllers
{
    public class ReviewController : Controller
    {
        ReviewRepo repo = new ReviewRepo();

        public ActionResult Index()
        {
            var data = repo.GetAllReviews();
            return View(data);
        }
        public ActionResult TextOnly()
        {
            var data = repo.GetAllReviews();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = repo.GetMovieById(id);
            return View(data);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = repo.GetMovieById(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Review updatedReview)
        {
            var oldReview = repo.GetMovieById(updatedReview.ID);
            oldReview.Rating = updatedReview.Rating;
            oldReview.ReviewText = updatedReview.ReviewText;
            oldReview.MovieName = updatedReview.MovieName;
            oldReview.CoverURL = updatedReview.CoverURL;

            repo.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create(string name)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review updatedReview)
        {
            repo.AddReview(updatedReview);
            return View(updatedReview);
        }
    }
}