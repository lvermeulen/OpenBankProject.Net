using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Transaction
{
    public class TransactionMetadata
    {
        public string Narrative { get; set; }
        public List<DatedIdValue> Comments { get; set; }
        public List<DatedIdValue> Tags { get; set; }
        public List<Image> Images { get; set; }
        public LocationInformation Where { get; set; }
    }
}