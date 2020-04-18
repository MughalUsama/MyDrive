using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDrive_Entities
{
    public class FolderDTO
    {
        public String folderName { get; set; }
        public int folderID { get; set; }
        public int parentFolderID { get; set; }
    }
}
