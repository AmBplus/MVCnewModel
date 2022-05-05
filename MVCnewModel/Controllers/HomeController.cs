using Microsoft.AspNetCore.Mvc;

namespace MVCnewModel.Controllers
{
    [Route("")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("[controller]")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
