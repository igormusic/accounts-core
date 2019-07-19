using System.Collections.Generic;

namespace Accounts.Metadata.Model
{
    public class AccountType
    { 
        public string ClassName { get; set; }
        public string LabelName { get; set; }
        public List<PositionType> PositionTypes { get; set; }
        public List<DateType> DateTypes { get; set; }
        public List<AmountType> AmountTypes { get; set; }
        public List<RateType> RateTypes { get; set; }
        public List<OptionType> OptionTypes { get; set; }
        public List<ScheduledTransaction> ScheduledTransactions { get; set; }
        public List<TransactionType> TransactionTypes { get; set; }
        public List<ScheduleType> ScheduleTypes { get; set; }
        public List<InstalmentType> InstalmentTypes { get; set; }
    }
}
