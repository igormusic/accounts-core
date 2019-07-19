using System;
using System.Collections.Generic;

namespace Accounts.Runtime.Model
{
    public class SavingsAccount : Account
    {

        public override void InitializePositions()
        {
            Positions.Add("Current", new Position());
            Positions.Add("InterestAccrued", new Position());
        }

        public Position Current { get => Positions["Current"]; }
        public Position InterestAccrued { get => Positions["InterestAccrued"]; }

        public override Dictionary<string, decimal> ProcessTransaction(string transactionTypeName, decimal amount)
        {

            Dictionary<string, decimal> positionMap = new Dictionary<string, decimal>();

            switch (transactionTypeName)
            {
                case "Deposit":
                    amount = Math.Round(amount, 2);
                    Current.Add(amount);
                    positionMap.Add("Current", Current.Amount);
                    break;
                case "Withdrawal":
                    amount = Math.Round(amount, 2);
                    Current.Subtract(amount);
                    positionMap.Add("Current", Current.Amount);
                    break;
                case "InterestAccrued":
                    InterestAccrued.Add(amount);
                    positionMap.Add("InterestAccrued", InterestAccrued.Amount);
                    break;
                case "InterestCapitalized":
                    InterestAccrued.Subtract(amount);
                    positionMap.Add("InterestAccrued", InterestAccrued.Amount);
                    Current.Add(amount);
                    positionMap.Add("Current", Current.Amount);
                    break;
                default:
                    throw new ArgumentException("Invalid transactionTypeName : " + transactionTypeName, "transactionTypeName");
            }

            return positionMap;
        }
    }
}
