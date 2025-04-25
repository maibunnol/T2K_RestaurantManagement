using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T2K_RestaurantManagement.Models;

namespace T2K_RestaurantManagement
{
    public class DBInitializer
    {
        public static void Seed(T2KDBContext context)
        {
            if (context.categories.Any())
                return;

            var items = new List<Category>
            {
                new Category { Title = "Breakfast", Description = "Pasta", ImagePath = "" },
                new Category { Title = "Lunch", Description = "La", ImagePath = "" },
                new Category { Title = "Dinner", Description = "Vista", ImagePath = "" }
            };

            context.categories.AddRange(items);
            context.SaveChanges();
        }
    }
}
