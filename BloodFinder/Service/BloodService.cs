using BloodFinder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace BloodFinder.Service
{
    public class BloodService
    {
        //To save Blood Donor Data
        public string SaveBloodDonorData(Blood bd, string loginId)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var donor = new BLOODDONOR()
                {
                    USERID = Convert.ToDecimal(loginId),
                    NAME = bd.Name,
                    ADDRESS = bd.Address,
                    PHONENUMBER = bd.Phone_Number,
                    BLOODGROUP = bd.BloodGroup,
                    EMAIL = bd.Email,
                };
                context.BLOODDONORs.Add(donor);

                context.SaveChanges();
                message = "save successfull";

            }
            return message;



        }

        //To save Blood Request data
        public string SaveBloodRequestData(Blood bd, string loginId)
        {
            var message = "";
            using (var context = new Entities1())
            {
                var request = new BLOODREQUESTOR()
                {
                    USERID = Convert.ToDecimal(loginId),
                    NAME = bd.Name,
                    ADDRESS = bd.Address,
                    PHONENUMBER = bd.Phone_Number,
                    EMAIL=bd.Email,
                    BLOODGROUP = bd.BloodGroup,
                    MESSAGE=bd.Message


                };
                context.BLOODREQUESTORs.Add(request);

                var email = new EmailModel();
                

                context.SaveChanges();

                var allUser = FetchAllUser();
                foreach(var usr in allUser)
                {
                    SendMailCustom(usr.Email,bd.Message,bd.Name,bd.BloodGroup,bd.Address,bd.Phone_Number);
                }
               message = "save successfull";

            }
            return message;

        }

        private List<BloodList> FetchAllUser()
        {
            using (var context = new Entities1())
            {

                var donarData = context.BLOODDONORs.ToList();
                BloodList bloodListObj = null;
                var bloodListInfoList = new List<BloodList>();

                foreach (var bd in donarData)
                {
                    bloodListObj = new BloodList
                    {
                        Bloodgroup = bd.BLOODGROUP,
                        Address = bd.ADDRESS,
                        Name = bd.NAME,
                        PhoneNumber = bd.PHONENUMBER,
                        Email = bd.EMAIL
                    };
                    bloodListInfoList.Add(bloodListObj);
                }
                return bloodListInfoList;

            }
        }

        //To List Blood Donor Data 
        public List<BloodList> GetDonarInfoList()
        {
            using (var context = new Entities1())
            {

                var donarData = context.BLOODDONORs.ToList();
                BloodList bloodListObj = null;
                var bloodListInfoList = new List<BloodList>();

                foreach (var bd in donarData)
                {
                    bloodListObj = new BloodList
                    {
                        Bloodgroup = bd.BLOODGROUP,
                        Address = bd.ADDRESS,
                        Name = bd.NAME,
                        PhoneNumber = bd.PHONENUMBER,
                        Email=bd.EMAIL

                    };
                    bloodListInfoList.Add(bloodListObj);
                }
                return bloodListInfoList;

            }
        }

        //To List Blood Requestor Data
        public List<BloodList> GetRequestorInfoList()
        {
            using (var context = new Entities1())
            {

                var requestorData = context.BLOODREQUESTORs.ToList();
                BloodList bloodListObj = null;
                var bloodListInfoList = new List<BloodList>();

                foreach (var br in requestorData)
                {
                    bloodListObj = new BloodList
                    {
                        Bloodgroup = br.BLOODGROUP,
                        Address = br.ADDRESS,
                        Name = br.NAME,
                        PhoneNumber = br.PHONENUMBER,
                        Email = br.EMAIL,
                        Message=br.MESSAGE
                        
                    };
                    bloodListInfoList.Add(bloodListObj);
                }
                return bloodListInfoList;

            }
        }

        //To List only Self Donor Data
        public List<BloodList> GetselfInfoList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfdonarData = context.BLOODDONORs.Where(x => x.USERID == lgId).ToList();
                BloodList bloodListObj = null;
                var bloodListInfoList = new List<BloodList>();

                foreach (var lbd in selfdonarData)
                {
                    bloodListObj = new BloodList
                    {

                        Bloodgroup = lbd.BLOODGROUP,
                        Address = lbd.ADDRESS,
                        Name = lbd.NAME,
                        PhoneNumber = lbd.PHONENUMBER,
                        Email=lbd.EMAIL
                        
                        
                    };
                    bloodListInfoList.Add(bloodListObj);
                }
                return bloodListInfoList;

            }
        }

        //To Edit Data of BloodDonor
        public string UpdateBloodDonorData(Blood bd, string loginId)
        {

            var message = "";

            using (var context = new Entities1())
            {
                var decId = Convert.ToDecimal(loginId);
                var dataToUpdate = context.BLOODDONORs.Where(x => x.USERID == decId).FirstOrDefault();
                dataToUpdate.NAME = bd.Name;
                dataToUpdate.ADDRESS = bd.Address;
                dataToUpdate.EMAIL = bd.Email;
                dataToUpdate.BLOODGROUP = bd.BloodGroup;
                context.SaveChanges();
                message = "Update successfull";
            }
            return message;

        }

        //To Delete Data of BloodDonor
        public string DeleteBloodDonorData(string loginId)
        {

            var message = "";

            using (var context = new Entities1())
            {
                var decId = Convert.ToDecimal(loginId);
                var dataToDelete = context.BLOODDONORs.Where(x => x.USERID == decId).FirstOrDefault();
                context.BLOODDONORs.Remove(dataToDelete);
                context.SaveChanges();
                message = "Delete successfull";
            }
            return message;

        }

        //To list Self Requested data
        public List<BloodList> GetselfRequestedList(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var selfrequestedData = context.BLOODREQUESTORs.Where(x => x.USERID == lgId).ToList();
                BloodList bloodListObj = null;
                var bloodListInfoList = new List<BloodList>();

                foreach (var lbd in selfrequestedData)
                {
                    bloodListObj = new BloodList
                    {

                        Bloodgroup = lbd.BLOODGROUP,
                        Address = lbd.ADDRESS,
                        Name = lbd.NAME,
                        PhoneNumber = lbd.PHONENUMBER,
                        Email = lbd.EMAIL, 
                        Message=lbd.MESSAGE


                    };
                    bloodListInfoList.Add(bloodListObj);
                }
                return bloodListInfoList;

            }
        }

        //To Edit Data of BloodRequestor
        public string UpdateBloodRequestedData(Blood bd, string loginId)
        {

            var message = "";

            using (var context = new Entities1())
            {
                var decId = Convert.ToDecimal(loginId);
                var dataToUpdate = context.BLOODREQUESTORs.Where(x => x.USERID == decId).FirstOrDefault();
                dataToUpdate.NAME = bd.Name;
                dataToUpdate.ADDRESS = bd.Address;
                dataToUpdate.EMAIL = bd.Email;
                dataToUpdate.BLOODGROUP = bd.BloodGroup;
                dataToUpdate.MESSAGE = bd.Message;
                var allUser = FetchAllUser();
                foreach (var usr in allUser)
                {
                    SendMailCustom(usr.Email, bd.Message, bd.Name, bd.BloodGroup, bd.Address, bd.Phone_Number);
                }
                context.SaveChanges();
                message = "Update successfull";
            }
            return message;

        }

        //To Delete Data of BloodRequestor
        public string DeleteBloodRequestedData(string loginId)
        {

            var message = "";

            using (var context = new Entities1())
            {
                var decId = Convert.ToDecimal(loginId);
                var dataToDeleteRequested = context.BLOODREQUESTORs.Where(x => x.USERID == decId).FirstOrDefault();
                context.BLOODREQUESTORs.Remove(dataToDeleteRequested);
                context.SaveChanges();
                message = "Delete successfull";
            }
            return message;

        }



        private void SendMailCustom(string email,string dbmessage,string name,string blood,string address,string phone)
        {
            try
            {
                string message;
                WebMail.SmtpServer = "smtp.gmail.com";
                WebMail.SmtpPort = 587;
                WebMail.SmtpUseDefaultCredentials = true;
                WebMail.EnableSsl = true;
                WebMail.UserName = "bloodfindernepal@gmail.com";
                WebMail.Password = "123bloodfindernepal";

                WebMail.From = "bloodfindernepal@gmail.com";

                string mailBody = $@"Blood Type {blood} is need for {name} at location {address}, For More Contact :{phone}.Requestor Message:*{dbmessage}*";

                WebMail.Send(email, "Request For Blood", body: mailBody, isBodyHtml: true);


                message = "Email successfully sent";
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
          
        }

        //User Profile
        
        public Login GetUserprofile(string loginId)
        {
            using (var context = new Entities1())
            {
                var lgId = Convert.ToInt32(loginId);
                var userprofile = context.LOGINs.Where(x => x.USERID == lgId).FirstOrDefault();
                var userListInfoList = new Login();
                userListInfoList.Email = userprofile.EMAIL;
                userListInfoList.Username = userprofile.USERNAME;
                userListInfoList.Phone_Number = userprofile.PHONENO;
                               //foreach (var bd in userprofile)
                //{
                //    userListObj = new Login
                //    {
                //        Username = bd.USERNAME,
                //        Phone_Number = bd.PHONENO,
                //        Email = bd.EMAIL
                       

                //    };
                //    userListInfoList.Add(userListObj);
                //}
                return userListInfoList;

            }
        }

        //Edit Userprofile
        //public string UpdateUserprofileData(Login l, string loginId)
        //{

        //    var message = "";

        //    using (var context = new Entities1())
        //    {
        //        var decId = Convert.ToDecimal(loginId);
        //        var dataToUpdate = context.LOGINs.Where(x => x.USERID == decId).FirstOrDefault();
                
        //        dataToUpdate.PHONENO = l.Phone_Number;
        //        dataToUpdate.EMAIL = l.Email;

        //        context.SaveChanges();
        //        message = "Update successfull";
        //    }
        //    return message;

        //}
    }
}
