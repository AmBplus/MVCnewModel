using Microsoft.AspNetCore.Mvc;

namespace Golden.Controllers
{
    public class SenatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
