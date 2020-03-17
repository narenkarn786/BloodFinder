using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BloodFinder.Models
{
    public class Login
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Username { get; set; } 

        [Required(ErrorMessage ="This field is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Phone_Number { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Password)]
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string Confirm_Password { get; set; }

        




    }
}