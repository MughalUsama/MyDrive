using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.DAL
{
    public static class AdminDAO
    {
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


    }
}
