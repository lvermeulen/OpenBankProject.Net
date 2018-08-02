using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Customer
{
    public class CrmEventList
    {
        [JsonProperty("crm_events")]
        public List<CrmEvent> CrmEvents { get; set; }
    }
}
