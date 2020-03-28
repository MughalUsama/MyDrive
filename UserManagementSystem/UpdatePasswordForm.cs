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
    public partial class UpdatePasswordForm : Form
    {
        string userEmail;
        Entity.UserDTO user;

        public UpdatePasswordForm(string Email)
        {
            userEmail = Email;
            user = new Entity.UserDTO();
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            String newPassword = this.newPasswordTxtBox.Text;
            if (newPassword.Length < 8)
            {
                MessageBox.Show("Password should be atleast 8 characters long");
            }
            else
            {
                if (UMS.BAL.UserBO.updatePassword(newPassword, userEmail, user))
                {
                    MessageBox.Show("Password Updated Successfully");
                    this.Close();
                    Application.OpenForms["loginForm"].Hide();
                    HomeForm homeForm = new HomeForm(user);
                    homeForm.Show();

                }
            }
        }

        private void NewPasswordTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmBtn_Click(sender, e);
            }
        }
    }
}
