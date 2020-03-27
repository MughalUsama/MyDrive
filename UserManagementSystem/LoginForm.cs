using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.BAL;

namespace UserManagementSystem
{
    public partial class LoginForm : Form
    {
        Entity.UserDTO user;
        public LoginForm()
        {
            user = new Entity.UserDTO();
            InitializeComponent();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["MainScreen"].Show();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["MainScreen"].Show();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

            if(UMS.BAL.UserBO.emailExists(textBox3.Text))
            {
                string code = null;
                UMS.BAL.UserBO.resetEmail(textBox3.Text, out code);
                ResetCodeForm resetCodeForm = new ResetCodeForm(code, textBox3.Text);
                resetCodeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Enter Valid Email");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(loginBox.Text.Length==0 || passBox.Text.Length==0)
            {
                MessageBox.Show("Please Fill All Fields");
                loginBox.Focus();
            }
            else
            {
                if (UMS.BAL.UserBO.validateUser(loginBox.Text, passBox.Text,user))
                {
                    this.Hide();
                    HomeForm homeForm = new HomeForm(user);
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Credentials");
                }
            }
        }

        
    }
}
