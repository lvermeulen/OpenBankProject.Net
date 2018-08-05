using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Customer
{
    public class CrmEventList : IEnumerableSource<CrmEvent>
    {
        [JsonProperty("crm_events")]
        public List<CrmEvent> CrmEvents { get; set; }

        public IEnumerable<CrmEvent> Items => CrmEvents;
    }
}
