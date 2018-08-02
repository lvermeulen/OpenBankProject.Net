using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Customer
{
    public class CustomerWithUserId : Customer
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}