using BloodFinder.Models;
using BloodFinder.Service;
using System.Web.Mvc;

namespace BloodFinder.Controllers
{
    public class LoginController : Controller
    {
        public object LoginService { get; private set; }

        [HttpGet] //Signup
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost] //Signup
        public ActionResult Signup(Login l)
        {

            var lservice = new LogingService();
            var response = lservice.SaveSignupChanges(l);
            return RedirectToAction("Login", "Login");

        }



        [HttpGet] //Login
        public ActionResult Login()
        {

            return View();
        }


        [HttpPost] //Login
        public ActionResult Login(Login lo)
        {
            var loginsuccess = new LogingService();
            var response = loginsuccess.SaveLoginChanges(lo);
            var LOGINiD = response.Item2;
            Session["LoginId"] = response.Item2;
            if (response.Item1 == "true")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }

        }
        [HttpGet]  //userprofile
        public ActionResult Userprofile()
        {
            var loginId = Session["LoginId"].ToString();
            var profileService = new BloodService();
            var profileList = profileService.GetUserprofile(loginId);
            return View(profileList);
        }

        //[HttpGet] //Edit user profile
        //public ActionResult Edituser()
        //{

        //    var loginId = Session["LoginId"].ToString();
        //    var userservice = new BloodService();
        //    var UserprofileList = userservice.GetUserprofile(loginId);
        //    return View(UserprofileList);
        //}
        //[HttpPost] //Edit user profile
        //public ActionResult Edituser(Login lb)
        //{

        //    var loginId = Session["LoginId"].ToString();
        //    var userservice = new BloodService();
        //    var response = userservice.UpdateUserprofileData(lb, loginId);
        //    return RedirectToAction("Userprofile", "Login");

        //}

       
    }
}