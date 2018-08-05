using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Account
{
    public class AccountIdList : IEnumerableSource<WithId>
    {
        public List<WithId> Accounts { get; set; }
        public IEnumerable<WithId> Items => Accounts;
    }
}
