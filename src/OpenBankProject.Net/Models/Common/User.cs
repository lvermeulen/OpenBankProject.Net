using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Common
{
    public class User
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        public string Email { get; set; }
        [JsonProperty("provider_id")]
        public string ProviderId { get; set; }
        public string Provider { get; set; }
        public string Username { get; set; }
        public EntitlementList Entitlements { get; set; }
    }
}
