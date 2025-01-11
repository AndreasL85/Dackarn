using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackarnAPI.DataTypes
{
    public enum CustomerService
    {
        SwitchTiresNewTires,
        TireHotelInclSwitch,
        SummerToWinter,
        WinterToSummer,
        WheelAlignment,
    }
    public class Customer
    {
        public string? Name { get; set; }
        public bool PremiumCustomer { get; set; }
        public CustomerService Service { get; set; }
        public Customer(string name, bool premiumCustomer = false)
        {
            Name = name;
            PremiumCustomer = premiumCustomer;
        }
    }
}
