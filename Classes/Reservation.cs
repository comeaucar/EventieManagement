using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
   public class Reservation
    {
        //variables that make up a reservation

        private int reservationID;
        private string reservationDate;
        private Event reservationEvent;
        private Customer reservationCustomer;

        //constructor
        public Reservation(int resID, string resDate, Event resEvent, Customer resCustomer)
        {
            this.reservationID = resID;
            this.reservationDate = resDate;
            this.reservationEvent = resEvent;
            this.reservationCustomer = resCustomer;
        }

        //getters/setters
        public int getID() { return reservationID; }
        public string getDate() { return reservationDate; }
        public Event getEvent() { return reservationEvent; }
        public Customer getCustomer() { return reservationCustomer; }

        public override string ToString()
        {
            string data = "Reservation ID: " + reservationID;
            data += "\nReservation Date: " + reservationDate;
            data += "\nReservation Event: " + reservationEvent;
            data += "\nReservation Customer: " + reservationCustomer;

            return data;
        }

    }
}
