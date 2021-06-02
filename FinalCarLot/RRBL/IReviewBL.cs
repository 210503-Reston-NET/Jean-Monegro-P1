using RRModels;
using System;
using System.Collections.Generic;

namespace RRBL
{
    public interface IReviewBL
    {
        Review AddReview(Location location, Review review);

        Tuple<List<Review>, decimal> GetReviews(Location location);
    }
}