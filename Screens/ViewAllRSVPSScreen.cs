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
    public partial class ViewAllRSVPSScreen : Form
    {
        EventCoordinator eCoord;
        public ViewAllRSVPSScreen()
        {
            InitializeComponent();
        }

        private void ViewAllRSVPSScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();

            txtRSVPList.Text += eCoord.reservationList();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
