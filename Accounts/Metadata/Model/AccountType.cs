using System;
using System.Collections.Generic;
using Accounts.Runtime.Model;

namespace Accounts.Metadata.Model
{
    public class AccountType
    { 
        public string ClassName { get; set; }
        public string LabelName { get; set; }
        public List<PositionType> PositionTypes { get; set; } = new List<PositionType>();
        public List<DateType> DateTypes { get; set; } = new List<DateType>();
        public List<AmountType> AmountTypes { get; set; } = new List<AmountType>();
        public List<RateType> RateTypes { get; set; } = new List<RateType>();
        public List<OptionType> OptionTypes { get; set; } = new List<OptionType>();
        public List<ScheduledTransaction> ScheduledTransactions { get; set; } = new List<ScheduledTransaction>();
        public List<TransactionType> TransactionTypes { get; set; } = new List<TransactionType>();
        public List<ScheduleType> ScheduleTypes { get; set; } = new List<ScheduleType>();
        public List<InstalmentType> InstalmentTypes { get; set; } = new List<InstalmentType>();

        public AccountType(string className, string labelName) {
            ClassName = className;
            LabelName = labelName;
        }

        public PositionType AddPositionType(string name)
        {
            PositionType positionType = new PositionType() { PropertyName= name };
            PositionTypes.Add(positionType);
            return positionType;
        }

        public TransactionType AddTransactionType(string name, bool hasMaximumPrecission)
        {
            TransactionType transactionType = new TransactionType(name, hasMaximumPrecission);
            TransactionTypes.Add(transactionType);
            return transactionType;
        }
    }
}
