using Demo.Core.Models;
using Demo.Mediatr.CommandLine.Handlers;
using Demo.Mediatr.CommandLine.Models;
using MediatR;
using System.Linq;

namespace Demo.Mediatr.CommandLine.Providers
{
    public class RepositoryProvider
    {
        public IAsyncRequestHandler<GetCustomerChargeExactMatchRequest, GetCustomerChargeExactMatchResponse> GetRepository()
        {
            var matches = new[] {new CustomerChargeExactMatch
            {
                ProcedureCode = "P1",
                UBCode = "U1",
                HCPCS = "H1",
                Description = "P1,U1,H1",
                FacilityId = 1,
                MatchId = "1"
            },
            new CustomerChargeExactMatch
            {
                ProcedureCode = "P2",
                UBCode = "U2",
                HCPCS = "H2",
                Description = "P1,U2,H2",
                FacilityId = 1,
                MatchId = null
            },
            new CustomerChargeExactMatch
            {
                ProcedureCode = "P3",
                UBCode = "U2",
                HCPCS = "H2",
                Description = "P1,U2,H2",
                FacilityId = 1,
                MatchId = "100"
            } };

            return new GetCustomerChargeExactMatch(matches.ToList());
        }
    }
}
