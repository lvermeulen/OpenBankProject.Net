using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class CreditLimitOrderStatus
    {
        [JsonProperty("rank_amount_1")]
        public string RankAmount1 { get; set; }
        [JsonProperty("nominal_interest_1")]
        public string NominalInterest1 { get; set; }
        [JsonProperty("rank_amount_2")]
        public string RankAmount2 { get; set; }
        [JsonProperty("nominal_interest_2")]
        public string NominalInterest2 { get; set; }
    }
}
