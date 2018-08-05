using System.Collections.Generic;

namespace OpenBankProject.Net.Models.Common
{
    public class EntitlementList : IEnumerableSource<Entitlement>
    {
        public List<Entitlement> List { get; set; }
        public IEnumerable<Entitlement> Items => List;
    }
}