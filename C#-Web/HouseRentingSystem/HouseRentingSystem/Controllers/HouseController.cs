using Microsoft.AspNetCore.Mvc;
using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
        [AllowAnonymous]
        public IActionResult All()
        {
            var model = new AllHousesQueryModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Mine()
        {
            var model = new AllHousesQueryModel();

            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = new HouseDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(HouseFormModel houseFormModel)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = new HouseFormModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(int id, HouseFormModel houseFormModel)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        public IActionResult Delete(int id)
        {
            var model = new HouseDetailsViewModel();

            return View(model);
        }

        public IActionResult Delete(HouseDetailsViewModel houseDetails)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public IActionResult Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public IActionResult Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
