using System;

namespace MVCnewModel.Models
{
    public class Cost
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string Category { get; set; }

        public string Comment { get; set; }
    }
}
