using Microsoft.AspNetCore.Mvc;
using TravelsPortal.Core.Entities.TravelsPortal.Core.Entities;
using TravelsPortal.Core.Interfaces;

namespace TravelsPortal.Controllers
{
    public class TravelController : Controller
    {
        private readonly ITravelService _travelService;

        public TravelController(ITravelService travelService)
        {
            _travelService = travelService;
        }

        public IActionResult Index()
        {
            var travels = _travelService.GetAllTravels();
            return View(travels);
        }

        public IActionResult Details(int id)
        {
            var travel = _travelService.GetTravelById(id);
            if (travel == null) return NotFound();
            return View(travel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Travel travel)
        {
            if (ModelState.IsValid)
            {
                _travelService.AddTravel(travel);
                return RedirectToAction(nameof(Index));
            }
            return View(travel);
        }

        public IActionResult Edit(int id)
        {
            var travel = _travelService.GetTravelById(id);
            if (travel == null) return NotFound();
            return View(travel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Travel travel)
        {
            if (ModelState.IsValid)
            {
                _travelService.UpdateTravel(travel);
                return RedirectToAction(nameof(Index));
            }
            return View(travel);
        }

        public IActionResult Delete(int id)
        {
            var travel = _travelService.GetTravelById(id);
            if (travel == null) return NotFound();
            return View(travel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _travelService.DeleteTravel(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
