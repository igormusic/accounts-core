using System;
using System.Collections.Generic;
using System.Linq;
using Accounts.Metadata.Model;

namespace Accounts.Runtime.Model
{
    public class Schedule
    {
        //should be transient
        public BusinessDayCalculator BusinessDayCalculator;
        private Dictionary<DateTime, List<DateTime>> cachedDates = new Dictionary<DateTime, List<DateTime>>();

        public DateTime StartDate { get; set; }
        public ScheduleEndType EndType { get; set; }
        public ScheduleFrequency Frequency { get; set; }
        public DateTime EndDate { get; set; }
        public int Interval { get; set; }
        public int NumberOfRepeats { get; set; }
        public BusinessDayCalculation BusinessDayCalculation { get; set; }
        public List<ScheduleDate> IncludeDates { get; set; } = new List<ScheduleDate>();
        public List<ScheduleDate> ExcludeDates { get; set; } = new List<ScheduleDate>();

        public Schedule() {

        }

        public Schedule(Schedule prototype)
        {
            this.StartDate = prototype.StartDate;
            this.EndDate = prototype.EndDate;
            this.EndType = prototype.EndType;

            this.Frequency = prototype.Frequency;
            this.Interval = prototype.Interval;

            this.NumberOfRepeats = prototype.NumberOfRepeats;
            this.BusinessDayCalculation = prototype.BusinessDayCalculation;

            this.IncludeDates = new List<ScheduleDate>(prototype.IncludeDates);
            this.ExcludeDates = new List<ScheduleDate>(prototype.ExcludeDates);
        }

        
        public Boolean IsDue(DateTime date)
        {
            if (IsSimpleDailySchedule())
            {
                if (EndType == ScheduleEndType.NoEnd)
                {
                    return date >= StartDate;
                }
                else if (EndType == ScheduleEndType.EndDate)
                {
                    return (date >= StartDate) &&
                            (date <= EndDate);
                }
            }

            List<DateTime> dates = GetAllDates(LastPossibleDate());

            return dates.Contains(date);
        }

        //get next fifty years of dates assuming no schedule will be longer than that
        private DateTime LastPossibleDate()
        {
            return StartDate.AddYears(50);
        }

        private Boolean IsSimpleDailySchedule()
        {
            return this.Frequency == ScheduleFrequency.Daily
                    && this.Interval == 1 &&
                    this.BusinessDayCalculation == BusinessDayCalculation.AnyDay;
        }

        public Boolean IsDue()
        {
            return IsDue(SessionState.Current.ValueDate);
        }

        public List<DateTime> GetAllDates()
        {
            return GetAllDates(LastPossibleDate());
        }

        public List<DateTime> GetAllDates(DateTime toDate)
        {
            if (cachedDates.ContainsKey(toDate))
                return cachedDates[toDate];

            HashSet<DateTime> dates = new HashSet<DateTime>();

            int repeats = 1;
            DateTime iterator = StartDate;
            DateTime adjustedDate = BusinessDayCalculator.GetCalculatedBusinessDay(iterator, this.BusinessDayCalculation);

            while (!IsCompleted(repeats, adjustedDate, toDate))
            {
                dates.Add(adjustedDate);

                iterator = GetNextDate(repeats, iterator);

                adjustedDate = BusinessDayCalculator.GetCalculatedBusinessDay(iterator, this.BusinessDayCalculation);

                repeats++;
            }

            foreach (ScheduleDate includeDate in this.IncludeDates)
            {
                if (!dates.Contains(includeDate.Value))
                {
                    dates.Add(includeDate.Value);
                }

            }

            foreach (ScheduleDate excludeDate in this.ExcludeDates)
            {
                if (dates.Contains(excludeDate.Value))
                {
                    dates.Remove(excludeDate.Value);
                }
            }

            List<DateTime> sortedDates = dates.OrderBy(d => d).ToList();
            cachedDates[toDate]= sortedDates;

            return sortedDates;
        }

        private DateTime GetNextDate(int repeats, DateTime iterator)
        {
            if (this.Frequency == ScheduleFrequency.Daily)
            {
                iterator = StartDate.AddDays(Interval * repeats);
            }
            else
            {
                iterator = StartDate.AddMonths(Interval * repeats);
            }

            return iterator;
        }

        private Boolean IsCompleted(int repeats, DateTime lastDate, DateTime endDate)
        {
            if (lastDate>endDate)
            {
                return true;
            }

            if (this.EndType==ScheduleEndType.EndDate && lastDate>endDate)
            {
                return true;
            }


            if (this.EndType == ScheduleEndType.NoEnd)
            {
                return false;
            }

            if (this.EndType == ScheduleEndType.Repeats &&
                    repeats > this.NumberOfRepeats)
            {
                return true;
            }

            return lastDate> this.EndDate;
        }
    }
}
