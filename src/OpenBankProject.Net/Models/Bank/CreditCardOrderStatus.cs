using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class CreditCardOrderStatus
    {
        [JsonProperty("card_type")]
        public string CardType { get; set; }
        [JsonProperty("card_description")]
        public string CardDescription { get; set; }
        [JsonProperty("use_type")]
        public string UseType { get; set; }
    }
}
