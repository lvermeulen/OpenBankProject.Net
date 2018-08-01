using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Api
{
    public class ApiConfiguration
    {
        public Akka Akka { get; set; }
        [JsonProperty("elastic_search")]
        public ElasticSearch ElasticSearch { get; set; }
        public List<Cache> Cache { get; set; }
    }
}
