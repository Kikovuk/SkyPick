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
    public partial class ManageFlights : Form
    {
        private readonly SkyPickEntities _db;
        public ManageFlights()
        {
            InitializeComponent();
            _db = new SkyPickEntities();
            gvFlightList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvFlightList.MultiSelect = false;
        }


        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            adminMainWindow.ShowDialog();
            Close();
        }

        private void btnAddNewFlight_Click(object sender, EventArgs e)
        {
            Hide();
            AddFlight addFlight = new AddFlight(this);
            addFlight.ShowDialog();
            Close();
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            if (gvFlightList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a flight to edit.");
                return;
            }

            int flightId = (int)gvFlightList.SelectedRows[0].Cells["FlightID"].Value;
            var flightToEdit = _db.Flight.Find(flightId);

            if (flightToEdit == null)
            {
                MessageBox.Show("Selected flight does not exist.");
                return;
            }
            Hide();
            EditFlight editFlight = new EditFlight(this, flightToEdit);
            editFlight.ShowDialog();
            Close();
        }

        private void btnRemoveFlight_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvFlightList.CurrentRow == null)
                {
                    MessageBox.Show("Please select a flight first.");
                    return;
                }

                var id = (int)gvFlightList.CurrentRow.Cells["FlightID"].Value;

                var flight = _db.Flight.FirstOrDefault(q => q.FlightID == id);

                _db.Flight.Remove(flight);
                _db.SaveChanges();

                MessageBox.Show($"Flight with number {flight.FlightNumber} has been deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            PopulateGrid();
        }

        private void ManageFlights_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        public void PopulateGrid()
        {
            var flights = _db.Flight.Select(q => new
            {
                q.FlightID,
                q.FlightNumber,
                Plane = q.Plane.Code + " - " + q.Plane.PlaneModel.ModelName,
                DepartureAirport = q.Airport.Code + " - " + q.Airport.Name,
                ArrivalAirport = q.Airport1.Code + " - " + q.Airport1.Name,
                q.DepartureTime,
                q.ArrivalTime,
                q.Price
            }).ToList();

            gvFlightList.DataSource = flights;
        }
    }
}
