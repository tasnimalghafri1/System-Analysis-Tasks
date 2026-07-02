using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01.Models
{
    public class User
    {
        public int userId { get; set; } // Sys generate 
        public string userName { get; set; }// User input 

        public string passwordHash { get; set; }// Sys generate 
        public string email { get; set; }// User input 
        public string fullName { get; set; }// User input 
        public string phoneNumber { get; set; }// User input 
        public string address { get; set; }// User input 
        public DateTime registrationDate { get; set; } //Sys generate 

        public bool isActive { get; set; } = false; // Default value is false, user must verify email to activate account

    }
}
