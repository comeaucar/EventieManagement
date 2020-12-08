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
    public partial class RSVPForEventScreen : Form
    {
        Timer t;
        EventCoordinator eventCoord;

        public RSVPForEventScreen()
        {
            InitializeComponent();
        }

        private void RSVPForEventScreen_Load(object sender, EventArgs e)
        {

            eventCoord = FileUtilities.loadFromFilesCoordinator();    
            

            txtCustList.Text = eventCoord.customerList();
            txtEventList.Text = eventCoord.eventList();
            lblSuccessMsg.Text = "";
        }

        private void btnBackToCustomerOptions_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eventCoord);
            this.Close();
        }

        //validations
        private bool validId(string name)
        {
            var regexExpression = new Regex("^[a-zA-Z ]*$");

            if (regexExpression.IsMatch(name))
            {
                return false;
            }

            return true;
        }

        private void btnSubmitCustomer_Click(object sender, EventArgs e)
        {
            int eventId, custId;
            t = new Timer();

            //specific validations give feedback to user on what went wrong
            if (!validId(txtCustId.Text))
            {
                lblSuccessMsg.Text = "Invalid Customer ID";
                lblCustomerID.ForeColor = Color.OrangeRed;
                txtCustId.Text = "";
                return;
            }

            if (!validId(txtEventId.Text))
            {
                lblSuccessMsg.Text = "Invalid Event ID";
                lblEventID.ForeColor = Color.OrangeRed;
                txtEventId.Text = "";
                return;
            }

            eventId = Convert.ToInt32(txtEventId.Text);
            custId = Convert.ToInt32(txtCustId.Text);

            if(eventCoord.customerExists(custId) && eventCoord.eventExists(eventId))
            {
                Event resEvent = eventCoord.getEvent(eventId);
                Customer resCust = eventCoord.getCustomerById(custId);

                if(resEvent.getNumAttendees() >= resEvent.getMaxAttendees())
                {
                    lblSuccessMsg.ForeColor = Color.OrangeRed;
                    lblSuccessMsg.Text = "Max Attendees Reached, Reservation Not Added";
                    return;
                }

                if(eventCoord.customerAlreadyRegistered(custId, eventId))
                {
                    lblSuccessMsg.ForeColor = Color.OrangeRed;
                    lblSuccessMsg.Text = "Customer Already Registered";
                    return;
                }

                if(eventCoord.addReservation(DateTime.Now.ToString(), resEvent, resCust))
                {
                    progress.Style = ProgressBarStyle.Blocks;
                    progress.Value = progress.Maximum;
                    lblCustomerID.ForeColor = Color.SpringGreen;
                    lblEventID.ForeColor = Color.SpringGreen;
                    lblSuccessMsg.ForeColor = Color.SpringGreen;
                    lblCustomerID.BackColor = Color.Black;
                    lblEventID.BackColor = Color.Black;
                    lblSuccessMsg.Text = "Reservation Successfully Added";
                    t.Interval = 2000;
                    t.Tick += new EventHandler(timer_Tick);
                    t.Start(); ;
                }
                else
                {
                    lblSuccessMsg.ForeColor = Color.OrangeRed;
                    lblSuccessMsg.Text = "Error Occured, Event Not Added";
                }
            }
            else
            {
                if (eventCoord.customerExists(custId))
                {
                    lblSuccessMsg.ForeColor = Color.OrangeRed;
                    lblSuccessMsg.Text = "Invalid Event ID";
                }
                else
                {
                    lblSuccessMsg.ForeColor = Color.OrangeRed;
                    lblSuccessMsg.Text = "Invalid Customer ID";
                }
            }

        }

        //when timer ends this will execute
        private void timer_Tick(object sender, EventArgs e)
        {
            progress.Value = 0;
            progress.Style = ProgressBarStyle.Marquee;
            lblCustomerID.ForeColor = Color.CornflowerBlue;
            lblEventID.ForeColor = Color.CornflowerBlue;
            lblCustomerID.BackColor = SystemColors.Control;
            lblEventID.BackColor = SystemColors.Control;
            lblSuccessMsg.Text = "";
        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eventCoord);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
