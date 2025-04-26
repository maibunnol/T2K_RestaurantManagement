using Microsoft.EntityFrameworkCore;

namespace T2K_RestaurantManagement.Models
{
        public class T2KDBContext : DbContext
        {
            public T2KDBContext(DbContextOptions<T2KDBContext> options) : base(options) { }
            public DbSet<Category> Categories { get; set; }
            public DbSet<MenuItem> MenuItems { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<OrderItem> OrderItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

