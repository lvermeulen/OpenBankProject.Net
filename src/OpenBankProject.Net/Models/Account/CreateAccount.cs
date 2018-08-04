using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class CreateAccount
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public CurrencyAmount Balance { get; set; }
        [JsonProperty("branch_id")]
        public string BranchId { get; set; }
        [JsonProperty("account_routing")]
        public BankRouting AccountRouting { get; set; }
    }
}
