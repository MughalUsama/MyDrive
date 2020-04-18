using MyDrive_Entities;
using System;
using System.Collections.Generic;

namespace MyDrive_BAL
{
    public static class UserBO
    {
        public static Boolean ValidateUser(String login_Email, String login_Password,UserDTO user)
        {
            return MyDrive_DAL.UserDO.ValidateUser(login_Email, login_Password, user);
        }
        public static Boolean SignUpUser(String login_Email, String user_name, String login_Password)
        {
            return MyDrive_DAL.UserDO.SignUpUser(login_Email, user_name, login_Password);
        }
        public static Boolean AddFolder(String folder_name, int pf_id, String user_email)
        {
            MyDrive_DAL.UserDO.AddFolder(folder_name,pf_id,user_email);
            return true;
        }
        public static List<MyDrive_Entities.FolderDTO> GetFolders(int pf_id, String user_email)
        { 
            return MyDrive_DAL.UserDO.GetFolders(pf_id, user_email); ;
        }
    }
}
