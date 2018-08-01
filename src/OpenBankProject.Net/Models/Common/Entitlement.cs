using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Common
{
    public class Entitlement
    {
        [JsonProperty("entitlement_id")]
        public string EntitlementId { get; set; }
        [JsonProperty("role_name")]
        public string RoleName { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
    }
}
