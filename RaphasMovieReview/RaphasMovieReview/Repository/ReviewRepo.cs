using RaphasMovieReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaphasMovieReview.Repository
{
    public class ReviewRepo
    {
        RaphaDBContext db = new RaphaDBContext();

        public IEnumerable<Review> GetAllReviews()
        {
            return db.Reviews;
        }

        public void AddReview(Review newReview)
        {
            db.Reviews.Add(newReview);
            db.SaveChanges();
        }

        public Review GetMovieByName(string name)
        {
            return db.Reviews.FirstOrDefault(x => x.MovieName == name);
        }
        public Review GetMovieById(int id)
        {
            return db.Reviews.FirstOrDefault(x => x.ID == id);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}