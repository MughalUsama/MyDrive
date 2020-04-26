using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Ajax.Utilities;
using MyDrive_Entities;

namespace MyDriveAPI.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        [HttpGet]
        public Object SignUpUser(String signup_Email, String user_Name, String signup_Password)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            UserDTO user = new UserDTO();
            if (signup_Email == "" || signup_Password == "")
            {
                var x = new {Error = "Fill all Fields"};
                return Json(x);
            }
            else if (signup_Password.Length < 8 || !Regex.IsMatch(signup_Email, pattern))
            {
                return Json(new {Error = "Please enter valid password and email"});
            }
            else if (MyDrive_BAL.UserBO.SignUpUser(signup_Email, user_Name, signup_Password))
            {
                return Json(new {Error = "Success"});
            }
            else
            {
                return Json(new {Error = "Email Already Exists"});
            }
        }
        [Authorize]
        [HttpGet]
        public Object GetFolders(int pf_id)
        {
            var user = User.Identity as ClaimsIdentity;
            var email = "";
            if (user!=null)
            {
                IEnumerable<Claim> claims = user.Claims;
                email = claims.Where(p => p.Type == "Email").FirstOrDefault()?.Value;
            }
            var folderList = MyDrive_BAL.UserBO.GetFolders(pf_id, email);
            return Json(folderList);
        }
        [Authorize]
        [HttpGet]
        public Object AddFolder(String folder_name, int pf_id)
        {
            var user = User.Identity as ClaimsIdentity;
            var email = "";
            if (user != null)
            {
                IEnumerable<Claim> claims = user.Claims;
                email = claims.Where(p => p.Type == "Email").FirstOrDefault()?.Value;
            }
            MyDrive_BAL.UserBO.AddFolder(folder_name, pf_id, email);
            return GetFolders(pf_id);
        }
    }

}
