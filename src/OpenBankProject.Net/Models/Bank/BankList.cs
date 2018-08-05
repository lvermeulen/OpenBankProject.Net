using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Bank
{
    public class BankList : IEnumerableSource<Bank>
    {
        public List<Bank> Banks { get; set; }
        public IEnumerable<Bank> Items => Banks;
    }
}
