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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblHospitalName4_Click(object sender, EventArgs e)
        {

        }

        private void lblHospitalName3_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nursingPlacementApplicationDataSet6.CandidatesInformation' table. You can move, or remove it, as needed.
            this.candidatesInformationTableAdapter1.Fill(this.nursingPlacementApplicationDataSet6.CandidatesInformation);
            // TODO: This line of code loads data into the 'nursingPlacementApplicationDataSet1.CandidatesInformation' table. You can move, or remove it, as needed.
            this.candidatesInformationTableAdapter.Fill(this.nursingPlacementApplicationDataSet1.CandidatesInformation);

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnit3_Click(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUnit4_Click(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDuration3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void lblDuration4_Click(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void candidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hospitalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vacanciesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }

        private void gbxPersonalDetails_Enter(object sender, EventArgs e)
        {

        }
    }
}
