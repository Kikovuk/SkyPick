using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyPick
{
    public partial class ManageUsers : Form
    {

        private readonly SkyPickEntities _db;
        public ManageUsers()
        {
            InitializeComponent();
            _db = new SkyPickEntities();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if(!Utils.FormIsOpen("AddUser"))
            {
                var addUser = new AddUser();
                addUser.ShowDialog();
                this.Hide();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvUserList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a user first.");
                    return;
                }

                var id = (int)gvUserList.CurrentRow.Cells["UserID"].Value;

                var user = _db.User.FirstOrDefault(q => q.UserID == id);

                var new_password = Utils.DefaultHashPassword();
                user.Password = new_password;
                _db.SaveChanges();

                MessageBox.Show($"User with email: {user.Email} has reseted password.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvUserList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a user first.");
                    return;
                }

                var id = (int)gvUserList.CurrentRow.Cells["UserID"].Value;

                var user = _db.User.FirstOrDefault(q => q.UserID == id);

                user.IsActive = user.IsActive == true ? false : true;
                _db.SaveChanges();

                if (user.IsActive == true)
                    MessageBox.Show($"User with email: {user.Email} has been ACTIVATED.");
                else
                    MessageBox.Show($"User with email: {user.Email} has been DEACTIVATED.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            PopulateGrid();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var users = _db.User.Select(q => new
            {
                q.UserID, 
                q.FirstName, 
                q.LastName,
                q.Email,
                q.IsActive,
                q.Role
            }).ToList();

            gvUserList.DataSource = users;
        }
    }
}
