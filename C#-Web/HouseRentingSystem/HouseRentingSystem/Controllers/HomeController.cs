using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Models;
using HouseRentingSystem.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHouseService house;

        public HomeController(IHouseService _house)
        {
            house = _house;
        }

        public async Task<IActionResult> Index()
        {
            var lastThreeHouses = await house.LastThreeHouses();
            return View(lastThreeHouses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}