using Demo.Core.Models;
using System;
using System.Collections.Generic;

namespace Demo.HighwayData.CommandLine.Providers
{
    public class DisplayProvider
    {
        public void DisplayMatches(IEnumerable<CustomerChargeExactMatch> matches)
        {
            foreach (var match in matches)
            {
                if (match.MatchId == null)
                {
                    Console.WriteLine($"No match found for {match.ProcedureCode}-{match.UBCode}-{match.HCPCS}");
                }
                else
                {
                    Console.WriteLine($"{match.ProcedureCode}-{match.UBCode}-{match.HCPCS}::{match.MatchId}");
                }
            }
        }
    }
}