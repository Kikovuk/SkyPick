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
    public partial class AddUser : Form
    {

        private readonly SkyPickEntities _db;
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _db = new SkyPickEntities();
            var roles = new List<string> { "admin", "passenger" };
            cbRoles.DataSource = roles;
            _manageUsers = manageUsers;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var email = tbEmail.Text;
            var password = Utils.DefaultHashPassword();
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                IsActive = true,
                Role = cbRoles.Text
            };

            _db.User.Add(user);
            _db.SaveChanges();

            MessageBox.Show("New user added successfully");
            _manageUsers.PopulateGrid();
            Hide();
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            Close();
        }
    }
}
