using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Transaction
{
    public class MinimalTransactionAccount : MinimalTransactionAccountInformation
    {
        public List<Holder> Holders { get; set; }
    }
}