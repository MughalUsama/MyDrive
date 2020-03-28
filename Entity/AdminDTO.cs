using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{

    public class AdminDTO
    {
        public String AdminName { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public int IsActive { get; set; }
        public void clearDTO()
        {
            this.AdminName = null;
            this.Login = null;
            this.Password = null;
            this.IsActive = 0;
        }
    }
}
