using System.Collections.Generic;

namespace Accounts.Metadata.Model
{
    public class TransactionType : NamedAbstractEntity
    {
        public bool MaximumPrecision { get; set;}
        public List<TransactionRuleType> TransactionRules { get; set; }
    }
}
