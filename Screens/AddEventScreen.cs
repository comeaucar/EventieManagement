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
    public partial class AddEventScreen : Form
    {
        EventCoordinator eCoord;
        Timer t;
        
        public AddEventScreen()
        {
            InitializeComponent();
        }

        private void btnSubmitEvent_Click(object sender, EventArgs e)
        {
            t = new Timer();
            string eventName, eventVenue;
            int maxAttendees, day, month, year, hour, minute;

            //turn datetime selector to a string
            string dateSelected = dateTimePick.Value.ToString("yyyy,M,d,H,m");
            string[] dateValues = dateSelected.Split(',');

            lblEventName.ForeColor = Color.Lavender;
            lblVenue.ForeColor = Color.Lavender;
            eventName = txtEventName.Text;
            eventVenue = txtEventVenue.Text;
            year = Convert.ToInt32(dateValues[0]);
            month = Convert.ToInt32(dateValues[1]);
            day = Convert.ToInt32(dateValues[2]);
            hour = Convert.ToInt32(dateValues[3]);
            minute = Convert.ToInt32(dateValues[4]);

            //create date object for event
            Date eventDate = new Date(day, month, year, hour, minute);

            //prevents doubles
            maxAttendees = Convert.ToInt32(Math.Round(numMaxAttend.Value, 0));

            //validations
            if(txtEventName.Text == ""){
                lblEventName.ForeColor = Color.OrangeRed;
                lblSuccess.ForeColor = Color.OrangeRed;
                lblSuccess.Text = "Invalid Event Name";
                return;
            }

            if (txtEventVenue.Text == "")
            {
                lblVenue.ForeColor = Color.OrangeRed;
                lblSuccess.ForeColor = Color.OrangeRed;
                lblSuccess.Text = "Invalid Venue Name";
                return;
            }

            if(eCoord.checkEventSameVenueSameDay(eventVenue, day, month, year))
            {
                txtEventName.Text = "";
                txtEventVenue.Text = "";
                dateTimePick.Value = DateTime.Now;
                numMaxAttend.Value = numMaxAttend.Minimum;
                lblSuccess.ForeColor = Color.OrangeRed;
                lblSuccess.Text = "There is already an event there on that day";
                return;
            }

            if (eCoord.addEvent(eventName, eventVenue, eventDate, maxAttendees))
            {

                txtEventName.Text = "";
                txtEventVenue.Text = "";
                dateTimePick.Value = DateTime.Now;
                numMaxAttend.Value = numMaxAttend.Minimum;
                progress.Style = ProgressBarStyle.Blocks;
                progress.Value = progress.Maximum;
                lblEventName.ForeColor = Color.SpringGreen;
                lblVenue.ForeColor = Color.SpringGreen;
                lblDate.ForeColor = Color.SpringGreen;
                lblMaxAttendees.ForeColor = Color.SpringGreen;
                lblSuccess.ForeColor = Color.SpringGreen;
                lblSuccess.Text = "Event Successfully Added";
                t.Interval = 2000;
                t.Tick += new EventHandler(timer_Tick);
                t.Start();
                
            }
            else
            {

                txtEventName.Text = "";
                txtEventVenue.Text = "";
                dateTimePick.Value = DateTime.Now;
                numMaxAttend.Value = numMaxAttend.Minimum;
                lblSuccess.ForeColor = Color.OrangeRed;
                lblSuccess.Text = "Event Not Added";
            }

        }

        private void dateTimePick_ValueChanged(object sender, EventArgs e)
        {
            
        }

        //loads eventcoordinator
        private void AddEventScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();
            dateTimePick.CustomFormat = "yyyy/M/d H:m";
            dateTimePick.MinDate = DateTime.Now;
            dateTimePick.ToString();
        }

        private void btnBackToEventOptions_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eCoord);
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progress.Value = 0;
            progress.Style = ProgressBarStyle.Marquee;
            lblEventName.ForeColor = Color.Lavender;
            lblVenue.ForeColor = Color.Lavender;
            lblDate.ForeColor = Color.Lavender;
            lblMaxAttendees.ForeColor = Color.Lavender;
            lblSuccess.Text = "";
        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eCoord);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
