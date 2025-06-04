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
    public partial class EditFlight : Form
    {
        private readonly SkyPickEntities _db;
        private ManageFlights _manageFlight;
        public EditFlight()
        {
            InitializeComponent();
        }
        public EditFlight(ManageFlights manageFlights)
        {
            InitializeComponent();
            _manageFlight = manageFlights;
        }
    }
}
