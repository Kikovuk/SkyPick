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
    public partial class PassengerMainWindow : Form
    {
        private readonly User currentUser;
        public PassengerMainWindow()
        {
            InitializeComponent();
        }
        public PassengerMainWindow(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {

        }

        private void btnMyReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to deactivate your account?", "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var db = new SkyPickEntities())
                {
                    var user = db.User.FirstOrDefault(q => q.UserID == currentUser.UserID);
                    if (user != null)
                    {
                        user.IsActive = false;
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Your account has been deactivated.");
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Hide();
            ResetPassword resetPassword = new ResetPassword(currentUser);
            resetPassword.ShowDialog();
            Close();
        }
    }
}
