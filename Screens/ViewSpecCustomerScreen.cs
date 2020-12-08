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
    public partial class ViewSpecCustomerScreen : Form
    {
        EventCoordinator eCoord;
        public ViewSpecCustomerScreen()
        {
            
            InitializeComponent();
        }

        private void ViewSpecCustomerScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();

            lblErrorMsg.Text = "";
            lblId.Text = "";
            lblFName.Text = "";
            lblLastName.Text = "";
            lblPhone.Text = "";
            lblBookings.Text = "";
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

        private void btnBackToCustomerOptions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
            lblId.Text = "";
            lblFName.Text = "";
            lblLastName.Text = "";
            lblPhone.Text = "";
            lblBookings.Text = "";

            if (!validId(txtCustomerID.Text))
            {
                txtCustomerID.Text = "";
                lblErrorMsg.Text = "Invalid ID Entered";
                lblErrorMsg.ForeColor = Color.OrangeRed;
                return;
            }

            int customerId = Convert.ToInt32(txtCustomerID.Text);
            Customer customerToFind = eCoord.getCustomerById(customerId);

            if(customerToFind == null)
            {
                lblErrorMsg.Text = "Customer Not Found";
                txtCustomerID.Text = "";
                return;
            }

            lblErrorMsg.Text = "Customer Found";
            txtCustomerID.Text = "";
            lblErrorMsg.ForeColor = Color.MediumSpringGreen;
            lblId.Text = Convert.ToString(customerToFind.getId());
            lblFName.Text = customerToFind.getFirstName();
            lblLastName.Text = customerToFind.getLastName();
            lblPhone.Text = customerToFind.getPhone();
            lblBookings.Text = Convert.ToString(customerToFind.getNumBookings());

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
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
