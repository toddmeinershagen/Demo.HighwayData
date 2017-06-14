using Demo.Core.Models;
using MediatR;
using System.Collections.Generic;

namespace Demo.Mediatr.CommandLine.Models
{
    public class GetCustomerChargeExactMatchRequest : IRequest<GetCustomerChargeExactMatchResponse>
    {
        public List<CustomerCharge> Charges { get; set; }
    }
}
