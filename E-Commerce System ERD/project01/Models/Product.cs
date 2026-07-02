using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Product
    {
        public int productId { get; set; } // Sys generate
        public string productName { get; set; } // User input
        public string description { get; set; } // User input
        public decimal price { get; set; } // User input
        public int stockQuantity { get; set; } // User input
        public int categoryId { get; set; } // User input

        public string imageUrl { get; set; }// User input

        public DateTime createdAt { get; set; } // Sys generate

        public bool isAvailable { get; set; } = true; // Default value is true, user can set to false to hide product from listing
    }
}
