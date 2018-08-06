using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Transaction
{
    public class TransactionInformationList : IEnumerableSource<TransactionInformation>
    {
        public List<TransactionInformation> Transactions { get; set; }
        public IEnumerable<TransactionInformation> Items => Transactions;
    }
}
