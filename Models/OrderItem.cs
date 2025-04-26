using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K_RestaurantManagement.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; } = null!;
        public int OrderId { get; set; }
        public required string Name { get; set; }
        public bool IsCompleted { get; set; } = false;
    }
}
