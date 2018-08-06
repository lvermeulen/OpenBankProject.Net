using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Transaction
{
    public abstract class MinimalTransactionAccountInformation : WithId
    {
        [JsonProperty("bank_routing")]
        public BankRouting BankRouting { get; set; }
        [JsonProperty("account_routings")]
        public List<BankRouting> AccountRoutings { get; set; }
    }
}