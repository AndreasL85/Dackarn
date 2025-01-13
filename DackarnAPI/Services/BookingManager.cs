/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
using DackarnAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackarnAPI.Services
{
    public class BookingManager
    {
        // A manager class to handle all bookings
        private List<Booking> bookings = new List<Booking>();
        public BookingManager() 
        { 

        }

        // Method to add a new booking
        public bool AddNewBooking(DateTime bookedDate,
                                  CustomerService customerService,
                                  string name, 
                                  bool premiumCustomer, 
                                  string registrationNumber, 
                                  string carBrand, 
                                  string carModel, 
                                  int carYear)
        {
            // Create a Customer object
            Customer customer = new Customer(name, premiumCustomer);
            // Set the service the customer want
            customer.Service = customerService;
            // Create a Car object
            Car car = new Car(registrationNumber, carBrand, carModel, carYear);
            // Create a Booking object
            Booking booking = new Booking(bookedDate, customer, car);

            // Add the booking to the bookings list
            bookings.Add(booking);

            return true;
        }

        public bool RemoveBooking(string bookingID)
        {
            // Remove a booking with a specific ID
            // Get the booking with the ID
            var bookingIndex = bookings.Find(booking => booking.ID == bookingID);

            // If there was no such booking, return
            if (bookingIndex == null)
            {
                return false;
            }

            // Remove the object
            bookings.Remove(bookingIndex);

            return true;
        }

        // Method to edit a booking
        public bool EditBooking(string ID, 
                                  DateTime bookedDate,
                                  CustomerService customerService,
                                  string name,
                                  bool premiumCustomer,
                                  string registrationNumber,
                                  string carBrand,
                                  string carModel,
                                  int carYear)
        {
            // Find the booking we want to edit, by specifying the ID
            var bookingIndex = bookings.Find(booking => booking.ID == ID);

            // Does the booking exist?
            if (bookingIndex == null)
            {
                return false;
            }

            // Create new customer and Car objects and fill them in
            Customer customer = new Customer(name, premiumCustomer);
            customer.Service = customerService;
            Car car = new Car(registrationNumber, carBrand, carModel, carYear);

            // Update the booking with the new information
            bookingIndex.CustomerCar = car;
            bookingIndex.BookedCustomer = customer;
            bookingIndex.BookedDate = bookedDate;
            bookingIndex.Done = false;
            return true;
        }

        // Get a booking with a specific date and time
        public Booking? GetBooking(DateTime dateTime)
        {
            foreach (var booking in bookings)
            {
                if (booking.BookedDate == dateTime)
                {
                    return booking;
                }
            }

            return null;
        }

        // Get all bookings for a specific day
        public List<Booking> GetBookingsByDate(DateTime timeAndDate)
        {
            var retList = new List<Booking>();

            foreach (var booking in bookings)
            {
                if(booking.BookedDate.Date == timeAndDate.Date)
                {
                    retList.Add(booking);
                }
            }

            return retList;
        }

        // Get all bookings
        public List<Booking> GetAllBookings() 
        {  
            return bookings; 
        }

    }
}
