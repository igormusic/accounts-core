using System.Collections.Generic;

namespace Accounts.Metadata.Model
{
    public class TransactionType : NamedAbstractEntity
    {
        public bool MaximumPrecision { get; set; } = false;
        public List<TransactionRuleType> TransactionRules { get; set; } = new List<TransactionRuleType>();

        public TransactionType(string name, bool hasMaximumPrecission):base(name)
        {
            MaximumPrecision = hasMaximumPrecission;
        }

        public TransactionType AddRule(PositionType positionType, TransactionOperation operation)
        {
            TransactionRules.Add(new TransactionRuleType(positionType, operation));

            return this;
        }
    }
}
