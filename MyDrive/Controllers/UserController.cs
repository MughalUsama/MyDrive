using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using MyDrive.Security;
using MyDrive_BAL;
using MyDrive_Entities;

namespace MyDrive.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Home()
        {
            ViewBag.username = "";
            if (!SessionManager.IsValidUser)
            {
                return Redirect("~/Home/Index");
            }

            ViewBag.username = SessionManager.User.Username;
            return View();
        }

        public ActionResult Logout()
        {
            SessionManager.ClearSession();
            return Redirect("~/Home/Index");
        }

        [HttpPost]
        public ActionResult ValidateUser(String login_Email, String login_Password)
        {
            UserDTO user = new UserDTO();
            if (login_Email == "" || login_Password == "")
            {
                return Json(new {Error = "Fill all Fields"});
            }
            else if (MyDrive_BAL.UserBO.ValidateUser(login_Email, login_Password, user))
            {
                SessionManager.User = user;
                return JavaScript("window.location = '/User/Home'");
            }
            else
            {
                return Json(new {Error = "Wrong Credentials"});
            }
        }

        [HttpPost]
        public ActionResult SignUpUser(String signup_Email, String user_Name, String signup_Password)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            UserDTO user = new UserDTO();
            if (signup_Email == "" || signup_Password == "")
            {
                return Json(new {Error = "Fill all Fields"});
            }
            else if (signup_Password.Length < 8 || !Regex.IsMatch(signup_Email, pattern))
            {
                return Json(new {Error = "Please enter valid password and email"});
            }
            else if (MyDrive_BAL.UserBO.SignUpUser(signup_Email, user_Name, signup_Password))
            {
                return Json(new { Error = "Success" });
            }
            else
            {
                return Json(new {Error = "Email Already Exists"});
            }
        }

        [HttpPost]
        public ActionResult GetFolders( int pf_id)
        {
            var folderList = MyDrive_BAL.UserBO.GetFolders(pf_id, SessionManager.User.Email);
            return Json(folderList);
        }
        [HttpPost]
        public ActionResult AddFolder(String folder_name, int pf_id)
        {
            MyDrive_BAL.UserBO.AddFolder(folder_name, pf_id,SessionManager.User.Email);
            return GetFolders(pf_id);
        }
    }
}