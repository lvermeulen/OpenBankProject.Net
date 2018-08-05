using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Customer
{
    public class CustomerList : IEnumerableSource<Customer>
    {
        public List<Customer> Customers { get; set; }
        public IEnumerable<Customer> Items => Customers;
    }
}
