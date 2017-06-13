namespace Demo.HighwayData.CommandLine.Models
{
    public class CustomerChargeExactMatch : CustomerCharge
    {
        public CustomerChargeExactMatch()
        { }

        public CustomerChargeExactMatch(CustomerCharge charge)
        {
            ProcedureCode = charge.ProcedureCode;
            UBCode = charge.UBCode;
            HCPCS = charge.HCPCS;
            Description = charge.Description;
            FacilityId = charge.FacilityId;
            MatchId = null;
        }

        public string MatchId { get; set; }
    }
}