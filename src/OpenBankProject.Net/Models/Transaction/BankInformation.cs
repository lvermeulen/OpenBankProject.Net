using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Transaction
{
    public class BankInformation
    {
        [JsonProperty("national_identifier")]
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
    }
}