using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCnewModel.Models
{
    public class StaticCostRepository : ICostRepository
    {
        public readonly List<Cost> costs = new List<Cost>
        {
            new Cost
            {
                ID = 1, Amount = 100, Date = DateTime.Now, Category = "Bill", Comment = "Payment for Mobile bill"
            },
            new Cost
            {
                ID = 2, Category = "Grocery", Date = DateTime.Now, Amount = 40,
                Comment = "Payment for buying milk and vegetables"
            },
            new Cost
            {
                ID = 2, Category = "Grocery", Date = DateTime.Now, Amount = 40,
                Comment = "Payment for buying meat and chicken"
            }
        };

        public Cost GetCostByID(int id)
        {
            return costs.FirstOrDefault(c => c.ID == id);
        }
    }
}
