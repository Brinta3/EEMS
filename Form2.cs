using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace EEMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Open Form3 when Traffic Monitor is clicked
        private void btnTrafficMonitor_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); // Or use form3.ShowDialog() for modal
        }

        // Open Form4 when Control Centre is clicked
        private void btnControlCentre_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(); // Or use form4.ShowDialog() for modal
        }

        // Open Form5 when Toll Booth is clicked
        private void btnTollBooth_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show(); // Or use form5.ShowDialog() for modal
        }
        private void btnVehicle_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show(); // Use ShowDialog() if you want it to be modal
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show(); // Or use form7.ShowDialog() for modal
        }
    }
}
