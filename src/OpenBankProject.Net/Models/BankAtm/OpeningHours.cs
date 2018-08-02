using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.BankAtm
{
    public class OpeningHours
    {
        [JsonProperty("opening_time")]
        public string OpeningTime { get; set; }
        [JsonProperty("closing_time")]
        public string ClosingTime { get; set; }
    }
}