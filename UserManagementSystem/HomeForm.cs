using System;
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
            pictureBox1.Load(userDTO.ImageName);
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
            this.Close();
            Application.OpenForms["MainScreen"].Show();
        }
    }
}
