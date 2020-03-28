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
    public partial class ResetCodeForm : Form
    {
        string resetcode, userEmail;
        public ResetCodeForm(string code, string email)
        {
            resetcode = code;
            userEmail = email;
            InitializeComponent();
        }

        private void CodeTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConfirmBtn_Click(sender, e);
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if(codeTxtBox.Text == resetcode)
            {
                this.Close();
                UpdatePasswordForm updatePasswordForm = new UpdatePasswordForm(userEmail);
                updatePasswordForm.ShowDialog();
            }
            else
            {
                this.Close();
                MessageBox.Show("You Entered Wrong Code");
            }

        }
    }
}
