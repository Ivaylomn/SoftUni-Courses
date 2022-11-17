using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

            return View();
        }

        [HttpPost]
        public IActionResult Become(BecomeAgentFormModel becomeAgentModel)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
