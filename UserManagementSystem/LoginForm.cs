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
        public LoginForm()
        {
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
            ResetCodeForm resetCodeForm = new ResetCodeForm();
            resetCodeForm.ShowDialog();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UserBO.userExists(textBox1.Text))
            {
                MessageBox.Show("User Exists");
            }
            else
            {
                MessageBox.Show("User Dont Exists");
            }
        }
    }
}
