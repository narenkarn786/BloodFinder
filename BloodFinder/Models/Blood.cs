using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BloodFinder.Models
{
    public class Blood
    {

        public string UserId { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your phonenumber")]
        public string Phone_Number { get; set; }

        [Required(ErrorMessage = "Please select your bloodgroup")]
        public string BloodGroup { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public byte[] file { get; set; }





    }
   
}