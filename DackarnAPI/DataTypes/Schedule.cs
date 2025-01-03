using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DackarnAPI.DataTypes
{
    
    public class Schedule
    {
        public const int MAX_DAYS_AHEAD = 14;
        List<WorkDay> workDays = new List<WorkDay>();
        WorkDay workDayTemplate;

        public Schedule(DateTime workdayStartHour, DateTime workdayEndHour, DateTime lunchHour) 
        {
            workDayTemplate = new WorkDay(workdayStartHour, workdayEndHour, lunchHour);
            workDays = GenerateSchedule();
        }

        public List<JobTimeFrame> GetJobTimeFrames(DateTime date) 
        {
            var currentDay = workDays.Find(x => x.WorkdayStartHour.Day == date.Day);

            if(currentDay == null)
            {
                return new List<JobTimeFrame>();
            }

            return currentDay.GetTimeFrames();
        }

        private List<WorkDay> GenerateSchedule()
        {
            List<WorkDay> workdayList = new List<WorkDay>();

            int totalDayHours = workDayTemplate.WorkdayEndHour.Hour - workDayTemplate.WorkdayStartHour.Hour;

            DateTime dateTime = workDayTemplate.WorkdayStartHour;

            for (int days = 0; days < MAX_DAYS_AHEAD; days++)
            {
                WorkDay wd = new WorkDay(workDayTemplate.WorkdayStartHour, workDayTemplate.WorkdayEndHour, workDayTemplate.LunchHour);
                for (int i = 0; i < totalDayHours; i++)
                {
                    DateTime dt = new DateTime(workDayTemplate.WorkdayStartHour.Year, 
                                                workDayTemplate.WorkdayStartHour.Month, 
                                                workDayTemplate.WorkdayStartHour.Day + days, 
                                                dateTime.Hour + i, dateTime.Minute, 0);

                    if (dt.Hour == workDayTemplate.LunchHour.Hour)
                    {
                        continue;
                    }

                    wd.AddTimeFrame(dt);
                }
                wd.WorkdayStartHour = wd.WorkdayStartHour.AddDays(days);
                wd.WorkdayEndHour = wd.WorkdayEndHour.AddDays(days);
                wd.LunchHour = wd.LunchHour.AddDays(days);
                workdayList.Add(wd);
            }

            return workdayList;
        }
    }
}
