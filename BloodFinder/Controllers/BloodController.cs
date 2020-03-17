using BloodFinder.Models;
using BloodFinder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodFinder.Controllers
{
    public class BloodController : Controller
    {

        [HttpGet] //DonateBlood
        public ActionResult DonateBlood()
        {

            ViewBag.Message = "Donate Blood, Save life";
            var ITEMlIST = new List<string>();
            ITEMlIST.Add("A positive");
            ITEMlIST.Add("O positive");
            ITEMlIST.Add("B positive");
            ITEMlIST.Add("AB positive");
            ITEMlIST.Add("A negative");
            ITEMlIST.Add("o negative");
            ITEMlIST.Add("B negative");
            ITEMlIST.Add("AB negative");


            ViewBag.BloodDonarList = ITEMlIST;

            return View();
        }

        [HttpPost] //DonateBlood
        public ActionResult DonateBlood(Blood b)
        {
            var loginId = Session["LoginId"].ToString();
            var dservice = new BloodService();
            var response = dservice.SaveBloodDonorData(b, loginId);
            ViewBag.Status = "Data successfully entered";
            return RedirectToActionPermanent("LastDonorList", "BloodList");
        }


        [HttpGet] //RequestBlood
        public ActionResult RequestforBlood()
        {
            ViewBag.Message = "Request Blood, Save your Life";
            var ITEMlIST = new List<string>();
            ITEMlIST.Add("A positive");
            ITEMlIST.Add("O positive");
            ITEMlIST.Add("B positive");
            ITEMlIST.Add("AB positive");
            ITEMlIST.Add("A negative");
            ITEMlIST.Add("o negative");
            ITEMlIST.Add("B negative");
            ITEMlIST.Add("AB negative");


            ViewBag.BloodLists = ITEMlIST;
            return View();
        }

        [HttpPost] //Request Blood
        public ActionResult RequestforBlood(Blood r)
        {
           
                var loginId = Session["LoginId"].ToString();
                var rservice = new BloodService();
                var response = rservice.SaveBloodRequestData(r, loginId);
            return RedirectToAction("SelfBloodRequestedList", "BloodList");


        }
    }
}