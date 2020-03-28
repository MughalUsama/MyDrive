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
        Entity.AdminDTO admin = new Entity.AdminDTO();
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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length == 0 || loginBox.Text.Length == 0)
            {
                MessageBox.Show("Please Fill All Credentials");
            }
            else if (passwordBox.Text.Length < 5)
            {
                MessageBox.Show("Password should be atleast 5 characters long");
            }
            else
            {
                if(UMS.BAL.AdminBO.validateAdmin(loginBox.Text, passwordBox.Text,admin))
                {
                    AdminHomeForm adminHome = new AdminHomeForm(admin);
                    this.Hide();
                    adminHome.Show();

                }
                else
                {
                    MessageBox.Show("You have entered Wrong Credentials");
                }
            }
        }

        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}
