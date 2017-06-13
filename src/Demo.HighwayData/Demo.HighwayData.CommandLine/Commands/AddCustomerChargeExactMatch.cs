using Demo.HighwayData.CommandLine.Models;
using Highway.Data;

namespace Demo.HighwayData.CommandLine.Commands
{
    public class AddCustomerChargeExactMatch : Command
    {
        private readonly CustomerChargeExactMatch _match;

        public AddCustomerChargeExactMatch(CustomerChargeExactMatch match)
        {
            _match = match;
        }

        public override void Execute(IDataContext context)
        {
            context.Add(_match);
        }
    }
}