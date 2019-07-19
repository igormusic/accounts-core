using System;
using System.Collections.Generic;

namespace Accounts.Runtime.Model
{
    public class Account
    {
        private BusinessDayCalculator BusinessDayCalculator;
        private DateTime ActionDate;
        private DateTime ValueDate;

        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateActivated { get; set; }
        public string AccountTypeName { get; set; }
        public List<string> CalendarNames { get; set; } = new List<string>();
        public Dictionary<string, Position> Positions { get; set; } = new Dictionary<string, Position>();
        public Dictionary<string, DateValue> Dates { get; set; } = new Dictionary<string, DateValue>();
        public Dictionary<string, RateValue> Rates { get; set; } = new Dictionary<string, RateValue>();
        public Dictionary<string, AmountValue> Amounts { get; set; } = new Dictionary<string, AmountValue>();
        public Dictionary<string, OptionValue> Options { get; set; } = new Dictionary<string, OptionValue>();
        public Dictionary<string, Schedule> Schedules { get; set; } = new Dictionary<string, Schedule>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Dictionary<string, InstalmentSet> InstalmentSets { get; set; } = new Dictionary<string, InstalmentSet>();

    }
}
