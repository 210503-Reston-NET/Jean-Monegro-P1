using RRDL;
using RRModels;
using System;
using System.Collections.Generic;

namespace RRBL
{
    public class ReviewBL : IReviewBL
    {
        private IRepository _repo;

        public ReviewBL(IRepository repo)
        {
            _repo = repo;
        }

        public Review AddReview(Location location, Review review)
        {
            //call repo method to add review;
            _repo.AddReview(location, review);
            return review;
        }

        public Tuple<List<Review>, decimal> GetReviews(Location location)
        {
            //call get reviews from my repodb.
            List<Review> restaurantReviews = _repo.GetReviews(location);
            decimal averagePrice = 0;
            if (restaurantReviews.Count > 0)
            {
                restaurantReviews.ForEach(review => averagePrice += review.Price);
                averagePrice = averagePrice / restaurantReviews.Count;
            }
            return new Tuple<List<Review>, decimal>(restaurantReviews, averagePrice);
        }
        public List<Review> GetAllReviews()
        {
            return _repo.GetAllReviews();
        }
    }
}