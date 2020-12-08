using System;
using System.IO;
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
    public partial class MainMenuScreen : Form
    {
        EventCoordinator eventCoord;
        CustomerManager custMan;
        ReservationManager resMan;
        EventManager eventMan;

        public MainMenuScreen()
        {     
            InitializeComponent();
        }

        private void MainMenuScreen_Load(object sender, EventArgs e)
        {
            eventMan = FileUtilities.loadFromFileEvent();
            custMan = FileUtilities.loadFromFileCustomer();
            resMan = FileUtilities.loadFromFileReservation();
            eventCoord = new EventCoordinator(custMan, eventMan, resMan);   
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileUtilities.writeToFileCustomer(custMan);
            FileUtilities.writeToFileEvent(eventMan);
            FileUtilities.writeToFileReservation(resMan);
        }

        private void btnCustomerOptions_Click(object sender, EventArgs e)
        {
            CustomerOptionsScreen cos = new CustomerOptionsScreen(eventCoord);
            this.Hide();
            cos.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEventOptions_Click(object sender, EventArgs e)
        {
            EventOptionsScreen eos = new EventOptionsScreen();
            this.Hide();
            eos.Show();
        }

        private void btnReservationOptions_Click(object sender, EventArgs e)
        {
            RSVPOptionsScreen ros = new RSVPOptionsScreen();
            this.Hide();
            ros.Show();
        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen ascreen = new AboutScreen();
            ascreen.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
