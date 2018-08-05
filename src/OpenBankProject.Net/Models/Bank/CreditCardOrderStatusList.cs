using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Bank
{
    public class CreditCardOrderStatusList : IEnumerableSource<CreditCardOrderStatus>
    {
        public List<CreditCardOrderStatus> Cards { get; set; }
        public IEnumerable<CreditCardOrderStatus> Items => Cards;
    }
}