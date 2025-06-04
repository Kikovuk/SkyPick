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

        private readonly Login _login;
        public PassengerMainWindow()
        {
            InitializeComponent();
        }
        public PassengerMainWindow(Login login)
        {
            InitializeComponent();
            _login = login;
        }

        private void PassengerMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
