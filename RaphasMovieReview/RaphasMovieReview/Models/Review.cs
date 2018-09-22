using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaphasMovieReview.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string MovieName { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public string CoverURL { get; set; }
    }
}