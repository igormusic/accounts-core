namespace Accounts.Metadata.Model
{
    public class InstalmentType : NamedAbstractEntity
    {
       public ScheduledTransactionTiming Timing { get; set; } 
       public string ScheduleTypeName { get; set; }
       public string TransactionTypeName { get; set; }
       public string PositionTypeName { get; set; }
       //required for amortization calculations
       public string InterestAccruedPositionTypeName { get; set; }
       public string InterestCapitalizedPositionTypeName { get; set; }
    }
}
