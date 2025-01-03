using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackarnAPI.DataTypes
{
    public class Customer
    {
        public string? Name { get; set; }
        public bool PremiumCustomer { get; set; }
        public Customer(string name, bool premiumCustomer = false)
        {
            Name = name;
            PremiumCustomer = premiumCustomer;
        }
    }
}
