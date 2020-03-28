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
    public partial class AdminHomeForm : Form
    {
        List<Entity.UserDTO> userDTOs = null;
        Entity.AdminDTO admin = new Entity.AdminDTO();
        public AdminHomeForm(Entity.AdminDTO adminDTO)
        {
            admin = adminDTO;
            InitializeComponent();
            userGridView.AutoGenerateColumns = false;
        }

        private void AdminHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.clearDTO();
            Application.OpenForms["MainScreen"].Show();
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            admin.clearDTO();
            this.Close();
        }
        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            userDTOs = UMS.BAL.AdminBO.getAllUsers();
            userGridView.DataSource = userDTOs;
        }
        public void reloadData()
        {
            userDTOs = UMS.BAL.AdminBO.getAllUsers();
            userGridView.DataSource = userDTOs;
        }
        private void UserGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                Entity.UserDTO edituser =userDTOs.Find(x => x.UserID == (int)userGridView.CurrentRow.Cells[0].Value);
                NewUserForm newUserForm = new NewUserForm(edituser, admin, true);
                this.Close();
                newUserForm.Show();
            }
        }
    }
}
