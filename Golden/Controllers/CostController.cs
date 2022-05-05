using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCnewModel.Models;
using MVCnewModel.ViewModel;

namespace Golden.Controllers
{
    public class CostController : Controller
    {
        private readonly ICostRepository _costRepository;

        public CostController(ICostRepository costRepository)
        {
            _costRepository = costRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            StaticCostRepository costRepository = new();
            return View(costRepository);
        }

        public IActionResult Detail()
        {
            CostViewModelWithBag costViewModel = new();
            List<SelectListItem> catList = new()
            {
                new("Grocery", "Gerocery", false),
                new("Bill", "Bill"),
                new("Rent", "Rent"),
                new("Home Appliance", "Home Appliance")
            };
            ViewBag.category = new SelectList(catList, "Value", "Text", "Rent");
            return View(costViewModel);
        }

        [Route("/[controller]/Strong")]
        public IActionResult StronglyTypeView()
        {
            List<SelectListItem> catList = new()
            {
                new SelectListItem("Grocery", "Gerocery", false),
                new SelectListItem("Bill", "Bill"),
                new SelectListItem("Rent", "Rent"),
                new SelectListItem("Home Appliance", "Home Appliance")
            };
            ModelStrongly model = new()
            {
                Amount = 100,
                Comment = "No Comment",
                Date = DateTime.Now,
                Category = "category",
                Gategories = catList
            };
            return View(model);
        }
    }
}
