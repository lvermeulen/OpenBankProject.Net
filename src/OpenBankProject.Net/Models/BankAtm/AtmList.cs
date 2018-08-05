using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.BankAtm
{
    public class AtmList : IEnumerableSource<Atm>
    {
        public List<Atm> Atms { get; set; }
        public IEnumerable<Atm> Items => Atms;
    }
}
