using System.Collections.Generic;
using System.Linq;
using Demo.HighwayData.CommandLine.Models;
using Highway.Data;

namespace Demo.HighwayData.CommandLine.Queries
{
    public class ExactMatchesForCustomerCharges : Query<CustomerChargeExactMatch>
    {
        private readonly List<CustomerCharge> _charges;

        public ExactMatchesForCustomerCharges(List<CustomerCharge> charges)
        {
            _charges = charges;
        }

        public override IEnumerable<CustomerChargeExactMatch> Execute(IDataContext context)
        {
            var matches = context.AsQueryable<CustomerChargeExactMatch>();
            return _charges
                .Select(c =>
                {
                    var result = matches.FirstOrDefault(charge => charge.ProcedureCode == c.ProcedureCode && charge.MatchId != null);
                    return result ?? new CustomerChargeExactMatch(c);
                })
                .AsQueryable();
        }
    }
}