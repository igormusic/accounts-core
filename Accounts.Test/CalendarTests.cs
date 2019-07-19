using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;
using NUnit.Framework;

namespace Accounts.Test
{
    public class CalendarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SuccessNextBusinessDaySkipWeekend()
        {
            BusinessDayCalculator calendar = TestUtility.CreateEuroZoneCalendar();

            //1 Jan is Friday, therefore next working day Monday 4th Jan 2021
            DateTime nextDay =  calendar.GetCalculatedBusinessDay( new DateTime(2021,1,1), BusinessDayCalculation.NextBusinessDay);

            Assert.AreEqual(new DateTime(2021, 1, 4), nextDay);
        }

        [Test]
        public void SuccessPreviousBusinessDaySkipWeekend()
        {
            BusinessDayCalculator calendar = TestUtility.CreateEuroZoneCalendar();

            //3 Jan is Sunday, therefore previous working day Monday 31st Dec 2020
            DateTime previousDay = calendar.GetCalculatedBusinessDay(new DateTime(2021, 1, 3), BusinessDayCalculation.PreviousBusinessDay);

            Assert.AreEqual(new DateTime(2020, 12, 31), previousDay);
        }

        [Test]
        public void SuccessClosestOrNext()
        {
            BusinessDayCalculator calendar = TestUtility.CreateEuroZoneCalendar();

            //31 Dec W | 1 Jan N | 2 Jan N | 3 Jan N | 4 Jan W
            //For 2 Jan both 31 Dec and 4 Jan are same distance, hence 4 Jan as next shoud be selected
            DateTime nextDay = calendar.GetCalculatedBusinessDay(new DateTime(2021, 1, 2), BusinessDayCalculation.ClosestBusinessDayOrNext);

            Assert.AreEqual(new DateTime(2021, 1, 4), nextDay);
        }

        [Test]
        public void SuccessNextBusinessDayThisMonthOrPrevious()
        {
            BusinessDayCalculator calendar = TestUtility.CreateEuroZoneCalendar();

            //March 29th 2024 is Good Friday. Next working day is on Tuesday 2nd,
            //Therefore previous working day should be selected (28th March 2024)
            DateTime nextDay = calendar.GetCalculatedBusinessDay(new DateTime(2024, 3, 29), BusinessDayCalculation.NextBusinessDayThisMonthOrPrevious);

            Assert.AreEqual(new DateTime(2024, 3, 28), nextDay);
        }

        [Test]
        public void SuccessAnyDayNoAdjustment()
        {
            BusinessDayCalculator calendar = TestUtility.CreateEuroZoneCalendar();

            DateTime nextDay = calendar.GetCalculatedBusinessDay(new DateTime(2024, 3, 30), BusinessDayCalculation.AnyDay);

            Assert.AreEqual(new DateTime(2024, 3, 30), nextDay);
        }
    }
}
