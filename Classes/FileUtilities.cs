using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EventieManagement
{
    //controls all reading and writing to text files
   public class FileUtilities
    {

        public static void writeToFileCustomer(CustomerManager cm)
        {
            int numCustomers = cm.getNumCustomer();
            Customer temp;
            string path;
            string fileName = "customerData.txt";

            //path is dynamic
            try
            {
                path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);
            }
            catch
            {
                path = "D://customerData.txt";
            }
            //create streamwriter to write details of manager object
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(numCustomers);
            for (int x = 0; x < numCustomers; x++)
            {
                temp = cm.getCustomerAtPosition(x);
                sw.WriteLine(temp.getId());
                sw.WriteLine(temp.getFirstName());
                sw.WriteLine(temp.getLastName());
                sw.WriteLine(temp.getPhone());
                sw.WriteLine(temp.getNumBookings());
            }
            sw.Flush();
            sw.Close();
        }

        //creates a manager object from text file
        public static CustomerManager loadFromFileCustomer()
        {
            CustomerManager cm = new CustomerManager(300,100);
            int numAccounts, custId;
            string fName, lName, phone;
            StreamReader sr;
            string fileName = "customerData.txt";
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);

            //if file already exists then create stream reader and continue
            //if file does not exists then it means it is the first run of the program
            
            if (File.Exists(path))
            {
                sr = new StreamReader(path);  
            }
            else
            {
                return cm;
            }
            
            if(sr.ReadLine() == null)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("0");
            }

            sr.DiscardBufferedData();
            sr.BaseStream.Position = 0;
            numAccounts = Convert.ToInt32(sr.ReadLine());
            for (int x = 0; x < numAccounts; x++)
            {
                custId = Convert.ToInt32(sr.ReadLine());
                fName = sr.ReadLine();
                lName = sr.ReadLine();
                phone = sr.ReadLine();

                cm.addCustomer(custId, fName, lName, phone, Convert.ToInt32(sr.ReadLine()));
            }
            sr.Close();
            return cm;
        }

        //same process is repeated for event and reservation manager

        public static void writeToFileEvent(EventManager em)
        {
            int numEvents = em.getNumEvents();
            Event temp;
            Customer[] attendeeList;
            string fileName = "eventData.txt";
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(numEvents);
            for (int x = 0; x < numEvents; x++)
            {
                temp = em.getEventAtPosition(x);
                sw.WriteLine(temp.getEventId());
                sw.WriteLine(temp.getEventName());
                sw.WriteLine(temp.getVenue());
                sw.WriteLine(temp.getEventDate().getDay());
                sw.WriteLine(temp.getEventDate().getMonth());
                sw.WriteLine(temp.getEventDate().getYear());
                sw.WriteLine(temp.getEventDate().getHour());
                sw.WriteLine(temp.getEventDate().getMinute());
                sw.WriteLine(temp.getMaxAttendees());
                sw.WriteLine(temp.getNumAttendees());

                attendeeList = temp.getAttendeeList();
                if (temp.getNumAttendees() > 0)
                {
                    for (int i = 0; i < temp.getNumAttendees(); i++)
                    {
                        sw.WriteLine(attendeeList[i].getId());
                        sw.WriteLine(attendeeList[i].getFirstName());
                        sw.WriteLine(attendeeList[i].getLastName());
                        sw.WriteLine(attendeeList[i].getPhone());
                        sw.WriteLine(attendeeList[i].getNumBookings());
                    }
                }
            }
            sw.Flush();
            sw.Close();
        }

        public static EventManager loadFromFileEvent()
        {
            EventManager em = new EventManager(400, 100);
            int numEvents, eventId, eventDay, eventMonth, eventYear, eventHour, eventMinute, eventMaxAttendees, eventNumAttendees, custId, bookings;                
            string eventName, eventVenue, fName, lName, phone;
            Date eventDate;
            StreamReader sr;
            Customer[] attendeeList;

            string fileName = "eventData.txt";
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);

            if (File.Exists(path))
            {
                sr = new StreamReader(path);
            }
            else
            {
                return em;
            }

            if (sr.ReadLine() == null)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("0");
            }

            sr.DiscardBufferedData();
            sr.BaseStream.Position = 0;
            numEvents = Convert.ToInt32(sr.ReadLine());
            for (int x = 0; x < numEvents; x++)
            {
                eventId = Convert.ToInt32(sr.ReadLine());
                eventName = sr.ReadLine();
                eventVenue = sr.ReadLine();
                eventDay = Convert.ToInt32(sr.ReadLine());
                eventMonth = Convert.ToInt32(sr.ReadLine());
                eventYear = Convert.ToInt32(sr.ReadLine());
                eventHour = Convert.ToInt32(sr.ReadLine());
                eventMinute = Convert.ToInt32(sr.ReadLine());
                eventDate = new Date(eventDay, eventMonth, eventYear, eventHour, eventMinute);
                eventMaxAttendees = Convert.ToInt32(sr.ReadLine());
                eventNumAttendees = Convert.ToInt32(sr.ReadLine());

                attendeeList = new Customer[eventMaxAttendees];

                for(int i = 0; i < eventNumAttendees; i++)
                {
                    custId = Convert.ToInt32(sr.ReadLine());
                    fName = sr.ReadLine();
                    lName = sr.ReadLine();
                    phone = sr.ReadLine();
                    bookings = Convert.ToInt32(sr.ReadLine());
                    attendeeList[i] = new Customer(custId, fName, lName, phone, bookings);
                }
   
                em.addEvent(eventName, eventVenue, eventDate, eventMaxAttendees, eventNumAttendees, attendeeList);
            }
            sr.Close();
            return em;
        }

        public static void writeToFileReservation(ReservationManager rm)
        {
            int numResos = rm.getNumReservations();
            Reservation temp;
            string fileName = "reservationData.txt";
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(numResos);
            for (int x = 0; x < numResos; x++)
            {
                temp = rm.getReservationAtPosition(x);
                sw.WriteLine(temp.getID());
                sw.WriteLine(temp.getDate());
                sw.WriteLine(temp.getEvent().getEventId());
                sw.WriteLine(temp.getEvent().getEventName());
                sw.WriteLine(temp.getEvent().getVenue());
                sw.WriteLine(temp.getEvent().getEventDate().getDay());
                sw.WriteLine(temp.getEvent().getEventDate().getMonth());
                sw.WriteLine(temp.getEvent().getEventDate().getYear());
                sw.WriteLine(temp.getEvent().getEventDate().getHour());
                sw.WriteLine(temp.getEvent().getEventDate().getMinute());
                sw.WriteLine(temp.getEvent().getMaxAttendees());
                sw.WriteLine(temp.getCustomer().getId());
                sw.WriteLine(temp.getCustomer().getFirstName());
                sw.WriteLine(temp.getCustomer().getLastName());
                sw.WriteLine(temp.getCustomer().getPhone());
                sw.WriteLine(temp.getCustomer().getNumBookings());
            }
            sw.Flush();
            sw.Close();
        }

        public static ReservationManager loadFromFileReservation()
        {
            ReservationManager rm = new ReservationManager(500, 100);
            int numResos, resoId, eventDay, eventMonth, eventYear, eventHour, eventMinute, eventMaxAttendees, eventId, custId, custBookings;
            string eventName, eventVenue, resDate, custFName, custLName, custPhone;
            Date eventDate;
            StreamReader sr;

            string fileName = "reservationData.txt";
            string path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), @"Data\", fileName);

            if (File.Exists(path))
            {
                sr = new StreamReader(path);
            }
            else
            {
                return rm;
            }

            if (sr.ReadLine() == null)
            {
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("0");
            }

            sr.DiscardBufferedData();
            sr.BaseStream.Position = 0;
            numResos = Convert.ToInt32(sr.ReadLine());
            for (int x = 0; x < numResos; x++)
            {
                resoId = Convert.ToInt32(sr.ReadLine());
                resDate = sr.ReadLine();
                eventId = Convert.ToInt32(sr.ReadLine());
                eventName = sr.ReadLine();
                eventVenue = sr.ReadLine();
                eventDay = Convert.ToInt32(sr.ReadLine());
                eventMonth = Convert.ToInt32(sr.ReadLine());
                eventYear = Convert.ToInt32(sr.ReadLine());
                eventHour = Convert.ToInt32(sr.ReadLine());
                eventMinute = Convert.ToInt32(sr.ReadLine());
                eventDate = new Date(eventDay, eventMonth, eventYear, eventHour, eventMinute);
                eventMaxAttendees = Convert.ToInt32(sr.ReadLine());
                custId = Convert.ToInt32(sr.ReadLine());
                custFName = sr.ReadLine();
                custLName = sr.ReadLine();
                custPhone = sr.ReadLine();
                custBookings = Convert.ToInt32(sr.ReadLine());
                Event resEvent = new Event(eventId, eventName, eventVenue, eventDate, eventMaxAttendees);
                Customer resCustomer = new Customer(custId, custFName, custLName, custPhone, custBookings);
                rm.addReservation(resoId, resDate, resEvent, resCustomer);
            }
            sr.Close();
            return rm;
        }

        //event coordinator is created by taking already created managers
        public static EventCoordinator loadFromFilesCoordinator()
        {
            CustomerManager custMan = FileUtilities.loadFromFileCustomer();
            EventManager eventMan = FileUtilities.loadFromFileEvent();
            ReservationManager resMan = FileUtilities.loadFromFileReservation();
            EventCoordinator eventCoord = new EventCoordinator(custMan, eventMan, resMan);

            return eventCoord;
        }

        //event coordinator saves all info by writing info to files

        public static void saveToFileCoordinator(EventCoordinator eCoord)
        {
            FileUtilities.writeToFileCustomer(eCoord.GetCustomerManager());
            FileUtilities.writeToFileEvent(eCoord.GetEventManager());
            FileUtilities.writeToFileReservation(eCoord.GetReservationManager());
        }

    }
}
