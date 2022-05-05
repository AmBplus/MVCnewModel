using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCnewModel.ViewModel
{
    public class ModelStrongly
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string Category { get; set; }

        public string Comment { get; set; }

        public List<SelectListItem> Gategories { get; set; }
    }
}
