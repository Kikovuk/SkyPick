using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Reports : Form
    {
        private readonly SkyPickEntities _db;
        private CountriesVisitedByUser report;
        private FlightCountPerPlane report2;
        private ReservationsPerDate report3;
        private SeatReservationsPerPlaneModel report4;
        private FlightsByAirportName report5;
        public Reports()
        {
            InitializeComponent();
            _db = new SkyPickEntities();
            var airports = _db.Airport
                .OrderBy(a => a.Name)
                .ToList();

            cbAirportName.DataSource = airports;
            cbAirportName.DisplayMember = "Name";
            cbAirportName.ValueMember = "AirportID";
            cbAirportName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbAirportName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void btnCountriesVisitedByUser_Click(object sender, EventArgs e)
        {
            if (nudUserID.Value == 0)
            {
                MessageBox.Show("Morate uneti korisnički ID!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (report != null)
            {
                report.Close();
                report.Dispose();
            }

            int id = (int) nudUserID.Value;

            report = new CountriesVisitedByUser();

            report.SetParameterValue("UserID", id);

            ReportForm reportForm = new ReportForm();
            reportForm.LoadReport(report);
            reportForm.ShowDialog();
        }

        private void btnFlightCountPerPlane_Click(object sender, EventArgs e)
        {
            if (report2 != null)
            {
                report2.Close();
                report2.Dispose();
            }

            report2 = new FlightCountPerPlane();

            ReportForm reportForm = new ReportForm();
            reportForm.LoadReport(report2);
            reportForm.ShowDialog();
        }

        private void btnReservationsPerDate_Click(object sender, EventArgs e)
        {
            if (report3 != null)
            {
                report3.Close();
                report3.Dispose();
            }

            report3 = new ReservationsPerDate();

            ReportForm reportForm = new ReportForm();
            reportForm.LoadReport(report3);
            reportForm.ShowDialog();
        }

        private void btnSeatReservationsPerPlaneModel_Click(object sender, EventArgs e)
        {
            if (report4 != null)
            {
                report4.Close();
                report4.Dispose();
            }

            report4 = new SeatReservationsPerPlaneModel();

            ReportForm reportForm = new ReportForm();
            reportForm.LoadReport(report4);
            reportForm.ShowDialog();
        }

        private void btnFlightsByAirportName_Click(object sender, EventArgs e)
        {

            if (report5 != null)
            {
                report5.Close();
                report5.Dispose();
            }

            report5 = new FlightsByAirportName();

            report5.SetParameterValue("AirportName", cbAirportName.Text);

            ReportForm reportForm = new ReportForm();
            reportForm.LoadReport(report5);
            reportForm.ShowDialog();
        }

        private void pbBackArrow_Click(object sender, EventArgs e)
        {
            Hide();
            AdminMainWindow adminMainWindow = new AdminMainWindow();
            adminMainWindow.ShowDialog();
            Close();
        }
    }
}
