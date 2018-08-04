using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Common
{
    public class AvailableView
    {
        public string Id { get; set; }
        [JsonProperty("short_name")]
        public string ShortName { get; set; }
        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }
    }
}