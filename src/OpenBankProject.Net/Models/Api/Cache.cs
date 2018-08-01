using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Api
{
    public class Cache
    {
        [JsonProperty("function_name")]
        public string FunctionName { get; set; }
        [JsonProperty("ttl_in_seconds")]
        public int TtlInSeconds { get; set; }
    }
}