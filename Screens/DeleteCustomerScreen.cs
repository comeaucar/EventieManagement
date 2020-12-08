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
    public partial class DeleteCustomerScreen : Form
    {
        EventCoordinator eCoord;
       
        public DeleteCustomerScreen()
        {
            InitializeComponent();
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

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            lblSuccessMsg.Text = "";

            //checks for letters in id input
            if (!validId(txtCustomerID.Text))
            {
                lblSuccessMsg.ForeColor = Color.OrangeRed;
                lblSuccessMsg.Text = "Invalid ID Entered";
                txtCustomerID.Text = "";
                return;
            }

            int customerIdToDel = Convert.ToInt32(txtCustomerID.Text);

            //check if that customer id exists
            if (eCoord.customerExists(customerIdToDel))
            {
                Customer custToDel = eCoord.getCustomerById(customerIdToDel);
                lblConfirmDelete.Text = "Delete Customer " + custToDel.getId() + " (" + custToDel.getFirstName() + " " + custToDel.getLastName() + ")?";
                btnYes.Visible = true;
                btnCancel.Visible = true;
            }
            else
            {
                txtCustomerID.Text = "";
                lblSuccessMsg.Text = "Customer Not Found";
            }
        }

        //confirm delete buttons
        private void btnYes_Click(object sender, EventArgs e)
        {
            int customerIdToDel = Convert.ToInt32(txtCustomerID.Text);

            Customer custToDelete = eCoord.getCustomerById(customerIdToDel);

            eCoord.deleteReservation(customerIdToDel, custToDelete);
            eCoord.removeCustomerFromEvent(customerIdToDel);
            eCoord.deleteCustomer(customerIdToDel);

            lblSuccessMsg.ForeColor = Color.MediumSpringGreen;
            lblSuccessMsg.Text = "Customer Successfully Deleted";
            lblConfirmDelete.Text = "";
            txtCustomerID.Text = "";
            btnYes.Visible = false;
            btnCancel.Visible = false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblSuccessMsg.ForeColor = Color.Red;
            lblSuccessMsg.Text = "Delete Cancelled";
            txtCustomerID.Text = "";
            lblConfirmDelete.Text = "";
            btnYes.Visible = false;
            btnCancel.Visible = false;  
        }

        private void btnBackToCustomerOptions_Click(object sender, EventArgs e)
        {
            FileUtilities.saveToFileCoordinator(eCoord);
            this.Close();
        }

        private void DeleteCustomerScreen_Load(object sender, EventArgs e)
        {
            eCoord = FileUtilities.loadFromFilesCoordinator();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
