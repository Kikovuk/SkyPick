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
    public partial class AdminMainWindow : Form
    {
        private readonly User currentUser;
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        public AdminMainWindow(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Hide();
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
            Close();
        }

        private void btnManageFlights_Click(object sender, EventArgs e)
        {
            Hide();
            ManageFlights manageFlights = new ManageFlights();
            manageFlights.ShowDialog();
            Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Hide();
            Reports reports = new Reports();
            reports.ShowDialog();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
