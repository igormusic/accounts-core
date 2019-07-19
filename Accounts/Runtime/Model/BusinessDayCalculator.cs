using System;
using Accounts.Metadata.Model;

namespace Accounts.Runtime.Model
{
    public interface BusinessDayCalculator
    {
        DateTime GetCalculatedBusinessDay(DateTime date, BusinessDayCalculation calculation);
    }
}
