using System.Collections.Generic;
using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Bank
{
    public class TransactionTypeRequestList
    {
        [JsonProperty("transaction_types")]
        public List<TransactionTypeRequest> TransactionTypes { get; set; }
    }
}
