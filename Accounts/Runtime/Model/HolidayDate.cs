using System;
namespace Accounts.Runtime.Model
{
    public class HolidayDate
    {
        public string Description { get; private set; }
        public DateTime Value { get; private set; }

        public HolidayDate(string description, DateTime value) {
            Description = description;
            Value = value;
        }
    }
}