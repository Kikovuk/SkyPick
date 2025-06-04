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
    public partial class AddFlight : Form
    {

        private readonly SkyPickEntities _db;
        private ManageFlights _manageFlight;
        public AddFlight()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        public AddFlight(ManageFlights manageFlights)
        {
            InitializeComponent();
            _manageFlight = manageFlights;
            _db = new SkyPickEntities();
            LoadComboBoxes();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

            if (tpDepartureTime.Value >= tpArrivalTime.Value)
            {
                MessageBox.Show("Vrijeme dolaska mora biti nakon vremena poletanja.");
                return;
            }


            int planeId = (int)cbPlane.SelectedValue;
            int depId = (int)cbDepartureAirport.SelectedValue;
            int arrId = (int)cbArrivalAirport.SelectedValue;

            var plane = _db.Plane.Find(planeId);
            var depAirport = _db.Airport.Find(depId);
            var arrAirport = _db.Airport.Find(arrId);

            if (plane == null)
            {
                MessageBox.Show("Avion sa zadatim ID-jem ne postoji.");
                return;
            }

            if (depAirport == null || arrAirport == null)
            {
                MessageBox.Show("Jedan od aerodroma sa zadatim ID-jem ne postoji.");
                return;
            }

            if (depId == arrId)
            {
                MessageBox.Show("Polazni i dolazni aerodrom ne mogu biti isti.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Cena nije validan broj.");
                return;
            }

            var newFlight = new Flight
            {
                FlightNumber = tbFlightNumber.Text.Trim(),
                PlaneID = planeId,
                DepartureAirportID = depId,
                ArrivalAirportID = arrId,
                DepartureTime = tpDepartureTime.Value,
                ArrivalTime = tpArrivalTime.Value,
                Price = price
            };

            _db.Flight.Add(newFlight);
            _db.SaveChanges();

            MessageBox.Show("Let je uspjesno dodat.");

            _manageFlight.PopulateGrid();

            Hide();
            ManageFlights manageFlights = new ManageFlights();
            manageFlights.ShowDialog();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            ManageFlights manageFlights = new ManageFlights();
            manageFlights.ShowDialog();
            Close();
        }

        private void LoadComboBoxes()
        {
            var planes = (from p in _db.Plane
                          join m in _db.PlaneModel on p.ModelID equals m.ModelID
                          select new
                          {
                              p.PlaneID,
                              Display = p.Code + " - " + m.ModelName
                          }).ToList();

            cbPlane.DisplayMember = "Display";
            cbPlane.ValueMember = "PlaneID";
            cbPlane.DataSource = planes;

            var airports = _db.Airport
                .Select(a => new
                {
                    a.AirportID,
                    Display = a.Code + " - " + a.Name
                }).ToList();

            cbDepartureAirport.DisplayMember = "Name";
            cbDepartureAirport.ValueMember = "AirportID";
            cbDepartureAirport.DataSource = _db.Airport.ToList();

            cbArrivalAirport.DisplayMember = "Name";
            cbArrivalAirport.ValueMember = "AirportID";
            cbArrivalAirport.DataSource = _db.Airport.ToList();
        }
    }
}
