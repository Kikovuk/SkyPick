using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyPick
{
    public partial class Login : Form
    {
        private readonly SkyPickEntities _db;
        private readonly ResetPassword rp;
        public Login()
        {
            InitializeComponent();
            _db = new SkyPickEntities();

            this.AcceptButton = btnLogin;
        }

      

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                var email = tbEmail.Text.Trim();
                var password = tbPassword.Text;

                var hashed_password = Utils.HashPassword(password);

                var user = _db.User.FirstOrDefault(q => q.Email == email && q.Password == hashed_password);
                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials.");
                }
                else
                {
                    if (user.IsActive == true)
                    {
                        if (user.Password == Utils.DefaultHashPassword())
                        {
                            var resetPassword = new ResetPassword(user);
                            resetPassword.Show();
                        }
                        else
                        {
                            var role = user.Role;
                            if (role.Equals("admin"))
                            {
                                Hide();
                                AdminMainWindow amw = new AdminMainWindow(user);
                                amw.ShowDialog();
                                Close();
                            }
                            else
                            {
                                Hide();
                                PassengerMainWindow pmw = new PassengerMainWindow(user);
                                pmw.ShowDialog();
                                Close();
                            }
                        }

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("This user has been deactivated.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Please try again!");
            }
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

        private void tbEmail_TextChanged_1(object sender, EventArgs e)
        {
            if (IsValidEmail(tbEmail.Text))
            {
                tbEmail.BackColor = Color.White;
            }
            else
            {
                tbEmail.BackColor = Color.MistyRose;
            }
        }

        private void tbPassword_TextChanged_1(object sender, EventArgs e)
        {
            if (tbPassword.Text.Length >= 6)
            {
                tbPassword.BackColor = Color.White;
            }
            else
            {
                tbPassword.BackColor = Color.MistyRose;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void chShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar != '\0')
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }
    }
}
