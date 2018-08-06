using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Transaction
{
    public class Holder
    {
        public string Name { get; set; }
        [JsonProperty("is_alias")]
        public bool IsAlias { get; set; }
    }
}