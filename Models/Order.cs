using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2K_RestaurantManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
            = "Pending"; // Pending or Ready
        public ICollection<OrderItem> OrderItems { get; }
            = new List<OrderItem>();
        
    }
}
