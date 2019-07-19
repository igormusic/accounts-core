using System;
using System.Collections.Generic;
using System.Linq;
using Accounts.Metadata.Model;

namespace Accounts.Runtime.Model
{
    public class Calendar : BusinessDayCalculator
    {
        private Dictionary<DateTime, HolidayDate> holidaysMap;

        public string Name { get; set; }

        private bool IsDefault { get; set; }

        private List<HolidayDate> Holidays { get; set; } = new List<HolidayDate>();


        public Calendar(String name, Boolean isDefault)
        {

            this.Name = name;
            this.IsDefault = isDefault;
        }


        public Calendar Add(String descrption, DateTime date)
        {
            Holidays.Add(new HolidayDate(descrption, date));
            return this;
        }

        public Boolean IsBusinessDay(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            return (HolidaysMap().ContainsKey(date) == false);
        }

        protected Dictionary<DateTime, HolidayDate> HolidaysMap()
        {

            if (holidaysMap == null)
            {
                holidaysMap = Holidays.ToDictionary(hd => hd.Value, hd => hd);
            }

            return holidaysMap;
        }

        public DateTime GetCalculatedBusinessDay(DateTime date, BusinessDayCalculation adjsutment)
        {
            if (adjsutment == BusinessDayCalculation.AnyDay)
            {
                return date;
            }

            if (adjsutment == BusinessDayCalculation.PreviousBusinessDay)
            {
                return GetPreviousBusinessDay(date);
            }

            if (adjsutment == BusinessDayCalculation.NextBusinessDay)
            {
                return GetNextBusinessDay(date);
            }

            DateTime previousBusinessDay = GetPreviousBusinessDay(date);
            DateTime nextBusinessDay = GetNextBusinessDay(date);

            if (adjsutment == BusinessDayCalculation.ClosestBusinessDayOrNext)
            {
                if (date.Subtract(previousBusinessDay).Days > nextBusinessDay.Subtract(date).Days)
                {
                    return nextBusinessDay;
                }
                else if (date.Subtract(previousBusinessDay).Days < nextBusinessDay.Subtract(date).Days)
                {
                    return previousBusinessDay;
                }
                else
                {
                    return nextBusinessDay;
                }
            }

            //last option is NextBusinessDayThisMonthOrPrevious

            if (nextBusinessDay.Month == date.Month)
            {
                return nextBusinessDay;
            }

            return previousBusinessDay;

        }

        public DateTime GetPreviousBusinessDay(DateTime date)
        {
            while (!IsBusinessDay(date))
            {
                date = date.AddDays(-1);
            }

            return date;
        }

        public DateTime GetNextBusinessDay(DateTime date)
        {
            while (!IsBusinessDay(date))
            {
                date = date.AddDays(1);
            }

            return date;
        }
    }
}
