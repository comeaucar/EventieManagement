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
    public partial class ViewAllCustomersScreen : Form
    {
       
        EventCoordinator eventCoord;
        public ViewAllCustomersScreen()
        {
          
            InitializeComponent();
        }

        private void lblCustomerOptions_Click(object sender, EventArgs e)
        {

        }

        private void ViewAllCustomersScreen_Load(object sender, EventArgs e)
        {
            
            eventCoord = FileUtilities.loadFromFilesCoordinator();
            Customer[] customerListSorted = eventCoord.getSortedCustManArr();
            int numAccounts = eventCoord.getNumCustomers();
            

            for(int i =0 ; i < numAccounts; i++)
            {
                txtViewAllCustomers.Text += customerListSorted[i].ToString();
                txtViewAllCustomers.AppendText("\r\n");
            }

            /*
            for (int i = 0; i < numAccounts; i++)
            {
                txtViewAllCustomers.Text += eventCoord.getCustomerAtPosition(i).ToString();
                txtViewAllCustomers.AppendText("\r\n");    
            }*/
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtViewAllCustomers_TextChanged(object sender, EventArgs e)
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
