using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;
using RRWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RRWebUI.Controllers
{
    public class ReviewController : Controller
    {
        private ILocationBL _locationBL;
        private IReviewBL _reviewBL;

        public ReviewController(ILocationBL locationBL, IReviewBL reviewBL)
        {
            _locationBL = locationBL;
            _reviewBL = reviewBL;
        }

        // GET: ReviewController
        public ActionResult Index(int id)
        {
            //Viewbag and ViewData
            // Viewbag, dynamically infers a type....
            // Viewdata stores everything as an object
            // These two sharwe the same memory, they're both dictionary types that store things
            // in a key value manner
            // These two last 1 req/res lc
            ViewBag.Location = _locationBL.GetLocationById(id);
            Tuple<List<Review>, decimal> result = _reviewBL.GetReviews(_locationBL.GetLocationById(id));
            if (result.Item1.Count > 0)
            {
                ViewData.Add("AveragePrice", result.Item2);
            }
            else
            {
                ViewData.Add("AveragePrice", "No vehicles yet");
            }
            return View(result.Item1.Select(review => new ReviewVM(review)).ToList());
        }

        // GET: ReviewController/Create
        public ActionResult Create(int id)
        {
            return View(new ReviewVM(id));
        }

        // POST: ReviewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReviewVM review)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _reviewBL.AddReview(_locationBL.GetLocationById(review.LocationId), new Review { Model = review.Model, Make = review.Make, Year = review.Year, Desc = review.Desc, Mpg = review.Mpg, Price = review.Price});
                    return RedirectToAction(nameof(Index), new { id = review.LocationId });
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}