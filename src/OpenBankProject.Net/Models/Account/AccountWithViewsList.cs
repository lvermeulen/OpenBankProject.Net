using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class AccountWithViewsList : IEnumerableSource<AccountWithViews>
    {
        public List<AccountWithViews> Accounts { get; set; }
        public IEnumerable<AccountWithViews> Items => Accounts;
    }
}
