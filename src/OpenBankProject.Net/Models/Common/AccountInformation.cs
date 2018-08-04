using System.Collections.Generic;
using Newtonsoft.Json;
using OpenBankProject.Net.Models.Bank;

namespace OpenBankProject.Net.Models.Common
{
    public class AccountInformation
    {
        [JsonProperty("bank_id")]
        public string BankId { get; set; }
        [JsonProperty("account_id")]
        public string AccountId { get; set; }
        [JsonProperty("account_type")]
        public string AccountType { get; set; }
        [JsonProperty("account_routings")]
        public List<BankRouting> AccountRoutings { get; set; }
        [JsonProperty("branch_routings")]
        public List<BankRouting> BranchRoutings { get; set; }
    }
}