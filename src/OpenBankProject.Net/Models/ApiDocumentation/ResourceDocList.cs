using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class ResourceDocList : IEnumerableSource<ResourceDoc>
    {
        [JsonProperty("resource_docs")]
        public List<ResourceDoc> ResourceDocs { get; set; }
        public IEnumerable<ResourceDoc> Items => ResourceDocs;
    }
}
