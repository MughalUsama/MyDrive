using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UMS.BAL;
using Entity;

namespace UserManagementSystem
{
    public partial class NewUserForm : Form
    {
        Entity.UserDTO userDTO = null;
        public Boolean isLoggedIn { get; set; }
        public NewUserForm()
        {
            InitializeComponent();
        }
        public NewUserForm(Entity.UserDTO user)
        {
            userDTO = user;
            InitializeComponent();
            this.nameTxtBox.Text = userDTO.Name;
            this.loginTxtBox.Text = userDTO.Login;
            this.emailTxtBox.Text = userDTO.Email;
            this.passwordTxtBox.Text = userDTO.Password;
            this.dobPicker.Value = userDTO.DOB;
            this.genderBox.Text = userDTO.Gender + "";
            this.addressTxtBox.Text = userDTO.Address;
            this.ageBox.Value = userDTO.Age;
            this.nicTxtBox.Text = userDTO.NIC;
            this.cricketCheckBox.Checked = (userDTO.IsCricket == 1);
            this.hockeyCheckBox.Checked = (userDTO.Hockey == 1);
            this.chessCheckBox.Checked = (userDTO.Chess == 1);
            this.userPictureBox.Load(userDTO.ImageName);



        }
        int errorCount = 0;
        private void UploadBtn_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                userPictureBox.Load(filename);
                if (errorProvider8.GetError(this.userPictureBox) != "")
                {
                    errorCount--;
                    errorProvider8.Clear();
                }
            }
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (isLoggedIn)
            {
                Application.OpenForms["homeForm"].Show();
            }
            else
            {
                Application.OpenForms["MainScreen"].Show();
            }

        }
       
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if(userPictureBox.Image==null)
            {
                errorCount++;
                errorProvider8.SetError(this.userPictureBox, "Please upload an image");
            }
            NameTxtBox_Leave(sender, e);
            LoginTxtBox_Leave(sender, e);
            PasswordTxtBox_Leave(sender, e);
            EmailTxtBox_Leave(sender, e);
            NicTxtBox_Leave(sender, e);
            AddressTxtBox_Leave(sender, e);
            GenderBox_Leave(sender, e);


            if (errorCount>0)
            {
                MessageBox.Show("Please fill all fields" + errorCount);
            }
            else
            {
                Entity.UserDTO userDTO = new UserDTO();
                userDTO.Name = nameTxtBox.Text;
                userDTO.Login = loginTxtBox.Text;
                userDTO.NIC = nicTxtBox.Text;
                userDTO.Password = passwordTxtBox.Text;
                userDTO.Gender = genderBox.Text[0];
                userDTO.Age = (int)ageBox.Value;
                userDTO.Address = addressTxtBox.Text;
                userDTO.DOB = dobPicker.Value;
                userDTO.Email = emailTxtBox.Text;
                if(chessCheckBox.Checked)
                {
                    userDTO.Chess = 1 ;
                }
                else
                {
                    userDTO.Chess = 0;
                }
                if(hockeyCheckBox.Checked)
                {
                    userDTO.Hockey = 1;
                }
                else
                {
                    userDTO.Hockey = 0;
                }
                if(cricketCheckBox.Checked)
                {
                    userDTO.IsCricket = 1;
                }
                else
                {
                    userDTO.IsCricket = 0;
                }
                userDTO.IsActive = 1;
                userDTO.ImageName = userPictureBox.ImageLocation;
                if (!isLoggedIn)
                {
                    UMS.BAL.UserBO.addUser(userDTO);
                }
                this.Hide();
                HomeForm homeForm = new HomeForm(userDTO);
                homeForm.Show();
            }
        }

        private void NewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggedIn)
            {
                Application.OpenForms["homeForm"].Show();
            }
            else
            {
                Application.OpenForms["MainScreen"].Show();
            }
        }



        private void NameTxtBox_Leave(object sender, EventArgs e)
        {
            if (nameTxtBox.Text.Length == 0)
            {
                if (errorProvider1.GetError(this.nameTxtBox) == "")
                {
                    errorProvider1.SetError(this.nameTxtBox, "Please fill this field");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider1.GetError(this.nameTxtBox) != "")
                {
                    errorProvider1.Clear();
                    errorCount--;
                }
            }
        }

        private void LoginTxtBox_Leave(object sender, EventArgs e)
        {
            if (loginTxtBox.Text.Length == 0)
            {
                if (errorProvider2.GetError(this.loginTxtBox) == "")
                {
                    errorProvider2.SetError(this.loginTxtBox, "Please fill this field");
                    errorCount++;
                }
            }
            else if (UserBO.userExists(loginTxtBox.Text))
            {
                if (errorProvider2.GetError(this.loginTxtBox) == "")
                {
                    errorProvider2.SetError(this.loginTxtBox, "Login Already in Use");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider2.GetError(this.loginTxtBox) != "")
                {
                    errorProvider2.Clear();
                    errorCount--;
                }
            }
        }

        private void PasswordTxtBox_Leave(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text.Length < 8)
            {
                if (errorProvider3.GetError(this.passwordTxtBox) == "")
                {
                    errorProvider3.SetError(this.passwordTxtBox, "Password must be 8 characters long");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider3.GetError(this.passwordTxtBox) != "")
                {
                    errorProvider3.Clear();
                    errorCount--;
                }
            }
        }

        private void EmailTxtBox_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (!Regex.IsMatch(emailTxtBox.Text, pattern))
            {
                if (errorProvider4.GetError(this.emailTxtBox) == "")
                {
                    errorProvider4.SetError(this.emailTxtBox, "Password must be 8 characters long");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider4.GetError(this.emailTxtBox) != "")
                {
                    errorProvider4.Clear();
                    errorCount--;
                }
            }
        }

        private void GenderBox_Leave(object sender, EventArgs e)
        {
            if (genderBox.Text.Length == 0)
            {
                if (errorProvider5.GetError(this.genderBox) == "")
                {
                    errorProvider5.SetError(this.genderBox, "Please fill this field");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider5.GetError(this.genderBox) != "")
                {
                    errorProvider5.Clear();
                    errorCount--;
                }
            }
        }

        private void AddressTxtBox_Leave(object sender, EventArgs e)
        {
            if (addressTxtBox.Text.Length < 8)
            {
                if (errorProvider6.GetError(this.addressTxtBox) == "")
                {
                    errorProvider6.SetError(this.addressTxtBox, "Address must be 8 characters long");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider6.GetError(this.addressTxtBox) != "")
                {
                    errorProvider6.Clear();
                    errorCount--;
                }
            }
        }

        private void NicTxtBox_Leave(object sender, EventArgs e)
        {
            if (!nicTxtBox.MaskFull)
            {
                if (errorProvider7.GetError(this.nicTxtBox) == "")
                {
                    errorProvider7.SetError(this.nicTxtBox, "Please fill this field");
                    errorCount++;
                }
            }
            else
            {
                if (errorProvider7.GetError(this.nicTxtBox) != "")
                {
                    errorProvider7.Clear();
                    errorCount--;
                }
            }
        }
    }
}
