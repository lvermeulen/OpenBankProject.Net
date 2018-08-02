using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class Order
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("order_date")]
        public string OrderDate { get; set; }
        [JsonProperty("number_of_checkbooks")]
        public string NumberOfCheckbooks { get; set; }
        [JsonProperty("distribution_channel")]
        public string DistributionChannel { get; set; }
        public string Status { get; set; }
        [JsonProperty("first_check_number")]
        public string FirstCheckNumber { get; set; }
        [JsonProperty("shipping_code")]
        public string ShippingCode { get; set; }
    }
}