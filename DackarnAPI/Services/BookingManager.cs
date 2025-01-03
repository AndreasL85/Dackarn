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

        public bool AddNewBooking(string name, 
                                  bool premiumCustomer, 
                                  string registrationNumber, 
                                  string carBrand, 
                                  string carModel, 
                                  int carYear)
        {
            Customer customer = new Customer(name, premiumCustomer);
            Car car = new Car(registrationNumber, carBrand, carModel, carYear);

            Booking booking = new Booking(customer, car);

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

        public Booking GetBooking(DateTime timeAndDate)
        {
            // TODO: return correct booking
            return bookings[0];
        }

        public List<Booking> GetAllBookings() 
        {  
            return bookings; 
        }

    }
}
