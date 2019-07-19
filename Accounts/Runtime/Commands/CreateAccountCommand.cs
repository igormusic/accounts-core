using System.Collections.Generic;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;

namespace Accounts.Runtime.Commands
{
    public class CreateAccountCommand
    {
        public AccountType AccountType { get; set; }
        public string AccountNumber { get; set; }
        public List<string> CalendarNames { get; set; } = new List<string>();
        public Dictionary<string, DateValue> Dates { get; set; } = new Dictionary<string, DateValue>();
        public Dictionary<string, RateValue> Rates { get; set; } = new Dictionary<string, RateValue>();
        public Dictionary<string, AmountValue> Amounts { get; set; } = new Dictionary<string, AmountValue>();
        public Dictionary<string, OptionValue> Options { get; set; } = new Dictionary<string, OptionValue>();
        public Dictionary<string, Schedule> Schedules { get; set; } = new Dictionary<string, Schedule>();
    }
}
