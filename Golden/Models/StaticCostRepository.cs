using System;
using System.Collections.Generic;
using System.Linq;

namespace MVCnewModel.Models
{
    public class StaticCostRepository : ICostRepository
    {
        public readonly List<Cost> costs = new()
        {
            new()
            {
                Id = 1, Amount = 100, Date = DateTime.Now, Category = "Bill", Comment = "Payment for Mobile bill"
            },
            new()
            {
                Id = 2, Category = "Grocery", Date = DateTime.Now, Amount = 40,
                Comment = "Payment for buying milk and vegetables"
            },
            new()
            {
                Id = 2, Category = "Grocery", Date = DateTime.Now, Amount = 40,
                Comment = "Payment for buying meat and chicken"
            }
        };

        public Cost GetCostByID(int id)
        {
            return costs.FirstOrDefault(c => c.Id == id);
        }
    }
}
