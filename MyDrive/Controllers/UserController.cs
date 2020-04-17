using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            else if (MyDrive_BAL.UserBO.ValidateUser(login_Email,login_Password,user))
            {
                user.Username = "usama";
                SessionManager.User = user;
                return JavaScript("window.location = '/User/Home'");
            }
            else
            {
                return Json(new { Error = "Wrong Credentials" });
            }

        }


    }
}