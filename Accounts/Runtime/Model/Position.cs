using System;
using Accounts.Metadata.Model;

namespace Accounts.Runtime.Model
{
    public class Position
    {

        public decimal Amount { get; set; } = 0;

        public Position() { }

        public Position(Position prototype)
        {
            this.Amount = prototype.Amount;
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
