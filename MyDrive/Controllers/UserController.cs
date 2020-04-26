using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Microsoft.IdentityModel.Tokens;
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
        [HttpGet]
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
                string key = "my_drive_key_123";
                var issuer = "http://mydrive.com";
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                var permClaims = new List<Claim>();
                permClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                permClaims.Add(new Claim("Email", user.Email));
                permClaims.Add(new Claim("Username", user.Username));
                permClaims.Add(new Claim("Password", login_Password));

                var token = new JwtSecurityToken(issuer,
                    issuer,
                    permClaims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: credentials);
                var jwt_token = new JwtSecurityTokenHandler().WriteToken(token);
                return Json(new { Error = "" , data = jwt_token});
            }
            else
            {
                return Json(new {Error = "Wrong Credentials"});
            }
        }

        
    }
}