using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class AccountWithViewsAvailableList : IEnumerableSource<AccountWithViewsAvailable>
    {
        public List<AccountWithViewsAvailable> Accounts { get; set; }
        public IEnumerable<AccountWithViewsAvailable> Items => Accounts;
    }
}
