namespace Accounts.Metadata.Model
{
    public class ScheduleType : NamedAbstractEntity
    {
        public string ScheduleFrequency { get; set; }
        public string ScheduleEndType { get; set; }
        public string StartDateExpression { get; set; }
        public string EndDateExpression { get; set; }
        public string NumberOfRepeatsExpression { get; set; }
        public string IntervalExpression { get; set; }
        public string IncludeDatesExpression { get; set; }
        public string ExcludeDatesExpression { get; set; }
    }
}
