using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Transaction
{
    public class TransactionAccountMetadata
    {
        [JsonProperty("public_alias")]
        public string PublicAlias { get; set; }
        [JsonProperty("private_alias")]
        public string PrivateAlias { get; set; }
        [JsonProperty("more_info")]
        public string MoreInfo { get; set; }
        [JsonProperty("URL")]
        public string Url { get; set; }
        [JsonProperty("image_URL")]
        public string ImageUrl { get; set; }
        [JsonProperty("open_corporates_URL")]
        public string OpenCorporatesUrl { get; set; }
        [JsonProperty("corporate_location")]
        public LocationInformation CorporateLocation { get; set; }
        [JsonProperty("physical_location")]
        public LocationInformation PhysicalLocation { get; set; }
    }
}