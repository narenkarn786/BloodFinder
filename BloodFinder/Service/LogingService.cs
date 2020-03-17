using BloodFinder.Models;
using System;
using System.Linq;

namespace BloodFinder.Service
{
    public class LogingService
    {
        //Signup Service
        public string SaveSignupChanges(Login ml)
        {

            var message = "";
            using (var context = new Entities1())
            {
                var user = new LOGIN()
                {
                    USERNAME = ml.Username,
                    PASSWORD = ml.Password,
                    CONFIRMPASSWORD = ml.Confirm_Password,
                    EMAIL = ml.Email,
                    PHONENO = ml.Phone_Number

                };
                context.LOGINs.Add(user);

                context.SaveChanges();
                message = "save successfull";
                
            }
            return message;
        }

        //Login Service
        public Tuple<string,int> SaveLoginChanges(Login l)
        {

            var message = "";
            using (var context = new Entities1())
            {


                var loginData = context.LOGINs
                          .Where(lg => lg.USERNAME == l.Username && lg.PASSWORD == l.Password)
                          .FirstOrDefault<LOGIN>();
                if (loginData.USERNAME != "")
                {
                    message = "true";
                }
                else
                {
                    message = "false";
                }
                return Tuple.Create(message, Convert.ToInt32(loginData.USERID));
            }
        }
    }
}
