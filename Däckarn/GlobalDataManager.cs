using DackarnAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DackarnAPI.Services;

namespace Däckarn
{
    public static class GlobalDataManager
    {
        private static int year = DateTime.Now.Year;
        private static int month = DateTime.Now.Month; 
        private static int day = DateTime.Now.Day;
        public static Schedule? WorkSchedule { get; private set; }
        public static BookingManager BookingManager { get; private set; } = new BookingManager();

        public static void Initialize()
        {
            BookingManager = new BookingManager();
            WorkSchedule = new Schedule(new DateTime(year, month, day, 8, 0, 0), // Start hour
                                        new DateTime(year, month, day, 17, 0, 0), // End hour
                                        new DateTime(year, month, day, 13, 0, 0)); // Lunch hour 
        }

    }
}
