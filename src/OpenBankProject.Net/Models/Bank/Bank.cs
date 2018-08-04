using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Bank
{
    public class Bank
    {
        public string Id { get; set; }
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        [JsonProperty("full_name")]
        public string FullName { get; set; }
        [JsonProperty("swift_bic")]
        public string SwiftBic { get; set; }
        [JsonProperty("national_identifier")]
        public string NationalIdentifier { get; set; }
        public string Logo { get; set; }
        [JsonProperty("logo_url")]
        public string LogoUrl { get; set; }
        public string Website { get; set; }
        [JsonProperty("website_url")]
        public string WebsiteUrl { get; set; }
        [JsonProperty("bank_routing")]
        public BankRouting BankRouting { get; set; }
    }
}
