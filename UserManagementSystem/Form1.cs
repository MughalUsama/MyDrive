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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newUserForm = new NewUserForm();
            newUserForm.isLoggedIn = false;
            newUserForm.Show();
        }

        private void ExUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
        }
    }
}
