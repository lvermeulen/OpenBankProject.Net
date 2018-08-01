using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Consumer
{
    public class WithRedirectUrl
    {
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}