using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
   public class CustomerManager
    {
        private static int currentCustNumber;
        private int idGenerator;
        private int maxNumCustomers;
        private int numCustomers;
        private Customer[] customerList;

        public CustomerManager(int ccn, int max)
        {
            idGenerator = ccn;
            currentCustNumber = ccn;
            maxNumCustomers = max;
            numCustomers = 0;
            customerList = new Customer[maxNumCustomers];
        }

   
        public Customer[] getCustomerListArray()
        {
            return customerList;
        }
        public int getNumCustomer()
        {
            return numCustomers;
        }

        public Customer getCustomerAtPosition(int x)
        {
            if(x < numCustomers)
            {
                return customerList[x];
            }
            return null;
        }

        //id generator will give the lowest possible ID to new customers, regardless of previous ID's that may have been deleted
        //by doing this Customer ID will never reach an Event ID
        public int generateCurrentCustNum()
        {
            if(numCustomers >= maxNumCustomers)
            {
                return -1;
            }

            for(int i = idGenerator; i < idGenerator + maxNumCustomers; i++)
            {
                if (!customerExist(i))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool addCustomer(string fn, string ln, string ph)
        {
            currentCustNumber = generateCurrentCustNum();
            if (numCustomers >= maxNumCustomers ) { return false; }
            Customer c = new Customer(currentCustNumber, fn, ln, ph);
            //currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;
            return true;
        }

        public bool addCustomer(string fn, string ln, string ph, int bookings)
        {
            currentCustNumber = generateCurrentCustNum();
            if (numCustomers >= maxNumCustomers ) { return false; }
            Customer c = new Customer(currentCustNumber, fn, ln, ph, bookings);
            //currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;
            return true;
        }

        public bool addCustomer(int custId, string fn, string ln, string ph, int bookings)
        {
            
            if (numCustomers >= maxNumCustomers) { return false; }
            Customer c = new Customer(custId, fn, ln, ph, bookings);
            currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;
            return true;
        }
      

        public int getCurrentCustNum()
        {
            return currentCustNumber;
        }

        public int findCustomer(int cid)
        {
            for (int x = 0; x < numCustomers; x++)
            {
                if (customerList[x].getId() == cid)
                    return x;
            }
            return -1;
        }

        public bool customerExist(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }
            return true;
        }

        public Customer getCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        public string getCustomerInfo(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return "There is no customer with id " + cid + "."; }
            return customerList[loc].ToString();
        }

        public bool deleteCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }

            customerList[loc] = customerList[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public Customer[] sortedCustomerList()
        {
            int numAccounts = getNumCustomer();
            Customer[] customerListSorted = getCustomerListArray();

            for (int x = 0; x < numAccounts; x++)
            {
                for (int j = 0; j < numAccounts; j++)
                {
                    if (customerListSorted[x].getId() < customerListSorted[j].getId())
                    {
                        Customer temp = customerListSorted[x];
                        customerListSorted[x] = customerListSorted[j];
                        customerListSorted[j] = temp;
                    }
                }
            }
            return customerListSorted;
        }

        public string getCustomerList()
        {
            string s = "";

            if(numCustomers == 0)
            {
                return "No Customers To Display";
            }
           
            for (int x = 0; x < numCustomers; x++)
            {
                s = s + customerList[x].getId() + " \r\t " + customerList[x].getFirstName() + " \r\t " + customerList[x].getLastName() + " \r\t " + customerList[x].getPhone() + "\r\n";
            }
            return s;
        }
    }
}
