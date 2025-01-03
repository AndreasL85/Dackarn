using DackarnAPI.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Däckarn
{
    public static class GlobalDataManager
    {
        private static int year = DateTime.Now.Year;
        private static int month = DateTime.Now.Month; 
        private static int day = DateTime.Now.Day;
        /*public static Schedule WorkSchedule = new Schedule(new DateTime(year, month, day, 8, 0, 0), // Start hour
                                  new DateTime(year, month, day, 17, 0, 0), // End hour
                                  new DateTime(year, month, day, 13, 0, 0)); // Lunch hour */

        public static Schedule? WorkSchedule;


        public static void SetSchedule()
        {
            WorkSchedule = new Schedule(new DateTime(2025, 1, 3, 8, 0, 0), // Start hour
                                  new DateTime(2025, 1, 3, 17, 0, 0), // End hour
                                  new DateTime(2025, 1, 3, 13, 0, 0)); // Lunch hour
        }

    }
}
