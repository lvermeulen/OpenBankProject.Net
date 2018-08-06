using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class GlossaryItemList : IEnumerableSource<GlossaryItem>
    {
        [JsonProperty("glossary_items")]
        public List<GlossaryItem> GlossaryItems { get; set; }
        public IEnumerable<GlossaryItem> Items => GlossaryItems;
    }
}
