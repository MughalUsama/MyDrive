using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.DAL
{
    public static class UserDAO
    {
        public static Boolean userExists(String uLogin)
        {
            String sqlquery = String.Format("Select * from dbo.Users where Login='{0}' and IsActive=1;", uLogin);
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
        public static Boolean addUser(Entity.UserDTO userDTO)
        {
            String sqlQuery = String.Format("Select * from dbo.Users where Login = '{0}'", userDTO.Login);
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlQuery);

                    if (reader.Read()) //loginExistsButInactive
                    {
                        sqlQuery = String.Format("Update dbo.Users Set Login = '{0}',Name='{1}',Email='{2}',Password='{3}',Gender='{4}',Age={5},Address='{6}',NIC='{7}',DOB='{8}',IsCricket={9},Hockey={10},Chess={11},ImageName='{12}', ModifiedOn = GETDATE(),IsActive={13},ModifiedBy='{14}' where Login='{15}';", userDTO.Login, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Gender, userDTO.Age, userDTO.Address, userDTO.NIC, userDTO.DOB, userDTO.IsCricket, userDTO.Hockey, userDTO.Chess, userDTO.ImageName, userDTO.IsActive, userDTO.Login, userDTO.Login);
                    }
                    else
                    {
                        sqlQuery = String.Format("Insert into dbo.Users(Login,Name,Email,Password,Gender,Age,Address,NIC,DOB,IsCricket,Hockey,Chess,ImageName,CreatedOn, ModifiedOn,IsActive,CreatedBy,ModifiedBy) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}',{9},{10},{11},'{12}',GETDATE(),GETDATE(),{13},'{14}','{15}');", userDTO.Login, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Gender, userDTO.Age, userDTO.Address, userDTO.NIC, userDTO.DOB, userDTO.IsCricket, userDTO.Hockey, userDTO.Chess, userDTO.ImageName, userDTO.IsActive, userDTO.Login, userDTO.Login);
                    }
                }
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
        public static Boolean validateUser(String uLogin, String uPassword,Entity.UserDTO user)
        {
            String sqlquery = String.Format("Select * from dbo.Users where Login='{0}' and Password='{1}' and IsActive=1;", uLogin,uPassword);
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlquery);
                    if (reader.Read())
                    {
                        user.UserID = (int)reader["UserID"];
                        user.Name =(string)reader["Name"];
                        user.Email = (string)reader["Email"];
                        user.Password = (string)reader["Password"];
                        user.Login = (string)reader["Login"];
                        user.Gender = ((string)reader["Gender"])[0];
                        user.Address = (string)reader["Address"];
                        user.Age = (int)reader["Age"];
                        user.NIC = (string)reader["NIC"];
                        user.DOB= (DateTime)reader["DOB"];
                        if ((bool)reader["IsActive"])
                        {
                            user.IsActive = 1;
                        }
                        else
                        {
                            user.IsActive = 0;
                        }
                        if ((bool)reader["IsCricket"])
                        {
                            user.IsCricket = 1;
                        }
                        else
                        {
                            user.IsCricket = 0;
                        }
                        if((bool)reader["Hockey"])
                        {
                            user.Hockey = 1;
                        }
                        else
                        {
                            user.Hockey = 0;
                        }
                        if((bool)reader["Chess"])
                        {
                            user.Chess = 1;
                        }
                        else
                        {
                            user.Chess = 0;
                        }

                        user.ImageName = (string)reader["ImageName"];
                        return true;
                    }
                    else
                    {
                        user = null;
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static Boolean updateUser(Entity.UserDTO userDTO, Entity.AdminDTO adminDTO, bool isAdmin)
        {
            String modifiedBy = userDTO.Login;
            if(isAdmin)
            {
                modifiedBy = adminDTO.Login;
            }
            String sqlQuery = String.Format("Update dbo.Users Set Login = '{0}',Name='{1}',Email='{2}',Password='{3}',Gender='{4}',Age={5},Address='{6}',NIC='{7}',DOB='{8}',IsCricket={9},Hockey={10},Chess={11},ImageName='{12}', ModifiedOn = GETDATE(),IsActive={13},ModifiedBy='{14}' where UserID={15};", userDTO.Login, userDTO.Name, userDTO.Email, userDTO.Password, userDTO.Gender, userDTO.Age, userDTO.Address, userDTO.NIC, userDTO.DOB, userDTO.IsCricket, userDTO.Hockey, userDTO.Chess, userDTO.ImageName, userDTO.IsActive, modifiedBy, userDTO.UserID);
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
        public static Boolean emailExists(String uEmail)
        {
            String sqlquery = String.Format("Select * from dbo.Users where Email='{0}';", uEmail);
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
        public static Boolean updatePassword(String newPassword, String userEmail,Entity.UserDTO user)
        {
            String sqlQuery = String.Format("Update dbo.Users Set Password='{0}',ModifiedBy='{1}',ModifiedOn=GetDate() where Email='{2}';", newPassword,userEmail,userEmail );
            try
            {
                using (DBConnection dBConnection = new DBConnection())
                {
                    dBConnection.ExecuteQuery(sqlQuery);                    
                }
                sqlQuery = String.Format("Select * from dbo.Users where Email='{0}' ;", userEmail);
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlQuery);
                    if (reader.Read())
                    {
                        user.Name = (string)reader["Name"];
                        user.Email = (string)reader["Email"];
                        user.Password = (string)reader["Password"];
                        user.Login = (string)reader["Login"];
                        user.Gender = ((string)reader["Gender"])[0];
                        user.Address = (string)reader["Address"];
                        user.Age = (int)reader["Age"];
                        user.NIC = (string)reader["NIC"];
                        user.DOB = (DateTime)reader["DOB"];
                        if ((bool)reader["IsActive"])
                        {
                            user.IsActive = 1;
                        }
                        else
                        {
                            user.IsActive = 0;
                        }
                        if ((bool)reader["IsCricket"])
                        {
                            user.IsCricket = 1;
                        }
                        else
                        {
                            user.IsCricket = 0;
                        }
                        if ((bool)reader["Hockey"])
                        {
                            user.Hockey = 1;
                        }
                        else
                        {
                            user.Hockey = 0;
                        }
                        if ((bool)reader["Chess"])
                        {
                            user.Chess = 1;
                        }
                        else
                        {
                            user.Chess = 0;
                        }

                        user.ImageName = (string)reader["ImageName"];
                        return true;
                    }
                    else
                    {
                        user = null;
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<Entity.UserDTO> getAllUsers()
        {
            List<Entity.UserDTO> userDTOs = new List<Entity.UserDTO>();
            try
            {
                String sqlquery = "Select * from dbo.Users where IsActive=1;";
                using (DBConnection dBConnection = new DBConnection())
                {
                    var reader = dBConnection.ExecuteReader(sqlquery);
                    while (reader.Read())
                    {
                        String name = (string)reader["Name"]; ;
                        String email = (string)reader["Email"]; ;
                        String address = (string)reader["Address"]; ;
                        String login = (string)reader["Login"]; ;
                        int userID = (int)reader["UserID"];
                        int age = (int)reader["Age"];
                        String password = (string)reader["Password"];
                        Char gender = ((string)reader["Gender"])[0];
                        String nIC = (string)reader["NIC"];
                        DateTime dOB = (DateTime)reader["DOB"];
                        int isActive, isCricket, hockey, chess;
                        if ((bool)reader["IsActive"])
                        {
                             isActive = 1;
                        }
                        else
                        {
                            isActive = 0;
                        }
                        if ((bool)reader["IsCricket"])
                        {
                            isCricket = 1;
                        }
                        else
                        {
                            isCricket = 0;
                        }
                        if ((bool)reader["Hockey"])
                        {
                            hockey = 1;
                        }
                        else
                        {
                            hockey = 0;
                        }
                        if ((bool)reader["Chess"])
                        {
                            chess = 1;
                        }
                        else
                        {
                            chess = 0;
                        }

                        String imageName = (string)reader["ImageName"];

                        userDTOs.Add(new Entity.UserDTO() { Address = address, Login = login, Age = age, Email = email, Name = name, UserID = userID, ImageName = imageName,Password=password,IsActive= isActive,IsCricket=isCricket,Chess=chess,Hockey=hockey,DOB = dOB,NIC=nIC,Gender=gender });
 

                    }
                }
                return userDTOs;
            }
            catch
            {
                return new List<Entity.UserDTO>();
            }
        }
    }
}