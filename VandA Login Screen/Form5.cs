using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VandA_Login_Screen
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnApplicationform_Click(object sender, EventArgs e)
        {
            ApplicationForm Ap = new ApplicationForm();
            Ap.ShowDialog();
            
        }

        private void btnHospitals_Click(object sender, EventArgs e)
        {
            Hospital H1 = new Hospital();
            H1.ShowDialog();
        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {
            Vacancy V1 = new Vacancy();
            V1.ShowDialog();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Bookings B1 = new Bookings();
            B1.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Employee E1 = new VandA_Login_Screen.Employee();
            E1.ShowDialog();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            Availabilities A1 = new Availabilities();
            A1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
