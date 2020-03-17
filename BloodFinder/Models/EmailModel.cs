using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;

namespace BloodFinder.Models
{
    public class EmailModel
    {
       [DataType(DataType.EmailAddress),Display(Name ="To")]  
        [Required]  
        public string ToEmail { get; set; }  
      
        [DataType(DataType.EmailAddress),Display(Name = "From")]
        [Required]
        public string FromEmail { get; set; }
       
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        
        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]  
        public string EMailBody { get; set; }  

        [Display(Name ="Subject")]  
        public string EmailSubject { get; set; }  
        [DataType(DataType.EmailAddress)] 
        

        [Display(Name ="CC")]  
        public string EmailCC { get; set; }  
        [DataType(DataType.EmailAddress)] 
        
        [Display(Name ="BCC")]  
        public string EmailBCC { get; set; }  
    }
}