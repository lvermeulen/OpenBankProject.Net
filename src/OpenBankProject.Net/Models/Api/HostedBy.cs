using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Api
{
    public class HostedBy
    {
        public string Organisation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [JsonProperty("organisation_website")]
        public string OrganisationWebsite { get; set; }
    }
}