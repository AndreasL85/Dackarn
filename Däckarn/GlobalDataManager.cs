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
using DackarnAPI.Services;

namespace Däckarn
{
    // A global static class to keep track of WorkSchedule and BookingManager
    public static class GlobalDataManager
    {
        // Get the current year, month and day values
        private static int year = DateTime.Now.Year;
        private static int month = DateTime.Now.Month;
        private static int day = DateTime.Now.Day;
        public static Schedule? WorkSchedule { get; private set; }
        public static BookingManager BookingManager { get; private set; } = new BookingManager();

        public static void Initialize()
        {
            // Initialize the BookingManager and the Schedule
            BookingManager = new BookingManager();
            WorkSchedule = new Schedule(new DateTime(year, month, day, 8, 0, 0), // Start hour
                                        new DateTime(year, month, day, 17, 0, 0), // End hour
                                        new DateTime(year, month, day, 13, 0, 0)); // Lunch hour 
        }

        // Update method to say which JobTimeFrame is available/not available
        public static void UpdateSchedule(DateTime date, bool available)
        {
            if (WorkSchedule != null)
            {
                WorkSchedule.UpdateJobTimeFrame(date, available);
            }
        }
    }
}
