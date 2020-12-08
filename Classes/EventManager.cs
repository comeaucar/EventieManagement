using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventieManagement
{
    public class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;

        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];
        }

        public int getNumEvents() { return numEvents; }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            if (numEvents >= maxEvents || eventSameVenueSameDay(venue, eventDate.getDay(), eventDate.getMonth(), eventDate.getYear())) { return false; }
            if (maxAttendees == 0)
            {
                Console.WriteLine("Can not have event with 0 attendees");
                return false;
            }
            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees, int numAttendees, Customer[] attendeeList)
        {
            if (numEvents >= maxEvents || eventSameVenueSameDay(venue, eventDate.getDay(), eventDate.getMonth(), eventDate.getYear())) { return false; }
            if (maxAttendees == 0)
            {
                Console.WriteLine("Can not have event with 0 attendees");
                return false;
            }
            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees, numAttendees, attendeeList);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        public Event getEventAtPosition(int x)
        {
            if (x < numEvents)
            {
                return eventList[x];
            }
            return null;
        }

        public bool addAttendeeToEvent(Event e, Customer c)
        {
            return e.addAttendee(c);
        }

        private int findEvent(int eid)
        {
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }

        public bool eventSameVenueSameDay(string venue, int day, int month, int year)
        {
            for (int i = 0; i < getNumEvents(); i++)
            {
                if (eventList[i].getVenue().ToLower() == venue.ToLower() && eventList[i].getEventDate().getYear() == year && eventList[i].getEventDate().getMonth() == month & eventList[i].getEventDate().getDay() == day)
                {
                    return true;
                }
            }

            return false;
        }

        public void removeCustomerFromEvent(int custId)
        {

            for (int i = 0; i < getNumEvents(); i++)
            {
                if (eventList[i].findAttendee(custId) != -1)
                {
                    eventList[i].removeAttendee(custId);    
                }
            }
          
        }

        public bool removeCustomerFromEvent(Customer c)
        {
            int numBookings = c.getNumBookings();
            int custId = c.getId();

            if(numBookings > 1)
            {
                for(int i = 0; i < getNumEvents(); i++)
                {
                    for(int y = 0; y < numBookings; y++)
                    {
                        if(eventList[i].findAttendee(custId) != -1)
                        {
                            eventList[i].removeAttendee(custId);
                        }
                    }
                }
            }

            for (int i = 0; i < getNumEvents(); i++)
            {
                if (eventList[i].findAttendee(custId) != -1)
                {
                    eventList[i].removeAttendee(custId);
                    return true;
                }
            }
            return false;
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return "There is no event with id " + eid + "."; }
            return eventList[loc].ToString();
        }

        public string getEventList()
        {
            string s = "";

            if (getNumEvents() == 0)
            {
                s += "There are no events to display";
                return s;
            }

            for (int x = 0; x < numEvents; x++)
            {
                s = s + eventList[x].getEventId() + " \r\t " + eventList[x].getEventName() + "\r\t\r\t" + eventList[x].getVenue() + "\r\n";
            }
            return s;
        }

    }
}
