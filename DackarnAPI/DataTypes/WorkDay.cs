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
    // JobTimeFrame
    public struct JobTimeFrame
    {
        // Is it available?
        public bool Available { get; set; }
        // What date and time does this jobs time frame represent?
        public DateTime Time { get; set; }
    }

    internal class WorkDay
    {
        // WorkDay class
        public const int WORK_TIMEFRAME = 1;

        // Properties
        public DateTime LunchHour { get; set; } = DateTime.Now;
        public DateTime WorkdayStartHour { get; set; } = DateTime.Now;
        public DateTime WorkdayEndHour { get; set; } = DateTime.Now;

        private readonly List<JobTimeFrame> timeFrames = new List<JobTimeFrame>();

        public WorkDay(DateTime workdayStartHour, DateTime workdayEndHour, DateTime lunchHour)
        {
            WorkdayStartHour = workdayStartHour;
            WorkdayEndHour = workdayEndHour;
            LunchHour = lunchHour;
        }

        // Get a list of all JobTimeFrames
        public List<JobTimeFrame> GetTimeFrames()
        {
            return timeFrames;
        }

        // Add a time frame to the list, with a specific date
        public void AddTimeFrame(DateTime timeFrame)
        {
            timeFrames.Add(new JobTimeFrame { Time = timeFrame, Available = true });
        }

        // Update a JobTimeFrame to be available/unavailable
        public void UpdateTimeFrame(DateTime timeFrame, bool available)
        {
            for(int i = 0; i < timeFrames.Count; i++) 
            {
                if(timeFrames[i].Time.Date == timeFrame.Date && timeFrames[i].Time.Hour == timeFrame.Hour)
                {
                    // Set the current timeFrame to a new JobTimeFrame
                    JobTimeFrame frame = new JobTimeFrame();
                    frame.Time = timeFrames[i].Time;
                    frame.Available = available;
                    timeFrames[i] = frame;
                    // No need to loop further, we found the entry
                    break;
                }
            }
        }
    }
}
