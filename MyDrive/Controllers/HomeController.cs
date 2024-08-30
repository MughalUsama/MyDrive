using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDrive.Security;

namespace MyDrive.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.LoggedIn = false;
            if (SessionManager.IsValidUser)
            {
                Redirect("~/User/Home");
                ViewBag.LoggedIn = true;
            }
            return View();
        }
    }
}