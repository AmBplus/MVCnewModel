using System;

namespace Golden.ViewModel
{
    public class CreateCostModel
    {
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string Category { get; set; }

        public string Comment { get; set; }
    }
}
