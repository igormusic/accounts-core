using Accounts.Utilities;

namespace Accounts.Metadata.Model
{
    public class NamedAbstractEntity
    {
        public string PropertyName { get; set; }
        public string LabelName { get; set; }

        public NamedAbstractEntity() { }

        public NamedAbstractEntity(string propertyName) {
            PropertyName = propertyName;
            LabelName = Utility.SplitCamelCase(propertyName);
        }

        public NamedAbstractEntity(string propertyName, string labelName)
        {
            PropertyName = propertyName;
            LabelName = labelName;
        }
    }
}
