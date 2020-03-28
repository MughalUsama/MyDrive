using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.DAL
{
    public static class AdminDAO
    {
        public static Boolean adminExists(String uLogin)
        {
            String sqlquery = String.Format("Select * from dbo.Admin where Login='{0}' and IsActive=1;", uLogin);
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlquery);
                    if (reader.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean validateAdmin(String aLogin, String aPassword, Entity.AdminDTO admin)
        {
            String sqlquery = String.Format("Select * from dbo.Admin where Login='{0}' and Password='{1}' and IsActive=1;", aLogin, aPassword);
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlquery);
                    if (reader.Read())
                    {
                        admin.AdminName = (string)reader["AdminName"];
                        admin.Password = (string)reader["Password"];
                        admin.Login = (string)reader["Login"];
                        if ((bool)reader["IsActive"])
                        {
                            admin.IsActive = 1;
                        }
                        else
                        {
                            admin.IsActive = 0;
                        }
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean updateUser(Entity.UserDTO userDTO)
        {
            String sqlQuery = String.Format("Update dbo.Users Set Login = '{0}',Name='{1}',Email='{2}',Password='{3}',Gender='{4}',Age={5},Address='{6}',NIC='{7}',DOB='{8}',IsCricket={9},Hockey={10},Chess={11},ImageName='{12}',CreatedOn = GETDATE(), ModifiedOn = GETDATE(),IsActive={13},CreatedBy='{14}',ModifiedBy='{15}' where Login='{16}';", userDTO.Login, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Gender, userDTO.Age, userDTO.Address, userDTO.NIC, userDTO.DOB, userDTO.IsCricket, userDTO.Hockey, userDTO.Chess, userDTO.ImageName, userDTO.IsActive, userDTO.Login, userDTO.Login, userDTO.Login);
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    if (dBConnection.ExecuteQuery(sqlQuery) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


    }
}
