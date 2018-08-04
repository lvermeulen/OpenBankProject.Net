using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class Account : BankAccount
    {
        public string Label { get; set; }
        public List<AccountOwner> Owners { get; set; }
        public string Type { get; set; }
        public CurrencyAmount Balance { get; set; }
        [JsonProperty("account_rules")]
        public List<AccountRules> AccountRules { get; set; }
    }
}
