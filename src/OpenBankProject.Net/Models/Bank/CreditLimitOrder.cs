using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class CreditLimitOrder
    {
        [JsonProperty("execution_time")]
        public string ExecutionTime { get; set; }
        [JsonProperty("execution_date")]
        public string ExecutionDate { get; set; }
        public string Token { get; set; }
        [JsonProperty("short_reference")]
        public string ShortReference { get; set; }
    }
}
