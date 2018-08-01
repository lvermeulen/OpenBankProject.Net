using System;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Consumer
{
    public class Consumer : WithRedirectUrl
    {
        [JsonProperty("consumer_id")]
        public int ConsumerId { get; set; }
        [JsonProperty("app_name")]
        public string AppName { get; set; }
        [JsonProperty("app_type")]
        public string AppType { get; set; }
        public string Description { get; set; }
        [JsonProperty("developer_email")]
        public string DeveloperEmail { get; set; }
        [JsonProperty("created_by_user_id")]
        public string CreatedByUserId { get; set; }
        [JsonProperty("created_by_user")]
        public Common.User CreatedByUser { get; set; }
        public bool Enabled { get; set; }
        public DateTime? Created { get; set; }
    }
}
