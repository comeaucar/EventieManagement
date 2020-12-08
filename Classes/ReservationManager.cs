using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
    public class ReservationManager
    {
        //variables 

        private static int currentResNumber;
        private int maxReservations;
        private int numReservations;
        protected Reservation[] reservationList;


        //constructors
        public ReservationManager(int crn, int max)
        {
            currentResNumber = crn;
            maxReservations = max;
            numReservations = 0;
            reservationList = new Reservation[maxReservations];
        }

        public int getNumReservations() { return numReservations; }
        public int getMaxReservations() { return maxReservations; }

        public bool addReservation(string resDate, Event resEvent, Customer resCustomer)
        {
            if (numReservations > maxReservations) { return false; }
            Reservation res = new Reservation(currentResNumber, resDate, resEvent, resCustomer);
            currentResNumber++;
            resEvent.addAttendee(resCustomer);
            resCustomer.incrementBookings();
            reservationList[numReservations] = res;
            numReservations++;
            return true;
        }

        public bool addReservation(int resId, string resDate, Event resEvent, Customer resCustomer)
        {
            if (numReservations > maxReservations) { return false; }
            Reservation res = new Reservation(resId, resDate, resEvent, resCustomer);
            currentResNumber++;
            resEvent.addAttendee(resCustomer);
            resCustomer.incrementBookings();
            reservationList[numReservations] = res;
            numReservations++;
            return true;
        }

        //methods 
        public int findRes(int resId)
        {
            for (int i = 0; i < numReservations; i++)
            {
                if (reservationList[i].getID() == resId)
                {
                    return i;
                }
            }
            return -1;
        }

        public Reservation getReservationAtPosition(int x)
        {
            if (x < numReservations)
            {
                return reservationList[x];
            }
            return null;
        }
        public int findResByCustomer(int custId)
        {
            for (int i = 0; i < numReservations; i++)
            {
                if (reservationList[i].getCustomer().getId() == custId)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool resExists(int resId)
        {
            int loc = findRes(resId);
            if (loc == -1) { return false; }
            return true;
        }

        public bool deleteResFromList(int resId)
        {
            int loc = findRes(resId);
            if (loc == -1) { return false; }
            reservationList[loc] = reservationList[numReservations - 1];
            numReservations--;
            return true;
        }

        public bool deleteReservation(int custId)
        {
            for (int i = 0; i < getNumReservations(); i++)
            {
                if (reservationList[i].getCustomer().getId() == custId)
                {
                    deleteResFromList(reservationList[i].getID());
                    return true;
                }
            }
            return false;
        }

        public bool customerAlreadyRegistered(int custId, int eventId)
        {
            
            for(int i = 0; i < numReservations; i++)
            {
                if(reservationList[i].getCustomer().getId().Equals(custId) && reservationList[i].getEvent().getEventId().Equals(eventId))
                {
                    return true;
                }
            }
            return false;
        }

        public void deleteReservation(int custId, Customer c)
        {
            string fName, lName;

            fName = c.getFirstName();
            lName = c.getLastName();

            for (int i = 0; i < getNumReservations(); i++)
            {
                if(c.getNumBookings() > 1) {
                    for(int y = 0; y < c.getNumBookings(); y++)
                    {
                        if (reservationList[i].getCustomer().getId() == custId || (reservationList[i].getCustomer().getFirstName().Equals(fName) && reservationList[i].getCustomer().getLastName().Equals(lName)))
                        {
                            deleteResFromList(reservationList[i].getID());
                        }
                    }
                }
                else if (reservationList[i].getCustomer().getId() == custId || (reservationList[i].getCustomer().getFirstName().Equals(fName) && reservationList[i].getCustomer().getLastName().Equals(lName)))
                {
                    deleteResFromList(reservationList[i].getID());
                }
            }
  
        }

        public Reservation[] getAllReservations()
        {
            return reservationList;
        }

        public string getReservationList()
        {
            string data = "";
            

            if (numReservations == 0)
            {
                data += "No Reservations Made Yet";
                return data;
            }

            string x = "";

            for (int i = 0; i < numReservations; i++)
            {
                if(i > 0)
                {
                    x = "\r\n\r\n";
                }
                data += x + "Reservation " + reservationList[i].getID();
                data += "-----------------------------";
                data += "\r\nReservation was made at " + reservationList[i].getDate();
                data += "\r\n" + reservationList[i].getCustomer().getFirstName() + " " + reservationList[i].getCustomer().getLastName() + " is attending Event ID: " + reservationList[i].getEvent().getEventId() + " Name:" + reservationList[i].getEvent().getEventName();
            }

            return data;
        }
    }
}
