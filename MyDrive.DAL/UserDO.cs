using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDrive_Entities;

namespace MyDrive_DAL
{
    public static class UserDO
    {
        public static Boolean ValidateUser(String login_Email, String login_Password, UserDTO user)
        {
            String query = String.Format("SELECT * FROM user_details where Email='{0}' and Password='{1}'",login_Email,login_Password);
            DBConnection dbConnection = new DBConnection();
            var userDetails = dbConnection.ExecuteReader(query);
            if (userDetails.Read())
            {
                user.Email = userDetails.GetString("Email");
                user.Username = userDetails.GetString("Username");
                return true;
            }
            else
            {
                user = null;
                return false;
            }
        }
        public static Boolean SignUpUser(String login_Email,String user_name ,String login_Password)
        {
            String query = String.Format("SELECT * FROM user_details where Email='{0}';" ,login_Email);
            using (DBConnection dbConnection = new DBConnection())
            {
                var userDetails = dbConnection.ExecuteReader(query);

                if (userDetails.Read())
                {
                    return false;
                }
            }
            query = String.Format("INSERT INTO user_details (Email, Password, Username)VALUES ('{0}', '{1}' , '{2}')", login_Email, login_Password,user_name);
            using(DBConnection dbConnection = new DBConnection())
            {
                var userAdded = dbConnection.ExecuteQuery(query);
                if (userAdded > 0)
                {
                    return true;
                }
                return false;
            }
        }


        public static Boolean AddFolder(string folder_name, int pf_id, String user_email)
        {
            using (DBConnection dbConnection = new DBConnection())
            {
                String sql;
                if (pf_id != -1)
                {
                    sql = String.Format("INSERT INTO folder_details (FolderName, ParentFolderId,Email)VALUES ('{0}', '{1}','{2}')",folder_name,pf_id, user_email);
                }
                else
                {
                    sql = String.Format("INSERT INTO folder_details (FolderName, Email)VALUES ('{0}', '{1}')", folder_name, user_email);
                }
                var folderAdded = dbConnection.ExecuteQuery(sql);
                if (folderAdded > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public static List<MyDrive_Entities.FolderDTO> GetFolders(int pf_id, String user_email)
        {
            String sql;
            if (pf_id==-1)
            {
                sql =String.Format("SELECT FolderId, FolderName, ParentFolderId FROM folder_details where Email='{0}' and ParentFolderId is null", user_email);
            }
            else
            {
                sql = String.Format("SELECT FolderId, FolderName, ParentFolderId FROM folder_details where Email='{0}' and ParentFolderId={1}", user_email,pf_id);
            }
            List<MyDrive_Entities.FolderDTO> foldersList = new List<FolderDTO>();
            using (DBConnection dbConnection = new DBConnection())
            {
                var foldersData = dbConnection.ExecuteReader(sql);
                while (foldersData.Read())
                {
                    FolderDTO folder = new FolderDTO();

                    folder.folderName = foldersData.GetString("FolderName");
                    if (!foldersData.IsDBNull(foldersData.GetOrdinal("FolderId")))
                    {
                        folder.folderID = foldersData.GetInt32("FolderId");
                    }
                    else
                    {
                        folder.folderID = -1;
                    }
                    if (!foldersData.IsDBNull(foldersData.GetOrdinal("ParentFolderId")))
                    {
                        folder.parentFolderID = foldersData.GetInt32("ParentFolderId");
                    }
                    else
                    {
                        folder.parentFolderID = -1;
                    }
                    foldersList.Add(folder);
                }
            }

            return foldersList;
        }
    }
}