using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventieManagement
{
    public partial class RSVPOptionsScreen : Form
    {
        public RSVPOptionsScreen()
        {
            InitializeComponent();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            RSVPForEventScreen rfes = new RSVPForEventScreen();
            rfes.ShowDialog();
            
        }

        private void btnViewAllReservations_Click(object sender, EventArgs e)
        {
            ViewAllRSVPSScreen var = new ViewAllRSVPSScreen();
            var.ShowDialog();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenuScreen mms = new MainMenuScreen();
            this.Hide();
            mms.Show();
        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
