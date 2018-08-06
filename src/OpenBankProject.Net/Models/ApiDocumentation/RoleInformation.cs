using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class RoleInformation
    {
        public string Role { get; set; }
        [JsonProperty("requires_bank_id")]
        public bool RequiresBankId { get; set; }
    }
}