using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.BAL
{
    public static class AdminBO
    {
        public static Boolean validateAdmin(String aLogin, String aPassword, Entity.AdminDTO admin)
        {
            if (DAL.AdminDAO.validateAdmin(aLogin, aPassword, admin))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<Entity.UserDTO> getAllUsers()
        {
            return DAL.UserDAO.getAllUsers();
        }
    }
}
