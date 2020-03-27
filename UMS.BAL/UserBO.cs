using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.DAL;

namespace UMS.BAL
{
    public static class UserBO
    {
        public static Boolean userExists(String uLogin)
        {
            return UserDAO.userExists(uLogin);
        }
        public static Boolean addUser(Entity.UserDTO userDTO)
        {
            if (DAL.UserDAO.addUser(userDTO))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean validateUser(String uLogin, String uPassword, Entity.UserDTO user)
        {
            if (DAL.UserDAO.validateUser(uLogin, uPassword, user))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean updateUser(Entity.UserDTO userDTO)
        {
            if (DAL.UserDAO.updateUser(userDTO))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean emailExists(String uEmail)
        {
            if (DAL.UserDAO.emailExists(uEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean resetEmail(String email, out string code)
        {
            try
            {
                Random random = new Random();
                code = random.Next(1000, 9999).ToString();
                EmailHandler.SendEmail(email, "Reset UMS Password", "Your Reset Code is " + code);
                return true;
            }
            catch
            {
                code = null;
                return false;
            }
        }
        public static Boolean updatePassword(String newPassword, String userEmail,Entity.UserDTO user)
        {
            try
            {
                if(DAL.UserDAO.updatePassword(newPassword, userEmail,user))
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
