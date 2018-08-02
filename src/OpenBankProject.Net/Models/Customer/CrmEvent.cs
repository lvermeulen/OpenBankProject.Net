using System;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Customer
{
    public class CrmEvent
    {
        public string Id { get; set; }
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("customer_name")]
        public string CustomerName { get; set; }
        [JsonProperty("customer_number")]
        public string CustomerNumber { get; set; }
        public string Category { get; set; }
        public string Detail { get; set; }
        public string Channel { get; set; }
        [JsonProperty("scheduled_date")]
        public DateTime? ScheduledDate { get; set; }
        [JsonProperty("actual_date")]
        public DateTime? ActualDate { get; set; }
        public string Result { get; set; }
    }
}