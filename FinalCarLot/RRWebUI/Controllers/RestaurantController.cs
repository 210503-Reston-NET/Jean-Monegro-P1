using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RRBL;
using RRModels;
using RRWebUI.Models;
using System.Linq;

namespace RRWebUI.Controllers
{
    public class RestaurantController : Controller
    {
        private ILocationBL _locationBL;

        public RestaurantController(ILocationBL locationBL)
        {
            _locationBL = locationBL;
        }

        public ActionResult Index()
        {
            return View(_locationBL
                .GetAllLocations()
                .Select(location => new LocationVM(location))
                .ToList()
                );
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LocationVM locationVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _locationBL.AddLocation(new Location
                    {
                        City = locationVM.City,
                        State = locationVM.State,
                        Country = locationVM.Country
                    }
                    );
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View(new LocationVM(_locationBL.GetLocationById(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LocationVM locationVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _locationBL.UpdateLocation(new Location(locationVM.Id, locationVM.City, locationVM.State, locationVM.Country));
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View(new LocationVM(_locationBL.GetLocationById(id)));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _locationBL.DeleteLocation(_locationBL.GetLocationById(id));
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}