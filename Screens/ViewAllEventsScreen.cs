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
    public partial class ViewAllEventsScreen : Form
    {
        EventCoordinator eCoord;
        public ViewAllEventsScreen()
        {
            InitializeComponent();
        }

        private void ViewAllEventsScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();
            
            for(int i = 0; i < eCoord.getNumEvents(); i++)
            {
                txtViewAllEvents.Text = eCoord.eventList();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
