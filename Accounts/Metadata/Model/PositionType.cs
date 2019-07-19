namespace Accounts.Metadata.Model
{
    public class PositionType: NamedAbstractEntity
    {
        public PositionType() {

        }

        public PositionType(string propertyName):base(propertyName) {
            
        }

        public PositionType(string propertyName, string labelName) : base(propertyName, labelName) {

        }

        public bool IsPrincipal { get; set; } = false;
    }
}
