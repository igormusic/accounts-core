namespace Accounts.Metadata.Model
{
    public class ScheduledTransaction : NamedAbstractEntity
    {
        public ScheduledTransactionTiming Timing { get; set; }
        public string ScheduleTypeName { get; set; }
        public string DateTypeName { get; set; }
        public string TransactionTypeName { get; set; }
        public string AmountExpression { get; set; }
        public byte Sequence { get; set; }
    }
}
