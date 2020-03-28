using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystem
{
    public partial class AdminHomeForm : Form
    {
        Entity.AdminDTO admin = new Entity.AdminDTO();
        public AdminHomeForm(Entity.AdminDTO adminDTO)
        {
            admin = adminDTO;
            InitializeComponent();
        }

        private void AdminHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.clearDTO();
            Application.OpenForms["MainScreen"].Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            admin.clearDTO();
            this.Close();
            Application.OpenForms["MainScreen"].Show();
        }
    }
}
