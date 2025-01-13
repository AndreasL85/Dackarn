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

namespace DackarnAPI.DataTypes
{
    // Enum for each type of Service
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
        // Customer class, contains name, PremiumCustomer, CustomerService type
        public string? Name { get; set; }
        public bool PremiumCustomer { get; set; }
        public CustomerService Service { get; set; }

        public Customer(string name, bool premiumCustomer = false)
        {
            Name = name;
            PremiumCustomer = premiumCustomer;
        }

        // Method to get a more readable string from the CustomerService enum
        public string GetCustomerServiceString()
        {
            string retString = string.Empty;

            switch (this.Service)
            {
                case CustomerService.SwitchTiresNewTires:
                    retString = "Däckbyte(Nya Däck)";
                    break;
                case CustomerService.TireHotelInclSwitch:
                    retString = "Däckhotell inkl.Hjulbyte";
                    break;
                case CustomerService.SummerToWinter:
                    retString = "Hjulbyte till Vinterdäck";
                    break;
                case CustomerService.WinterToSummer:
                    retString = "Hjulbyte till Sommardäck";
                    break;
                case CustomerService.WheelAlignment:
                    retString = "Hjulinställning";
                    break;
                default:
                    retString = "FEL: Felaktig data angivet!";
                    break;
            }

            return retString;
        }
    }
}
