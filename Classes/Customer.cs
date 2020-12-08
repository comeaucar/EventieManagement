using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public Customer(int cId, string fname, string lname, string ph, int bookings)
        {
            this.bookings = bookings;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }

        public bool incrementBookings()
        {
            this.bookings++;
            return true;
        }

        public override string ToString()
        {
            string s = "Customer " + customerId + " \r\n " +
                "-----------------------" + "\r\n" +
            "First Name: " + firstName + " \r\n " +
            "Last Name: " + lastName + " \r\n " +
            "Phone: " + phone + " \r\n " +
            "Bookings: " + bookings + " \r\n ";

            return s;
        }

    }
}
