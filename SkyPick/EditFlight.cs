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
        private Flight _flightToEdit;
        public EditFlight()
        {
            InitializeComponent();
            LoadComboBoxes();

            cbDepartureAirport.DropDownStyle = ComboBoxStyle.DropDown;
            cbDepartureAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepartureAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbArrivalAirport.DropDownStyle = ComboBoxStyle.DropDown;
            cbArrivalAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbArrivalAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlane.DropDownStyle = ComboBoxStyle.DropDown;
            cbPlane.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPlane.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public EditFlight(ManageFlights manageFlights, Flight flight)
        {
            InitializeComponent();
            _manageFlight = manageFlights;
            _db = new SkyPickEntities();
            _flightToEdit = flight;
            LoadComboBoxes();

            cbDepartureAirport.DropDownStyle = ComboBoxStyle.DropDown;
            cbDepartureAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepartureAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbArrivalAirport.DropDownStyle = ComboBoxStyle.DropDown;
            cbArrivalAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbArrivalAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbPlane.DropDownStyle = ComboBoxStyle.DropDown;
            cbPlane.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbPlane.AutoCompleteSource = AutoCompleteSource.ListItems;

            tpDepartureTime.Format = DateTimePickerFormat.Custom;
            tpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            tpDepartureTime.ShowUpDown = true;

            tpArrivalTime.Format = DateTimePickerFormat.Custom;
            tpArrivalTime.CustomFormat = "dd.MM.yyyy HH:mm";
            tpArrivalTime.ShowUpDown = true;

            LoadComboBoxes();
            PopulateFields();
        }

        private void PopulateFields()
        {
            if (_flightToEdit == null)
                return;

            tbFlightNumber.Text = _flightToEdit.FlightNumber;
            cbPlane.SelectedValue = _flightToEdit.PlaneID;
            cbDepartureAirport.SelectedValue = _flightToEdit.DepartureAirportID;
            cbArrivalAirport.SelectedValue = _flightToEdit.ArrivalAirportID;
            if (_flightToEdit.DepartureTime != null)
                tpDepartureTime.Value = _flightToEdit.DepartureTime.Value;
            else
                tpDepartureTime.Value = DateTime.Now;

            if (_flightToEdit.ArrivalTime != null)
                tpArrivalTime.Value = _flightToEdit.ArrivalTime.Value;
            else
                tpArrivalTime.Value = DateTime.Now;

            tbPrice.Text = _flightToEdit.Price != null ? _flightToEdit.Price.Value.ToString("F2") : "0.00";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (cbDepartureAirport.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid departure airport from the list.");
                return;
            }

            if (cbArrivalAirport.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid arrival airport from the list.");
                return;
            }

            if (cbPlane.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid plane from the list.");
                return;
            }

            if (tpDepartureTime.Value >= tpArrivalTime.Value)
            {
                MessageBox.Show("Arrival time must be after departure time.");
                return;
            }

            if (tpDepartureTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Departure time must be set in the future.");
                return;
            }

            TimeSpan duration = tpArrivalTime.Value - tpDepartureTime.Value;
            if (duration.TotalMinutes < 30)
            {
                MessageBox.Show("Flight duration must be at least 30 minutes.");
                return;
            }


            int planeId = (int)cbPlane.SelectedValue;
            int depId = (int)cbDepartureAirport.SelectedValue;
            int arrId = (int)cbArrivalAirport.SelectedValue;

            var plane = _db.Plane.Find(planeId);
            var depAirport = _db.Airport.Find(depId);
            var arrAirport = _db.Airport.Find(arrId);

            if (depId == arrId)
            {
                MessageBox.Show("Departure and arrival airports cannot be the same.");
                return;
            }

            decimal price;
            if (!decimal.TryParse(tbPrice.Text, out price))
            {
                MessageBox.Show("Price is not a valid number.");
                return;
            }

            _flightToEdit.FlightNumber = tbFlightNumber.Text.Trim();
            _flightToEdit.PlaneID = (int)cbPlane.SelectedValue;
            _flightToEdit.DepartureAirportID = (int)cbDepartureAirport.SelectedValue;
            _flightToEdit.ArrivalAirportID = (int)cbArrivalAirport.SelectedValue;
            _flightToEdit.DepartureTime = tpDepartureTime.Value;
            _flightToEdit.ArrivalTime = tpArrivalTime.Value;
            _flightToEdit.Price = decimal.Parse(tbPrice.Text);

            _db.SaveChanges();

            MessageBox.Show("Flight successfully updated.");

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
