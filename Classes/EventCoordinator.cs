using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        ReservationManager resMan;

        public EventCoordinator(CustomerManager custMan, int eventIdSeed, int maxEvents, int resIdSeed, int maxRes)
        {
            this.custMan = custMan;
            this.eventMan = new EventManager(eventIdSeed, maxEvents);
            this.resMan = new ReservationManager(resIdSeed, maxRes);
        }

        public EventCoordinator(CustomerManager custMan, EventManager eventMan, ReservationManager resMan)
        {
            this.custMan = custMan;
            this.eventMan = eventMan;
            this.resMan = resMan;
        }

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int resIdSeed, int maxRes)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            resMan = new ReservationManager(resIdSeed, maxRes);
        }

        public CustomerManager GetCustomerManager()
        {
            return custMan;
        }

        public EventManager GetEventManager()
        {
            return eventMan;
        }

        public ReservationManager GetReservationManager()
        {
            return resMan;
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public int getNumCustomers()
        {
            return custMan.getNumCustomer();
        }

        public Customer getCustomerAtPosition(int x)
        {
            return custMan.getCustomerAtPosition(x);
        }

        public string customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }

        public Customer getCustomerById(int id)
        {
            return custMan.getCustomer(id);
        }
        public bool deleteCustomer(int id)
        {
            return custMan.deleteCustomer(id);
        }

        public bool customerExists(int id)
        {
            return custMan.customerExist(id);
        }

        public Customer[] getSortedCustManArr()
        {
            return custMan.sortedCustomerList();
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate, int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        public bool checkEventSameVenueSameDay(string venue, int day, int month, int year)
        {
            return eventMan.eventSameVenueSameDay(venue, day, month, year);
        }

        public int getNumEvents()
        {
            return eventMan.getNumEvents();
        }

        public bool eventExists(int eventId)
        {
            return eventMan.eventExists(eventId);
        }

        public Event getEvent(int eventId)
        {
            return eventMan.getEvent(eventId);
        }

        public bool removeCustomerFromEvent(Customer cust)
        {
            return eventMan.removeCustomerFromEvent(cust);
        }

        //Reservation related methods
        public void deleteReservation(int custId, Customer cusToDel)
        {
            resMan.deleteReservation(custId, cusToDel);
        }
        
        public void removeCustomerFromEvent(int custId)
        {
             eventMan.removeCustomerFromEvent(custId);
        }

        public string reservationList()
        {
            return resMan.getReservationList();
        }

        public bool customerAlreadyRegistered(int custId, int eventId)
        {
            return resMan.customerAlreadyRegistered(custId, eventId);
        }

        public bool addReservation(string currTime, Event resEvent, Customer resCust)
        {
            return resMan.addReservation(currTime, resEvent, resCust);
        }

        //reserve customer to event
        public string reserveCustomerToEvent(string currTime, int customerID, int eventID)
        {
            Event currentEvent;
            Customer currCustomer;
            if (custMan.customerExist(customerID) && eventMan.eventExists(eventID))
            {
                currentEvent = eventMan.getEvent(eventID);
                currCustomer = custMan.getCustomer(customerID);

                if (currentEvent.getNumAttendees() == currentEvent.getMaxAttendees())
                {
                    return "Max Attendees Reached! Reservation was unsuccessful";
                }

                if (currentEvent.getNumAttendees() != 0)
                {
                    if (currentEvent.findAttendee(customerID) == -1)
                    {
                        resMan.addReservation(currTime, currentEvent, currCustomer);
                        return "Reservation Successfully Added.";
                    }
                }
                else
                {
                    resMan.addReservation(currTime, currentEvent, currCustomer);
                    return "Reservation Successfully Added.";
                }
            }
            return "Booking was Unsuccessful.";
        }
    }
}
