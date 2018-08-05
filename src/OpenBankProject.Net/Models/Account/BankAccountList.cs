using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class BankAccountList : IEnumerableSource<BankAccount>
    {
        public List<BankAccount> Accounts { get; set; }
        public IEnumerable<BankAccount> Items => Accounts;
    }
}