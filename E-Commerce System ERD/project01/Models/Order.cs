using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Order
    {
        public int orderId { get; set; } // Sys generate
        public int userId { get; set; } // User input
        public DateTime orderDate { get; set; } // Sys generate
        public decimal totalAmount { get; set; } // Calculated based on order items
        public string status { get; set; } // User input (e.g., "Pending", "Shipped", "Delivered")

        public string shippingAddress { get; set; } // User input

        public string paymentMethod { get; set; } // User input
    }
}
