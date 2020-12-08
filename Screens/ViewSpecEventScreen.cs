using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventieManagement
{
    public partial class ViewSpecEventScreen : Form
    {
        EventCoordinator eCoord;
        public ViewSpecEventScreen()
        {
            InitializeComponent();
        }

        private void btnBackToCustomerOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validId(string name)
        {
            var regexExpression = new Regex("^[a-zA-Z ]*$");

            if (regexExpression.IsMatch(name))
            {
                return false;
            }

            return true;
        }
        private void ViewSpecEventScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();

            lblEventId.Text = "";
            lblEventName.Text = "";
            lblEventVenue.Text = "";
            lblEventDate.Text = "";
            lblRegAttend.Text = "";
            lblAvailSpace.Text = "";
            txtAttendList.Text = "";
            lblSuccessMsg.Text = "";
        }

        private void btnSearchEvent_Click(object sender, EventArgs e)
        {
            lblEventId.Text = "";
            lblEventName.Text = "";
            lblEventVenue.Text = "";
            lblEventDate.Text = "";
            lblRegAttend.Text = "";
            lblAvailSpace.Text = "";
            txtAttendList.Text = "";
            lblSuccessMsg.Text = "";

            if (!validId(txtEventID.Text))
            {
                lblSuccessMsg.Text = "Ivalid ID Entered";
                lblSuccessMsg.ForeColor = Color.OrangeRed;
                txtEventID.Text = "";
                return;
            }

            int eventId = Convert.ToInt32(txtEventID.Text);

            if (eCoord.eventExists(eventId))
            {
                Event eventFound = eCoord.getEvent(eventId);
                lblEventId.Text = Convert.ToString(eventFound.getEventId());
                lblEventName.Text = eventFound.getEventName();
                lblEventVenue.Text = eventFound.getVenue();
                lblEventDate.Text = eventFound.getEventDate().ToString();
                lblRegAttend.Text = Convert.ToString(eventFound.getNumAttendees());
                lblAvailSpace.Text = Convert.ToString(eventFound.getAvailableSpace());
                txtAttendList.Text = eventFound.getAttendees();
                lblSuccessMsg.ForeColor = Color.MediumSpringGreen;
                txtEventID.Text = "";
                lblSuccessMsg.Text = "Event Found";
            }
            else
            {
                txtEventID.Text = "";
                lblSuccessMsg.ForeColor = Color.OrangeRed;
                lblSuccessMsg.Text = "No Event Found";
            }
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
