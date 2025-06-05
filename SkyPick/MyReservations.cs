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
    public partial class MyReservations : Form
    {
        private readonly User currentUser;
        private readonly SkyPickEntities _db = new SkyPickEntities();

        public MyReservations(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            LoadReservations();
        }

        private void LoadReservations()
        {
            var reservations = (from r in _db.Reservation
                                join f in _db.Flight on r.FlightID equals f.FlightID
                                join dep in _db.Airport on f.DepartureAirportID equals dep.AirportID
                                join arr in _db.Airport on f.ArrivalAirportID equals arr.AirportID
                                join s in _db.Seat on r.SeatID equals s.SeatID
                                join sc in _db.SeatClass on s.SeatClassID equals sc.SeatClassID
                                where r.UserID == currentUser.UserID && f.DepartureTime > DateTime.Now
                                orderby f.DepartureTime
                                select new
                                {
                                    r.ReservationDate,
                                    f.FlightNumber,
                                    DepartureAirport = dep.Name,
                                    ArrivalAirport = arr.Name,
                                    f.DepartureTime,
                                    f.ArrivalTime,
                                    SeatClass = sc.Name,
                                    f.Price
                                }).ToList();

            dgvReservations.DataSource = reservations;

            if (reservations.Count == 0)
            {
                MessageBox.Show("You have no upcoming reservations.");
            }
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
