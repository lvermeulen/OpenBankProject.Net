using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Api
{
    public class Akka
    {
        public List<PropertyValue> Ports { get; set; }
        [JsonProperty("log_level")]
        public string LogLevel { get; set; }
    }
}