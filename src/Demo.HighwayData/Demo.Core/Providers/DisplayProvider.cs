using System;
using System.Collections.Generic;
using Demo.Core.Models;

namespace Demo.Core.Providers
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