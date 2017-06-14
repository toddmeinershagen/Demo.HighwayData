using Demo.Core.Models;
using Demo.Core.Providers;
using Demo.Mediatr.CommandLine.Providers;
using Demo.Mediatr.CommandLine.Services;
using System;
using System.Collections.Generic;

namespace Demo.Mediatr.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{typeof(Program).FullName} - Starting");

            var repository = new RepositoryProvider().GetRepository();
            //NOTE - This is an example of injecting the IRepository into a Service
            var service = new CustomerChargeService(repository);

            var charges = new List<CustomerCharge>
            {
                new CustomerCharge {ProcedureCode = "P1"},
                new CustomerCharge { ProcedureCode = "P2" },
                new CustomerCharge { ProcedureCode = "P3" }
            };
            var response = service.GetExactMatches(charges).Result;

            new DisplayProvider().DisplayMatches(response.Matches);
            Console.ReadLine();
        }
    }
}
