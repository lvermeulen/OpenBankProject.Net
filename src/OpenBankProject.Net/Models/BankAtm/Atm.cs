using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.BankAtm
{
    public class Atm
    {
        public string Id { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Location Location { get; set; }
        public Meta Meta { get; set; }
        public OpeningHours Monday { get; set; }
        public OpeningHours Tuesday { get; set; }
        public OpeningHours Wednesday { get; set; }
        public OpeningHours Thursday { get; set; }
        public OpeningHours Friday { get; set; }
        public OpeningHours Saturday { get; set; }
        public OpeningHours Sunday { get; set; }
        [JsonProperty("is_accessible")]
        public string IsAccessible { get; set; }
        [JsonProperty("located_at")]
        public string LocatedAt { get; set; }
        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }
        [JsonProperty("has_deposit_capability")]
        public string HasDepositCapability { get; set; }
    }
}
