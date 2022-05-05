using Microsoft.AspNetCore.Mvc;
using MVCnewModel.Models;

namespace MVCnewModel.Controllers
{
    public class RoarController : Controller
    {
        public IActionResult Index()
        {
            StaticCostRepository staticCost = new StaticCostRepository();
            return View(staticCost);
        }
    }
}
