using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class AccountType
    {
        [JsonProperty("account_routing")]
        public TypedBankRouting AccountRouting { get; set; }
        [JsonProperty("branch_id")]
        public WithType BranchId { get; set; }
        public WithType Label { get; set; }
        public TypedCurrencyAmountType Balance { get; set; }
        [JsonProperty("user_id")]
        public WithType UserId { get; set; }
        public WithType Type { get; set; }
    }
}