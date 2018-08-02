using System;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Customer
{
    public class CustomerSocialMediaHandle
    {
        [JsonProperty("customer_number")]
        public string CustomerNumber { get; set; }
        public string Type { get; set; }
        public string Handle { get; set; }
        [JsonProperty("date_added")]
        public DateTime? DateAdded { get; set; }
        [JsonProperty("date_activated")]
        public DateTime? DateActivated { get; set; }
    }
}
