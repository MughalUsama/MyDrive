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
        string code = null;

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

            if(UMS.BAL.UserBO.emailExists(emailBox3.Text))
            {
                progressBar1.Visible = true;
                bgSendEmail.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Please Enter Valid Email!");
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(loginBox.Text.Length==0 || passBox.Text.Length==0)
            {
                MessageBox.Show("Please Fill All Fields!");
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
                    MessageBox.Show("Entered Credentials are Wrong!");
                }
            }
        }

        private void EmailBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ResetBtn_Click(sender, e);
            }
        }

        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void LoginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }

        private void BgSendEmail_DoWork(object sender, DoWorkEventArgs e)
        {
            if (UMS.BAL.UserBO.resetEmail(emailBox3.Text, out code))
            {
                bgSendEmail.ReportProgress(100);
            }
            else
            {
                bgSendEmail.CancelAsync();
                e.Cancel = true;
            }
        }

        private void BgSendEmail_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void BgSendEmail_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("Email could not be sent \n Try Again!");
            }
            else
            {
                ResetCodeForm resetCodeForm = new ResetCodeForm(code, emailBox3.Text);
                resetCodeForm.ShowDialog();
            }
            progressBar1.Visible = false;
        }
    }
}
