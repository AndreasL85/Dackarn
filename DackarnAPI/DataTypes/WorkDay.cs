using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackarnAPI.DataTypes
{
    public struct JobTimeFrame
    {
        public bool Available;
        public DateTime Time;
    }

    internal class WorkDay
    {
        public const int WORK_TIMEFRAME = 1;

        public DateTime LunchHour { get; set; }
        public DateTime WorkdayStartHour { get; set; }
        public DateTime WorkdayEndHour { get; set; }

        private List<JobTimeFrame> timeFrames = new List<JobTimeFrame>();

        public WorkDay(DateTime workdayStartHour, DateTime workdayEndHour, DateTime lunchHour)
        {
            WorkdayStartHour = workdayStartHour;
            WorkdayEndHour = workdayEndHour;
            LunchHour = lunchHour;
        }

        public List<JobTimeFrame> GetTimeFrames()
        {
            return timeFrames;
        }

        public void AddTimeFrame(DateTime timeFrame)
        {
            timeFrames.Add(new JobTimeFrame { Time = timeFrame, Available = true });
        }

        public void UpdateTimeFrame(DateTime timeFrame, bool available)
        {

        }
    }
}
