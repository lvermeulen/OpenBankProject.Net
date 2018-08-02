using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Bank
{
    public class TransactionTypeRequest
    {
        public WithValue Id { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("short_code")]
        public string ShortCode { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public CurrencyAmount Charge { get; set; }
    }
}
