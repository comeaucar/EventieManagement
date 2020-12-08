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
    public partial class EventOptionsScreen : Form
    {
        public EventOptionsScreen()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            AddEventScreen aes = new AddEventScreen();
            aes.ShowDialog();
        }

        private void btnViewEvents_Click(object sender, EventArgs e)
        {
            ViewAllEventsScreen vaes = new ViewAllEventsScreen();
            vaes.ShowDialog();
        }

        private void btnViewSpecEvent_Click(object sender, EventArgs e)
        {
            ViewSpecEventScreen vses = new ViewSpecEventScreen();
            vses.ShowDialog();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenuScreen mms = new MainMenuScreen();
            this.Close();
            mms.Show();
        }

        private void EventOptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
