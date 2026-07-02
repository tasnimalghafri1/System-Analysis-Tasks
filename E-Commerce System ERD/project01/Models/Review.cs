using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class Review
    {
        public int reviewId { get; set; } // Sys generate
        public int userId { get; set; } // User input
        public int productId { get; set; } // User input
        public int rating { get; set; } // User input (e.g., 1-5)
        public string comment { get; set; } // User input
        public DateTime reviewDate { get; set; } // Sys generate
    }
}
