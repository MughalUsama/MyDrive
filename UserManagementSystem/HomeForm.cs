﻿using System;
using System.Windows.Forms;

namespace UserManagementSystem
{
    public partial class HomeForm : Form
    {
        Entity.UserDTO userDTO = null;
        public HomeForm(Entity.UserDTO user)
        {
            userDTO = user;
            InitializeComponent();
            welcomeUser.Text += userDTO.Name + "!";
            String imageFolderPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            imageFolderPath += @"\images\" + userDTO.Login + @"\"+userDTO.ImageName;
            this.pictureBox1.Load(imageFolderPath);
        }

        private void EditProfBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUserForm newUserForm = new NewUserForm(userDTO);
            newUserForm.isLoggedIn = true;
            newUserForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            userDTO.clearDTO();
            this.Close();
            Application.OpenForms["MainScreen"].Show();
        }
    }
}
