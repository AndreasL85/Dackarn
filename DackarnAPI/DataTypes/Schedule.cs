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
    public class Schedule
    {
        // Schedule class
        public const int MAX_DAYS_AHEAD = 14;
        List<WorkDay> workDays = new List<WorkDay>();
        WorkDay workDayTemplate;

        // First it is needed to specify which time a day start, ends and which hour is lunch hour
        public Schedule(DateTime workdayStartHour, DateTime workdayEndHour, DateTime lunchHour) 
        {
            // Create a template of a working day
            workDayTemplate = new WorkDay(workdayStartHour, workdayEndHour, lunchHour);
            // Generate a schedule based on the starting, ending and lunch hour
            workDays = GenerateSchedule();
        }

        // Return a list of JobTimeFrames for a specific day
        public List<JobTimeFrame> GetJobTimeFrames(DateTime date) 
        {
            var currentDay = workDays.Find(x => x.WorkdayStartHour.Day == date.Day);

            if(currentDay == null)
            {
                return new List<JobTimeFrame>();
            }

            return currentDay.GetTimeFrames();
        }

        // Get a list of All JobTimeFrames
        public List<JobTimeFrame> GetAllJobTimeFrames()
        {
            List<JobTimeFrame> retList = new List<JobTimeFrame>();

            foreach (var day in workDays)
            {
                retList.AddRange(day.GetTimeFrames());
            }

            return retList;
        }

        // Update a JobTimeFrame for available/unavailable
        public void UpdateJobTimeFrame(DateTime date, bool available)
        {
            foreach(var timeFrame in workDays)
            {
                timeFrame.UpdateTimeFrame(date, available);
            }

            return;
        }

        // Generate schedule method
        private List<WorkDay> GenerateSchedule()
        {
            // Create a list to that we return at the end of the method
            List<WorkDay> workdayList = new List<WorkDay>();

            // Calculate how many hours a working day is
            int totalDayHours = workDayTemplate.WorkdayEndHour.Hour - workDayTemplate.WorkdayStartHour.Hour;

            DateTime dateTime = workDayTemplate.WorkdayStartHour;

            // Loop through each day
            for (int days = 0; days < MAX_DAYS_AHEAD; days++)
            {
                // Create a new WorkDay
                WorkDay wd = new WorkDay(workDayTemplate.WorkdayStartHour, workDayTemplate.WorkdayEndHour, workDayTemplate.LunchHour);

                // Loop through each possible hour of a working day
                for (int i = 0; i < totalDayHours; i++)
                {
                    // Create a new DateTime object with the specific date and time
                    DateTime dt = new DateTime(workDayTemplate.WorkdayStartHour.Year, 
                                                workDayTemplate.WorkdayStartHour.Month, 
                                                workDayTemplate.WorkdayStartHour.Day + days, 
                                                dateTime.Hour + i, dateTime.Minute, 0);

                    // Skip lunch hour
                    if (dt.Hour == workDayTemplate.LunchHour.Hour)
                    {
                        continue;
                    }

                    // Add the generate DateTime as a JobTimeFram
                    wd.AddTimeFrame(dt);
                }

                // Add the days difference to the start, end and lunch hours
                wd.WorkdayStartHour = wd.WorkdayStartHour.AddDays(days);
                wd.WorkdayEndHour = wd.WorkdayEndHour.AddDays(days);
                wd.LunchHour = wd.LunchHour.AddDays(days);

                // Add the WorkDay to the WorkDay list.
                workdayList.Add(wd);
            }

            return workdayList;
        }
    }
}
