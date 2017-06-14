using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.HighwayData.CommandLine.Queries;
using Highway.Data;
using Demo.Core.Models;

namespace Demo.HighwayData.CommandLine.Services
{
    public class CustomerChargeService
    {
        private readonly IRepository _repository;

        public CustomerChargeService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<CustomerChargeExactMatch>> GetExactMatches(List<CustomerCharge> charges)
        {
            //NOTE - This is an example of passing in an IQuery<T> to specify how to gather data.  This can be a normal query, OData query, or stored procedure, etc.
            return await _repository.FindAsync(new ExactMatchesForCustomerCharges(charges));
        }
    }
}