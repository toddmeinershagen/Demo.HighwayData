﻿using System;
using System.Collections.Generic;
using Demo.HighwayData.CommandLine.Providers;
using Demo.HighwayData.CommandLine.Services;
using Demo.Core.Models;

namespace Demo.HighwayData.CommandLine
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
            var matches = service.GetExactMatches(charges).Result;

            new DisplayProvider().DisplayMatches(matches);
            Console.ReadLine();
        }
    }
}
