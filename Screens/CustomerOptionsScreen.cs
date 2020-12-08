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
    public partial class CustomerOptionsScreen : Form
    {
        

        public CustomerOptionsScreen()
        {
            InitializeComponent();
        }
        public CustomerOptionsScreen(EventCoordinator ec)
        {   
            InitializeComponent();
        }

        private void CustomerOptionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerScreen acs = new AddCustomerScreen();
            acs.ShowDialog();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            MainMenuScreen mms = new MainMenuScreen();
            this.Close();
            mms.Show();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ViewSpecCustomerScreen vscs = new ViewSpecCustomerScreen();
            vscs.ShowDialog();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            ViewAllCustomersScreen vacs = new ViewAllCustomersScreen();
            vacs.ShowDialog();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomerScreen dcs = new DeleteCustomerScreen();
            dcs.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutEventieioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutScreen aScreen = new AboutScreen();
            aScreen.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
