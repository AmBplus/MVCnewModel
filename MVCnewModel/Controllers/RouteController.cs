using Microsoft.AspNetCore.Mvc;
using MVCnewModel.Models;
using MVCnewModel.ViewModel;

namespace MVCnewModel.Controllers
{
    [Route("[controller]/[action]")]
    public class RouteController : Controller
    {
        private readonly ICostRepository _costRepository;

        public RouteController(ICostRepository cost)
        {
            _costRepository = cost;
        }

        [Route("~/[controller]")]
        public IActionResult Index()
        {
            string name = Request.Query["name"];


            return View(model: name);
        }

        // [Route("full")]
        public string Fullname()
        {
            string name = Request.Query["name"];

            return null;
        }

        [Route("{id?}")]
        public IActionResult Information(int id)
        {
            ViewBag.cost = _costRepository.GetCostByID(1);
            ViewBag.PageTitle = "Information View";
            // ViewData["cost"] = _costRepository.GetCostByID(1);
            // ViewData["PageTitle"] = "Information View";
            return View();
        }

        [Route("~/[controller]/Model/{id?}")]
        public IActionResult ReturnModel(int id)
        {
            return new JsonResult(_costRepository.GetCostByID(id));
        }

        public ViewResult Discription()
        {
            return View("../../Pages/Discription");
            //  return View("~/Pages/Discription.cshtml");
        }

        public IActionResult ViewModel()
        {
            CostViewModelWithBag costViewModel = new CostViewModelWithBag
            {
                cost = _costRepository.GetCostByID(2),
                Title = "ViewModel"
            };
            return View(costViewModel);
        }

        public IActionResult list()
        {
            return View(_costRepository);
        }
    }
}