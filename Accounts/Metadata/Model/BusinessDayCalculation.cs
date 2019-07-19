namespace Accounts.Metadata.Model
{
    public enum BusinessDayCalculation
    {
        AnyDay,
        NextBusinessDay,
        PreviousBusinessDay,
        ClosestBusinessDayOrNext,
        NextBusinessDayThisMonthOrPrevious
    }
}