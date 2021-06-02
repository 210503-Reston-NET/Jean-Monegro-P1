using RRModels;
using System;
using System.ComponentModel.DataAnnotations;

namespace RRWebUI.Models
{
    public class ReviewVM
    {
        public ReviewVM()
        {
        }

        public ReviewVM(int locationId)
        {
            LocationId = locationId;
        }

        public ReviewVM(Review review)
        {
            LocationId = review.LocationId;
            Make = review.Make;
            Desc = review.Desc;
            Model = review.Model;
            Year = review.Year;
            Mpg = review.Mpg;
            Price = review.Price;
            ReviewId = review.ReviewId;
        }

        public int LocationId { get; set; }

        [Required]
        [Range(0, 100)]
        public int Mpg { get; set; }

        [Required]
        public string Desc { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ReviewId { get; set; }

    }
}