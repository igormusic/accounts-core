using System;
using Accounts.Metadata.Model;

namespace Accounts.Runtime.Model
{
    public class Position
    {

        public decimal Amount { get; set; } = 0;

        public Position(Position prototype)
        {
            this.Amount = prototype.Amount;
        }

        public void ApplyOperation(TransactionOperation operation, Decimal value)
        {
            switch (operation)
            {
                case TransactionOperation.Subtract:
                    Amount -= value;
                    break;
                case TransactionOperation.Add:
                    Amount += value;
                    break;
                default:
                    break;
            }
        }

        public decimal Add(decimal value)
        {
            decimal result = Amount + value;

            Amount = result;

            return Amount;
        }

        public decimal Subtract(decimal value)
        {
            decimal result = Amount - value;

            Amount = result;

            return Amount;
        }

    }
}
