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
        public string ID { get; private set; }
        public Customer BookedCustomer { get; internal set; }
        public Car CustomerCar { get; internal set; }
        public DateTime BookedDate { get; set; }
        public bool Done { get; set; } = false;
        public Booking(Customer bookedCustomer, Car customerCar)
        {
            ID = Guid.NewGuid().ToString();
            BookedCustomer = bookedCustomer;
            CustomerCar = customerCar;
        }
    }
}
