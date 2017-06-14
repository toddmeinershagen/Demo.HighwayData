using Demo.Core.Models;
using Demo.Mediatr.CommandLine.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Mediatr.CommandLine.Services
{
    public class CustomerChargeService
    {
        private readonly IAsyncRequestHandler<GetCustomerChargeExactMatchRequest, GetCustomerChargeExactMatchResponse> _repository;

        public CustomerChargeService(IAsyncRequestHandler<GetCustomerChargeExactMatchRequest, GetCustomerChargeExactMatchResponse> repository)
        {
            _repository = repository;
        }

        public async Task<GetCustomerChargeExactMatchResponse> GetExactMatches(List<CustomerCharge> charges)
        {
            //NOTE - This is an example of passing in an IQuery<T> to specify how to gather data.  This can be a normal query, OData query, or stored procedure, etc.
            return await _repository.Handle(new GetCustomerChargeExactMatchRequest { Charges = charges });
        }
    }
}
