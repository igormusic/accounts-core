namespace Accounts.Metadata.Model
{
    public class TransactionRuleType
    {
        public string PositionTypeName { get; set; }
        public TransactionOperation TransactionOperation { get; set; }

        public TransactionRuleType(PositionType posititonType, TransactionOperation operation)
        {
            PositionTypeName = posititonType.PropertyName;
            TransactionOperation = operation;
        }

        public string OperationName { get => TransactionOperation.ToString(); }
    }
}
