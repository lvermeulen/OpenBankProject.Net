using System;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Customer
{
    public class UserCustomerLink
    {
        [JsonProperty("user_customer_link_id")]
        public string UserCustomerLinkId { get; set; }
        [JsonProperty("customer_id")]
        public string CustomerId { get; set; }
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        [JsonProperty("date_inserted")]
        public DateTime? DateInserted { get; set; }
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
    }
}
