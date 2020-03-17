using BloodFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Web.Helpers;

namespace BloodFinder.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Email()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Email(EmailModel obj)
        {
           
            try
            {
                
                WebMail.SmtpServer = "smtp.gmail.com";   
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;  
                WebMail.EnableSsl = true;
                WebMail.UserName =  "narenkarn786@gmail.com";
                WebMail.Password ="786naren";

                WebMail.From = "narenkarn786@gmail.com";

                WebMail.Send(to: obj.ToEmail, subject: obj.EmailSubject, body: obj.EMailBody, cc: obj.EmailCC, bcc: obj.EmailBCC, isBodyHtml: true);
              
                ViewBag.Status = "Email Sent Successfully.";
            }
            catch (Exception)
            {
                
                ViewBag.Status = "Problem while sending email, Please check details.";

            }
            return View();
        }

        
    }
}
