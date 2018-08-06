using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Transaction
{
    public class TransactionList : IEnumerableSource<Transaction>
    {
        public List<Transaction> Transactions { get; set; }
        public IEnumerable<Transaction> Items => Transactions;
    }
}
