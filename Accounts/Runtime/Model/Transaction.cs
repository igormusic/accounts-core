using System;
using System.Collections.Generic;

namespace Accounts.Runtime.Model
{
    public class Transaction
    {
        public string TransactionTypeName { get; set; }
        public decimal Amount { get; set; }
        public DateTime ActionDate { get; set; }
        public DateTime ValueDate { get; set; }
        public Dictionary<string, Decimal> Positions = new Dictionary<string, decimal>();

        public Transaction(string transactionTypeName, decimal amount, DateTime actionDate, DateTime valueDate)
        {
            TransactionTypeName = transactionTypeName;
            Amount = amount;
            ActionDate = actionDate;
            ValueDate = valueDate;
        }
    }
}
