using Demo.HighwayData.CommandLine.Commands;
using Demo.HighwayData.CommandLine.Models;
using Highway.Data;
using Highway.Data.Contexts;

namespace Demo.HighwayData.CommandLine.Providers
{
    public class RepositoryProvider
    {
        public IRepository GetRepository()
        {
            var context = new InMemoryDataContext();
            var repository = new Repository(context);

            repository.Execute(new AddCustomerChargeExactMatch(new CustomerChargeExactMatch
            {
                ProcedureCode = "P1",
                UBCode = "U1",
                HCPCS = "H1",
                Description = "P1,U1,H1",
                FacilityId = 1,
                MatchId = "1"
            }));

            repository.Execute(new AddCustomerChargeExactMatch(new CustomerChargeExactMatch
            {
                ProcedureCode = "P2",
                UBCode = "U2",
                HCPCS = "H2",
                Description = "P1,U2,H2",
                FacilityId = 1,
                MatchId = null
            }));

            repository.Execute(new AddCustomerChargeExactMatch(new CustomerChargeExactMatch
            {
                ProcedureCode = "P3",
                UBCode = "U2",
                HCPCS = "H2",
                Description = "P1,U2,H2",
                FacilityId = 1,
                MatchId = "100"
            }));

            repository.Context.Commit();

            return repository;
        }
    }
}