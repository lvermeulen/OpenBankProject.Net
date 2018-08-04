using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class AccountOwner : WithId
    {
        public string Provider { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }
}