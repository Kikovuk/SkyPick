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
    public partial class Reserve : Form
    {
        private readonly User currentUser;
        private readonly SkyPickEntities _db = new SkyPickEntities();
        public Reserve(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadInitialData();
            WireUpEvents();
            cbDepCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepCountry.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbDepCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepCity.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbDepAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbDepAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbArrCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbArrCountry.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbArrCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbArrCity.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbArrAirport.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbArrAirport.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbSeatClass.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSeatClass.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void LoadInitialData()
        {
            var countries = _db.Country.OrderBy(c => c.Name).ToList();

            cbDepCountry.DataSource = countries;
            cbDepCountry.DisplayMember = "Name";
            cbDepCountry.ValueMember = "CountryID";

            cbDepCity.DataSource = null;
            cbDepAirport.DataSource = null;

            cbArrCountry.DataSource = countries.ToList();
            cbArrCountry.DisplayMember = "Name";
            cbArrCountry.ValueMember = "CountryID";

            cbArrCity.DataSource = null;
            cbArrAirport.DataSource = null;

            var seatClasses = _db.SeatClass.OrderBy(sc => sc.Name).ToList();
            cbSeatClass.DataSource = seatClasses;
            cbSeatClass.DisplayMember = "Name";
            cbSeatClass.ValueMember = "SeatClassID";

            nudSeats.Minimum = 1;
            nudSeats.Maximum = 10;
            nudSeats.Value = 1;

            dgvFlights.DataSource = null;
        }

        private void WireUpEvents()
        {
            cbDepCountry.SelectedIndexChanged += (s, e) => LoadCitiesForCountry(cbDepCountry, cbDepCity, cbDepAirport);
            cbDepCity.SelectedIndexChanged += (s, e) => LoadAirportsForCity(cbDepCity, cbDepAirport);

            cbArrCountry.SelectedIndexChanged += (s, e) => LoadCitiesForCountry(cbArrCountry, cbArrCity, cbArrAirport);
            cbArrCity.SelectedIndexChanged += (s, e) => LoadAirportsForCity(cbArrCity, cbArrAirport);

            btnSearchFlights.Click += BtnSearchFlights_Click;
            btnReserve.Click += BtnReserve_Click;
        }

        private void LoadCitiesForCountry(ComboBox countryCb, ComboBox cityCb, ComboBox airportCb)
        {
            if (countryCb.SelectedValue == null)
            {
                cityCb.DataSource = null;
                if (airportCb != null)
                    airportCb.DataSource = null;
                return;
            }

            int countryId = (int)countryCb.SelectedValue;

            var cities = _db.City
                .Where(c => c.CountryID == countryId)
                .OrderBy(c => c.Name)
                .ToList();

            cityCb.DataSource = cities;
            cityCb.DisplayMember = "Name";
            cityCb.ValueMember = "CityID";

            if (cities.Count > 0 && airportCb != null)
            {
                cityCb.SelectedIndex = 0;
                LoadAirportsForCity(cityCb, airportCb);
            }
            else
            {
                cityCb.SelectedIndex = -1;
                if (airportCb != null)
                    airportCb.DataSource = null;
            }
        }

        private void LoadAirportsForCity(ComboBox cityCb, ComboBox airportCb)
        {
            if (cityCb.SelectedValue == null)
            {
                airportCb.DataSource = null;
                return;
            }

            if (!(cityCb.SelectedValue is int cityId))
            {
                airportCb.DataSource = null;
                return;
            }

            var airports = _db.Airport
                .Where(a => a.CityID == cityId)
                .OrderBy(a => a.Name)
                .ToList();

            airportCb.DataSource = airports;
            airportCb.DisplayMember = "Name";
            airportCb.ValueMember = "AirportID";

            if (airports.Count > 0)
            {
                airportCb.SelectedIndex = 0;
            }
            else
            {
                airportCb.SelectedIndex = -1;
            }
        }
        private void BtnSearchFlights_Click(object sender, EventArgs e)
        {
            if (cbDepAirport.SelectedValue == null || cbArrAirport.SelectedValue == null)
            {
                MessageBox.Show("Please select both departure and arrival airports.");
                return;
            }

            int depAirportId = (int)cbDepAirport.SelectedValue;
            int arrAirportId = (int)cbArrAirport.SelectedValue;

            if (depAirportId == arrAirportId)
            {
                MessageBox.Show("Departure and arrival airports cannot be the same.");
                return;
            }

            var flights = _db.Flight
                .Where(f => f.DepartureAirportID == depAirportId && f.ArrivalAirportID == arrAirportId)
                .Select(f => new
                {
                    f.FlightID,
                    f.FlightNumber,
                    Departure = f.DepartureTime,
                    Arrival = f.ArrivalTime,
                    Price = f.Price
                })
                .OrderBy(f => f.Departure)
                .ToList();

            dgvFlights.DataSource = flights;

            if (flights.Count == 0)
                MessageBox.Show("No flights found for the selected route.");
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            if (dgvFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight to reserve.");
                return;
            }

            if (cbSeatClass.SelectedValue == null)
            {
                MessageBox.Show("Please select a seat class.");
                return;
            }

            int flightId = (int)dgvFlights.CurrentRow.Cells["FlightID"].Value;
            int seatClassId = (int)cbSeatClass.SelectedValue;
            int numberOfSeats = (int)nudSeats.Value;
            
            int selectedSeatId = (int)nudSeats.Value;

            var reservation = new Reservation
            {
                UserID = currentUser.UserID,
                FlightID = flightId,
                SeatID = selectedSeatId,
                ReservationDate = DateTime.Now
            };

            _db.Reservation.Add(reservation);
            _db.SaveChanges();

            MessageBox.Show("Reservation successful!");

            Hide();
            MyReservations myReservations = new MyReservations(currentUser);
            myReservations.ShowDialog();
            Close();
        }

        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            Hide();
            PassengerMainWindow passengerMainWindow = new PassengerMainWindow(currentUser);
            passengerMainWindow.ShowDialog();
            Close();
        }
    } 
}
