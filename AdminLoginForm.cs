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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainScreen"].Show();
        }

        private void AdminLoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["MainScreen"].Show();
        }
    }
}
