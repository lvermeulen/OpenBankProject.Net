using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class MessageDoc
    {
        public string Process { get; set; }
        [JsonProperty("message_format")]
        public string MessageFormat { get; set; }
        public string Description { get; set; }
        [JsonProperty("example_outbound_message")]
        public object ExampleOutboundMessage { get; set; }
        [JsonProperty("example_inbound_message")]
        public object ExampleInboundMessage { get; set; }
        public object OutboundAvroSchema { get; set; }
        public object InboundAvroSchema { get; set; }
    }
}
