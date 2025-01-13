/*
 * Projektarbete i Objektorienterad programmering GIK299, HT24
 * 
 * Däckarn
 * 
 * Andreas Lindström
 * Ameer Abdelakhwa
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DackarnAPI.DataTypes;

namespace DackarnAPI.Services
{
    public class Booking
    {
        // Booking class

        // Unique ID for the booking
        public string ID { get; private set; }
        // Customer information of the booking
        public Customer BookedCustomer { get; internal set; }
        // Car information of the booking
        public Car CustomerCar { get; internal set; }
        // What is the booked Date
        public DateTime BookedDate { get; set; }
        // Has the service been performed yet?
        public bool Done { get; set; } = false;
        public Booking(DateTime bookedDate, Customer bookedCustomer, Car customerCar)
        {
            // Generate a unique ID for the booking.
            ID = Guid.NewGuid().ToString();
            BookedCustomer = bookedCustomer;
            CustomerCar = customerCar;
            BookedDate = bookedDate;
        }
    }
}
