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
        private List<Booking> bookings = new List<Booking>();
        public BookingManager() 
        { 

        }

        public bool AddNewBooking(DateTime bookedDate,
                                  CustomerService customerService,
                                  string name, 
                                  bool premiumCustomer, 
                                  string registrationNumber, 
                                  string carBrand, 
                                  string carModel, 
                                  int carYear)
        {
            Customer customer = new Customer(name, premiumCustomer);
            customer.Service = customerService;
            Car car = new Car(registrationNumber, carBrand, carModel, carYear);

            Booking booking = new Booking(bookedDate, customer, car);

            bookings.Add(booking);

            return true;
        }

        public bool RemoveBooking(string bookingID)
        {
            var bookingIndex = bookings.Find(booking => booking.ID == bookingID);

            if (bookingIndex == null)
            {
                return false;
            }

            bookings.Remove(bookingIndex);

            return true;
        }

        public bool EditBooking(string bookingID,
                                DateTime bookedDate,
                                string name,
                                bool premiumCustomer,
                                string registrationNumber,
                                string carBrand,
                                string carModel,
                                int carYear)
        {
            var bookingIndex = bookings.Find(booking => booking.ID == bookingID);

            if (bookingIndex == null)
            {
                return false;
            }

            Customer customer = new Customer(name, premiumCustomer);
            Car car = new Car(registrationNumber, carBrand, carModel, carYear);

            bookingIndex.CustomerCar = car;
            bookingIndex.BookedCustomer = customer;
            bookingIndex.BookedDate = bookedDate;

            return true;
        }

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

        public List<Booking> GetAllBookings() 
        {  
            return bookings; 
        }

    }
}
