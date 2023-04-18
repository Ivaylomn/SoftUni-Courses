using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HouseRentingSystem.Extensions;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        private readonly IAgentService agent;

        public AgentController(IAgentService _agent)
        {
            this.agent = _agent;
        }

        [HttpGet]
        public IActionResult Become()
        {
            if (agent.ExistsById(User.Id()))
            {
                return BadRequest();
            }

            return View();
        }

        [HttpPost]
        public IActionResult Become(BecomeAgentFormModel model)
        {
            var userId = User.Id();

            if (agent.ExistsById(userId))
            {
                return BadRequest();
            }

            if (agent.UserWithPhoneNumberExists(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Phone number already exists. Enter another one");
            }

            if (agent.UserHasRents(userId))
            {
                ModelState.AddModelError("Error", "You should have no rents to become an agent");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            agent.Create(userId, model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
