﻿using System;
using Accounts.Metadata.Model;
using Accounts.Runtime.Model;

namespace Accounts.Test
{
    public class TestUtility
    {
        public static Calendar CreateEuroZoneCalendar()
        {

            return new Calendar("Euro Zone", true)
                .Add("GOOD FRIDAY", DateTime.Parse("2000-04-21"))
                .Add("EASTER MONDAY", DateTime.Parse("2000-04-24"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2000-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2000-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2000-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2001-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2001-04-13"))
                .Add("EASTER MONDAY", DateTime.Parse("2001-04-16"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2001-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2001-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2001-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2002-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2002-03-29"))
                .Add("EASTER MONDAY", DateTime.Parse("2002-04-01"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2002-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2002-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2002-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2003-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2003-04-18"))
                .Add("EASTER MONDAY", DateTime.Parse("2003-04-21"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2003-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2003-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2003-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2004-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2004-04-09"))
                .Add("EASTER MONDAY", DateTime.Parse("2004-04-12"))
                .Add("GOOD FRIDAY", DateTime.Parse("2005-03-25"))
                .Add("EASTER MONDAY", DateTime.Parse("2005-03-28"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2005-12-26"))
                .Add("GOOD FRIDAY", DateTime.Parse("2006-04-14"))
                .Add("EASTER MONDAY", DateTime.Parse("2006-04-17"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2006-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2006-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2006-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2007-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2007-04-06"))
                .Add("EASTER MONDAY", DateTime.Parse("2007-04-09"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2007-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2007-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2007-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2008-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2008-03-21"))
                .Add("EASTER MONDAY", DateTime.Parse("2008-03-24"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2008-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2008-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2008-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2009-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2009-04-10"))
                .Add("EASTER MONDAY", DateTime.Parse("2009-04-13"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2009-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2009-12-25"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2010-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2010-04-02"))
                .Add("EASTER MONDAY", DateTime.Parse("2010-04-05"))
                .Add("GOOD FRIDAY", DateTime.Parse("2011-04-22"))
                .Add("EASTER MONDAY", DateTime.Parse("2011-04-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2011-12-26"))
                .Add("GOOD FRIDAY", DateTime.Parse("2012-04-06"))
                .Add("EASTER MONDAY", DateTime.Parse("2012-04-09"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2012-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2012-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2012-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2013-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2013-03-29"))
                .Add("EASTER MONDAY", DateTime.Parse("2013-04-01"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2013-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2013-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2013-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2014-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2014-04-18"))
                .Add("EASTER MONDAY", DateTime.Parse("2014-04-21"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2014-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2014-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2014-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2015-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2015-04-03"))
                .Add("EASTER MONDAY", DateTime.Parse("2015-04-06"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2015-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2015-12-25"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2016-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2016-03-25"))
                .Add("EASTER MONDAY", DateTime.Parse("2016-03-28"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2016-12-26"))
                .Add("GOOD FRIDAY", DateTime.Parse("2017-04-14"))
                .Add("EASTER MONDAY", DateTime.Parse("2017-04-17"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2017-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2017-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2017-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2018-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2018-03-30"))
                .Add("EASTER MONDAY", DateTime.Parse("2018-04-02"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2018-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2018-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2018-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2019-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2019-04-19"))
                .Add("EASTER MONDAY", DateTime.Parse("2019-04-22"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2019-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2019-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2019-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2020-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2020-04-10"))
                .Add("EASTER MONDAY", DateTime.Parse("2020-04-13"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2020-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2020-12-25"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2021-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2021-04-02"))
                .Add("EASTER MONDAY", DateTime.Parse("2021-04-05"))
                .Add("GOOD FRIDAY", DateTime.Parse("2022-04-15"))
                .Add("EASTER MONDAY", DateTime.Parse("2022-04-18"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2022-12-26"))
                .Add("GOOD FRIDAY", DateTime.Parse("2023-04-07"))
                .Add("EASTER MONDAY", DateTime.Parse("2023-04-10"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2023-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2023-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2023-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2024-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2024-03-29"))
                .Add("EASTER MONDAY", DateTime.Parse("2024-04-01"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2024-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2024-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2024-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2025-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2025-04-18"))
                .Add("EASTER MONDAY", DateTime.Parse("2025-04-21"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2025-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2025-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2025-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2026-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2026-04-03"))
                .Add("EASTER MONDAY", DateTime.Parse("2026-04-06"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2026-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2026-12-25"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2027-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2027-03-26"))
                .Add("EASTER MONDAY", DateTime.Parse("2027-03-29"))
                .Add("GOOD FRIDAY", DateTime.Parse("2028-04-14"))
                .Add("EASTER MONDAY", DateTime.Parse("2028-04-17"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2028-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2028-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2028-12-26"))
                .Add("NEW YEARS DAY (01JAN)", DateTime.Parse("2029-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2029-03-30"))
                .Add("EASTER MONDAY", DateTime.Parse("2029-04-02"))
                .Add("LABOUR DAY (01 MAY)", DateTime.Parse("2029-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2029-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2029-12-26"))
                .Add("NEW YEARS DAY (1 JAN)", DateTime.Parse("2030-01-01"))
                .Add("GOOD FRIDAY", DateTime.Parse("2030-04-19"))
                .Add("EASTER MONDAY", DateTime.Parse("2030-04-22"))
                .Add("LABOUR DAY", DateTime.Parse("2030-05-01"))
                .Add("CHRISTMAS DAY (25 DEC)", DateTime.Parse("2030-12-25"))
                .Add("BOXING DAY (26 DEC)", DateTime.Parse("2030-12-26"));
        }

        public static AccountType CreateSavingsAccountType()
        {
            AccountType accountType = new AccountType("SavingsAccount","Savings Account");

            PositionType currentPosition = accountType.AddPositionType("Current");
            PositionType interestAccruedPosition = accountType.AddPositionType("InterestAccrued");

            TransactionType depositTransaction = accountType.AddTransactionType("Deposit", false);

            depositTransaction.AddRule(currentPosition, TransactionOperation.Add);

            TransactionType withdrawalTransaction = accountType.AddTransactionType("Withdrawal", false);

            withdrawalTransaction.AddRule(currentPosition, TransactionOperation.Subtract);

            TransactionType interestAccruedTransaction = accountType.AddTransactionType("InterestAccrued", true);

            interestAccruedTransaction.AddRule(interestAccruedPosition, TransactionOperation.Add);

            TransactionType interestCapitalizedTransaction = accountType.AddTransactionType("InterestCapitalized", false);

            interestCapitalizedTransaction.AddRule(interestAccruedPosition, TransactionOperation.Subtract);
            interestCapitalizedTransaction.AddRule(currentPosition, TransactionOperation.Add);

            return accountType;
        }
    }
}
