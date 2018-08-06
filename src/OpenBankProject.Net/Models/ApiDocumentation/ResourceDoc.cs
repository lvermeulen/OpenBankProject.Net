using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.ApiDocumentation
{
    public class ResourceDoc
    {
        [JsonProperty("operation_id")]
        public string OperationId { get; set; }
        [JsonProperty("implemented_by")]
        public VersionFunction ImplementedBy { get; set; }
        [JsonProperty("request_verb")]
        public string RequestVerb { get; set; }
        [JsonProperty("request_url")]
        public string RequestUrl { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        [JsonProperty("example_request_body")]
        public object ExampleRequestBody { get; set; }
        [JsonProperty("success_response_body")]
        public object SuccessResponseBody { get; set; }
        [JsonProperty("error_response_bodies")]
        public List<string> ErrorResponseBodies { get; set; }
        [JsonProperty("is_core")]
        public bool IsCore { get; set; }
        [JsonProperty("is_psd2")]
        public bool IsPsd2 { get; set; }
        [JsonProperty("is_obwg")]
        public bool IsObwg { get; set; }
        public List<string> Tags { get; set; }
        [JsonProperty("typed_request_body")]
        public TypedAccountType TypedRequestBody { get; set; }
        [JsonProperty("typed_success_response_body")]
        public TypedAccountType TypedSuccessResponseBody { get; set; }
        public List<RoleInformation> Roles { get; set; }
        [JsonProperty("is_featured")]
        public bool IsFeatured { get; set; }
        [JsonProperty("special_instructions")]
        public string SpecialInstructions { get; set; }
    }
}
