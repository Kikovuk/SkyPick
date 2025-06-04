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
        private Login _login;
        public AdminMainWindow()
        {
            InitializeComponent();
        }

        public AdminMainWindow(Login login)
        {
            InitializeComponent();
            _login = login;
        }

        private void AdminMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageUsers manageUsers = new ManageUsers();
            manageUsers.Show();
        }
    }
}
