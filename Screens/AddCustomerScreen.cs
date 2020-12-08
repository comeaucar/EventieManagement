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
using System.Text.RegularExpressions;

namespace EventieManagement
{
    public partial class AddCustomerScreen : Form
    {
        EventCoordinator eCoord;
        Timer t;
        
        
        public AddCustomerScreen()
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();     
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        //validate name is valid using regex
        private bool validName(string name)
        {
            var regexExpression = new Regex("^[a-zA-Z ]*$");

            if (regexExpression.IsMatch(name))
            {
                return false;
            }

            return true;
        }

        //validate phone using regex (xxx) xxx-xxxx

        private bool validPhone(string phone)
        {
            var regex = new Regex("^\\(\\d{3}\\) \\d{3}-\\d{4}$");

            if (regex.IsMatch(phone))
            {
                return false;
            }
            return true;
        }

        private void btnSubmitCustomer_Click(object sender, EventArgs e)
        {
            //timer object to create progress bar effect
            t = new Timer();

            //reset state of lables and txt boxes
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phone = txtPhoneNumber.Text;
            lblLastName.ForeColor = Color.Lavender;
            lblFirstName.ForeColor = Color.Lavender;
            lblPhoneNumber.ForeColor = Color.Lavender;

            //check if name is invalid or empty
            if (validName(firstName) || txtFirstName.Text == "")
            {
                lblFirstName.ForeColor = Color.OrangeRed;
                lblSuccess.ForeColor = Color.OrangeRed;
      
                lblSuccess.Text = "Invalid First Name";
                return;
            }

            if (validName(lastName) || txtLastName.Text == "")
            {
                lblLastName.ForeColor = Color.OrangeRed;
                lblSuccess.ForeColor = Color.OrangeRed;
            
                lblSuccess.Text = "Invalid Last Name";
                return;
            }

            if(validPhone(phone))
            {
                lblPhoneNumber.ForeColor = Color.OrangeRed;
                lblSuccess.ForeColor = Color.OrangeRed;
         
                lblSuccess.Text = "Invalid Phone Number";
                return;
            }

            //if all validations pass then pass parameters to coordinator
            if (eCoord.addCustomer(firstName, lastName, phone))
            {
                progress.Style = ProgressBarStyle.Blocks;
                progress.Value = progress.Maximum;
                lblSuccess.ForeColor = Color.SpringGreen;
                lblLastName.ForeColor = Color.SpringGreen;
                lblFirstName.ForeColor = Color.SpringGreen;
                lblPhoneNumber.ForeColor = Color.SpringGreen;
                lblSuccess.Text = "Customer Successfully Added";
                t.Interval = 2000;
                t.Tick += new EventHandler(timer_Tick);
                t.Start();
            }
            //any other reason defaults to this
            else
            {
                lblSuccess.ForeColor = Color.OrangeRed;
                lblSuccess.Text = "Customer Was Not Added";
            }
            //reset text boxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnBackToCustomerOptions_Click(object sender, EventArgs e)
        {
     
            FileUtilities.saveToFileCoordinator(eCoord);
            this.Close();
        }

        private void AddCustomerScreen_Load(object sender, EventArgs e)
        {
                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eCoord);
          
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        //when timer is done this executes
        private void timer_Tick(object sender, EventArgs e)
        {
            progress.Value = 0;
            progress.Style = ProgressBarStyle.Marquee; 
            lblLastName.ForeColor = Color.Lavender;
            lblFirstName.ForeColor = Color.Lavender;
            lblPhoneNumber.ForeColor = Color.Lavender;
            lblSuccess.Text = "";
        }

        private void aboutEventieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.Show();
        }
    }
}
