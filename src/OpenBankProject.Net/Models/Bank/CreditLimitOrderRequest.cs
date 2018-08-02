using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class CreditLimitOrderRequest
    {
        [JsonProperty("requested_current_rate_amount1")]
        public string RequestedCurrentRateAmount1 { get; set; }
        [JsonProperty("requested_current_rate_amount2")]
        public string RequestedCurrentRateAmount2 { get; set; }
        [JsonProperty("requested_current_valid_end_date")]
        public string RequestedCurrentValidEndDate { get; set; }
        [JsonProperty("current_credit_documentation")]
        public string CurrentCreditDocumentation { get; set; }
        [JsonProperty("temporary_requested_current_amount")]
        public string TemporaryRequestedCurrentAmount { get; set; }
        [JsonProperty("requested_temporary_valid_end_date")]
        public string RequestedTemporaryValidEndDate { get; set; }
        [JsonProperty("temporary_credit_documentation")]
        public string TemporaryCreditDocumentation { get; set; }
    }
}
