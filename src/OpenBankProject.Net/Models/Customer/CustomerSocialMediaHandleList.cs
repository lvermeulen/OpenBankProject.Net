using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Customer
{
    public class CustomerSocialMediaHandleList : IEnumerableSource<CustomerSocialMediaHandle>
    {
        public List<CustomerSocialMediaHandle> Checks { get; set; }
        public IEnumerable<CustomerSocialMediaHandle> Items => Checks;
    }
}
