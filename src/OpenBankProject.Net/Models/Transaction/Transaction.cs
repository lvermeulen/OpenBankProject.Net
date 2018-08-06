using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Transaction
{
    public class Transaction : WithId
    {
        [JsonProperty("this_account")]
        public TransactionAccount ThisAccount { get; set; }
        [JsonProperty("other_account")]
        public OtherTransactionAccount OtherAccount { get; set; }
        public TransactionDetails Details { get; set; }
        public TransactionMetadata Metadata { get; set; }
    }
}
