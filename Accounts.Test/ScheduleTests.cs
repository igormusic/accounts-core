using System;
using System.Linq;
using System.Collections.Generic;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;
using Accounts.Test;
using NUnit.Framework;

namespace Tests
{
    public class ScheduleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSchedules()
        {
            DateTime startDate = new DateTime(2013, 3, 8);
            DateTime endDate = startDate.AddYears(25);
            Calendar calendar = TestUtility.CreateEuroZoneCalendar();

            Schedule accrualSchedule = new Schedule();
            accrualSchedule.BusinessDayCalculator = calendar;
            accrualSchedule.BusinessDayCalculation = BusinessDayCalculation.AnyDay;
            accrualSchedule.StartDate = startDate;
            accrualSchedule.Interval = 1;
            accrualSchedule.Frequency = ScheduleFrequency.Daily;
            accrualSchedule.EndType = ScheduleEndType.NoEnd;

            DateTime interestStart = new DateTime(2013, 3, 31);

            Schedule interestSchedule = new Schedule();
            interestSchedule.BusinessDayCalculation = BusinessDayCalculation.AnyDay;
            interestSchedule.BusinessDayCalculator = calendar;
            interestSchedule.Frequency = ScheduleFrequency.Monthly;
            interestSchedule.EndType = ScheduleEndType.EndDate;
            interestSchedule.Interval = 1;
            interestSchedule.StartDate = interestStart;
            interestSchedule.EndDate = endDate;
            interestSchedule.IncludeDates.Add(new ScheduleDate() { Value = endDate });

            List<DateTime> accrualDates = accrualSchedule.GetAllDates(endDate);

            Assert.AreEqual(startDate, accrualDates.First());
            Assert.AreEqual(endDate, accrualDates.Last());
            Assert.AreEqual(endDate.Subtract(startDate).TotalDays + 1, accrualDates.LongCount());

            List<DateTime> interestDates = interestSchedule.GetAllDates(endDate);

            Assert.AreEqual(interestStart, interestDates.First());
            Assert.AreEqual(new DateTime(2013, 4, 30), interestDates.Skip(1).First());
            Assert.AreEqual(new DateTime(2013, 5, 31), interestDates.Skip(2).First());
            Assert.AreEqual(new DateTime(2014, 2, 28), interestDates.Skip(11).First());
            Assert.AreEqual(endDate, interestDates.Last());
        }
    }
}