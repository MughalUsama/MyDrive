using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class UserDTO
    {
        public String Name { get; set; }
        public String Login { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public String NIC { get; set; }
        public DateTime DOB { get; set; }
        public int IsCricket { get; set; }
        public int Hockey { get; set; }
        public int Chess { get; set; }
        public String ImageName { get; set; }
        public int IsActive { get; set; }
        public void clearDTO()
        {
            this.Name = null;
            this.Login = null;
            this.Email = null;
            this.Password = null;
            this.Address = null;
            this.NIC = null;
            this.IsCricket = 0;
            this.Hockey = 0;
            this.Chess = 0;
            this.ImageName = null;
            this.IsActive = 0;
        }
    }
}
