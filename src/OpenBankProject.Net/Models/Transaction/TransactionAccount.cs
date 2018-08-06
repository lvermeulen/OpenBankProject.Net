using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Transaction
{
    public class TransactionAccount : TransactionAccountInformation
    {
        public List<Holder> Holders { get; set; }
    }
}