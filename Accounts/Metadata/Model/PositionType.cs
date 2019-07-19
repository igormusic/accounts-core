namespace Accounts.Metadata.Model
{
    public class PositionType: NamedAbstractEntity
    {
        public PositionType() {
            IsPrincipal = false;
        }

        public bool IsPrincipal { get; set; }
    }
}
