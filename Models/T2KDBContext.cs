using Microsoft.EntityFrameworkCore;

namespace T2K_RestaurantManagement.Models
{
        public class T2KDBContext : DbContext
        {
            public T2KDBContext(DbContextOptions<T2KDBContext> options) : base(options) { }

            public DbSet<Category> categories { get; set; }

            // etc...
        }
}

