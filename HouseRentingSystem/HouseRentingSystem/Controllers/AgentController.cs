using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseRentingSystem.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeAgentFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}

