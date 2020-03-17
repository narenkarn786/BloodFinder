using BloodFinder.Models;
using BloodFinder.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloodFinder.Controllers
{

    public class BloodListController : Controller
    {
        private BLOODDONOR db = new BLOODDONOR();
        // GET: BloodDonorList
        public ActionResult DonorList()
        {
            var bdService = new BloodService();
            var donorList = bdService.GetDonarInfoList();
            return View(donorList);
        }

        //Get: BloodRequestorList
        public ActionResult RequestorList()
        {
            var brService = new BloodService();
            var requestorList = brService.GetRequestorInfoList();
            return View(requestorList);
        }

        //Get:Last BloodDonor List
        public ActionResult LastDonorList()
        {
            var loginId = Session["LoginId"].ToString();
            var lbdService = new BloodService();
            var selfdonorList = lbdService.GetselfInfoList(loginId);
            if (selfdonorList.Count > 0)
            {
                return View(selfdonorList);
            }
            else
            {
                return RedirectToAction("DonateBlood", "Blood");
            }
        }

        [HttpGet]  //view for edit for BloodDonor
        public ActionResult Edit()
        {

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

            var loginId = Session["LoginId"].ToString();
            var lbdService = new BloodService();
            var lastdonorList = lbdService.GetselfInfoList(loginId);
            return View(lastdonorList.FirstOrDefault());
        }

        [HttpPost] //Edit for BloodDonor
        public ActionResult Edit(Blood b)
        {

            var loginId = Session["LoginId"].ToString();
            var dservice = new BloodService();
            var response = dservice.UpdateBloodDonorData(b, loginId);
            return RedirectToAction("LastDonorList", "BloodList");

        }

        //To Delete Data of BloodDonor
        [HttpGet]
        public ActionResult Delete()
        {
            var loginId = Session["LoginId"].ToString();
            var dservice = new BloodService();
            var response = dservice.DeleteBloodDonorData(loginId);
            this.TempData["messages"] = "Successfully Deleted!";
            return RedirectToAction("DonateBlood", "Blood");
        }


        //self BloodRequestor List
        [HttpGet]
        public ActionResult SelfBloodRequestedList()
        {
            var loginId = Session["LoginId"].ToString();
            var lbrService = new BloodService();
            var selfrequestorList = lbrService.GetselfRequestedList(loginId);
           
                if (selfrequestorList.Count > 0)
                {
                    ViewBag.Status = "* Email Successfully Sent To All User *";
                    return View(selfrequestorList);
                }
                else
                {
                    return RedirectToAction("RequestforBlood", "Blood");
                }
  
        }


        //Edit view for Selfrequestor list
        public ActionResult EditRequested()
        {

            var ITEMlIST = new List<string>();
            ITEMlIST.Add("A positive");
            ITEMlIST.Add("O positive");
            ITEMlIST.Add("B positive");
            ITEMlIST.Add("AB positive");
            ITEMlIST.Add("A negative");
            ITEMlIST.Add("o negative");
            ITEMlIST.Add("B negative");
            ITEMlIST.Add("AB negative");
            ViewBag.BloodRequestedList = ITEMlIST;

            var loginId = Session["LoginId"].ToString();
            var lbdService = new BloodService();
            var selfrequestedList = lbdService.GetselfRequestedList(loginId);
            return View(selfrequestedList.FirstOrDefault());
        }

        [HttpPost] //Edit for BloodRequested
        public ActionResult EditRequested(Blood b)
        {

            var loginId = Session["LoginId"].ToString();
            var dservice = new BloodService();
            var response = dservice.UpdateBloodRequestedData(b, loginId);
            return RedirectToAction("SelfBloodRequestedList", "BloodList");

        }

        //To Delete Data of BloodRequested
        [HttpGet]
        public ActionResult DeleteRequested()
        {
            var loginId = Session["LoginId"].ToString();
            var dservice = new BloodService();
            var response = dservice.DeleteBloodRequestedData(loginId);
            this.TempData["messages"] = "Successfully Deleted!";
            return RedirectToAction("RequestforBlood", "Blood");
        }

        [HttpGet] //search
        public ActionResult Search()
        {
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

      
    }
}