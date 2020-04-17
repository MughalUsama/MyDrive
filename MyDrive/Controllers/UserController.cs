using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDrive.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Logout()
        {
            return Redirect("~/Home/Index");
        }

        [HttpPost]
        public ActionResult ValidateUser(String login_Email, String login_Password)
        {
            if (login_Email == "" || login_Password == "")
            {
                return Json(new {Error = "Fill all Fields"});
            }
            else if(login_Email != "Usama@gmail.com" || login_Password != "aaaaaaaa")
            {
                return Json(new { Error = "Wrong Credentials" });
            }
            return JavaScript("window.location = '/User/Home'");
        }


    }
}