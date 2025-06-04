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
    public partial class ResetPassword : Form
    {
        private readonly SkyPickEntities _db;
        private User _user;

        public ResetPassword(User user)
        {
            InitializeComponent();
            _db = new SkyPickEntities();
            _user = user;
            this.AcceptButton = btnResetPassword;
        }

        private void btnShowCurrentPassword_Click(object sender, EventArgs e)
        {
            if (tbCurrentPassword.PasswordChar != '\0')
                tbCurrentPassword.PasswordChar = '\0';
            else
                tbCurrentPassword.PasswordChar = '*';
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            var currentPassword = tbCurrentPassword.Text;
            var newPassword = tbNewPassword.Text;

            var hashedCurrentPassword = Utils.HashPassword(currentPassword);

            if (_user == null)
            {
                MessageBox.Show("No user data loaded.");
                return;
            }


            var userFromDb = _db.User.FirstOrDefault(q => q.UserID == _user.UserID);

            if (userFromDb == null)
            {
                MessageBox.Show("Unexpected error. User not found.");
                return;
            }


            if (!hashedCurrentPassword.Equals(userFromDb.Password))
            {
                MessageBox.Show("Please provide valid credentials.");
            }

            else
            {

                if (currentPassword == newPassword)
                {
                    MessageBox.Show("New password needs to be different from current one.");
                }
                else
                {
                    userFromDb.Password = Utils.HashPassword(newPassword);
                    _db.SaveChanges();
                    MessageBox.Show("Password has been reseted successfully!");
                    this.Hide();
                    var login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
            }
        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text.Length >= 6)
            {
                tbCurrentPassword.BackColor = Color.White;
            }
            else
            {
                tbCurrentPassword.BackColor = Color.MistyRose;
            }
        }

        private void tbNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPassword.Text.Length >= 6)
            {
                tbNewPassword.BackColor = Color.White;
            }
            else
            {
                tbNewPassword.BackColor = Color.MistyRose;
            }
        }

        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            Hide();
            PassengerMainWindow passengerMainWindow = new PassengerMainWindow();
            passengerMainWindow.ShowDialog();
            Close();
        }

        private void chShowCurrentPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCurrentPassword.PasswordChar != '\0')
                tbCurrentPassword.PasswordChar = '\0';
            else
                tbCurrentPassword.PasswordChar = '*';
        }

        private void cbShowNewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbNewPassword.PasswordChar != '\0')
                tbNewPassword.PasswordChar = '\0';
            else
                tbNewPassword.PasswordChar = '*';
        }
    }
}
