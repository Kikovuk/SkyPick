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
    public partial class Register : Form
    {
        private readonly SkyPickEntities _db;
        public Register()
        {
            InitializeComponent();
            _db = new SkyPickEntities();
            this.AcceptButton = btnRegister;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var firstName = tbFirstName.Text.Trim();
            var lastName = tbLastName.Text.Trim();
            var email = tbEmail.Text.Trim();
            var password = tbPassword.Text;
            var confirmPassword = tbConfirmPassword.Text;

            if (firstName == "" || lastName == "" || email == "" || password == "")
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            var existingUser = _db.User.FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                MessageBox.Show("Email already registered.");
                return;
            }

            var hashedPassword = Utils.HashPassword(password);
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = hashedPassword,
                Role = "passenger",
                IsActive = true
            };

            _db.User.Add(user);
            _db.SaveChanges();

            MessageBox.Show("Registration successful! You can now log in.");
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            tbEmail.BackColor = IsValidEmail(tbEmail.Text) ? Color.White : Color.MistyRose;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.BackColor = tbPassword.Text.Length >= 6 ? Color.White : Color.MistyRose;
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            tbConfirmPassword.BackColor = tbConfirmPassword.Text == tbPassword.Text ? Color.White : Color.MistyRose;
        }
    }
}
