using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BloodFinder.Models
{

    public class BloodList 
    {
        public string userId { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Bloodgroup { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
       
    }
}