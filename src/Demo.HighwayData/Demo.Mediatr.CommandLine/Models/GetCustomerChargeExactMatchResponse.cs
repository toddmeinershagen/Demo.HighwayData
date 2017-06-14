using Demo.Core.Models;
using System.Collections.Generic;

namespace Demo.Mediatr.CommandLine.Models
{
    public class GetCustomerChargeExactMatchResponse
    {
        public List<CustomerChargeExactMatch> Matches { get; set; }
    }
}
