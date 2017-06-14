using Demo.Core.Models;
using Demo.Mediatr.CommandLine.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Mediatr.CommandLine.Handlers
{
    public class GetCustomerChargeExactMatch : IAsyncRequestHandler<GetCustomerChargeExactMatchRequest, GetCustomerChargeExactMatchResponse>
    {
        private readonly List<CustomerChargeExactMatch> _matches;

        public GetCustomerChargeExactMatch(List<CustomerChargeExactMatch> matches)
        {
            _matches = matches;
        }

        public async Task<GetCustomerChargeExactMatchResponse> Handle(GetCustomerChargeExactMatchRequest message)
        {
            return await Task.Run(() =>
            {

                var matches = message.Charges
                    .Select(charge =>
                    {
                        var result = _matches.FirstOrDefault(match => match.ProcedureCode == charge.ProcedureCode && match.MatchId != null);
                        return result ?? new CustomerChargeExactMatch(charge);
                    }).ToList();

                return new GetCustomerChargeExactMatchResponse { Matches = matches };
            });
        }
    }
}
