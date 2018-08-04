using System.Collections.Generic;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Bank
{
    public class CheckbookOrders
    {
        public AccountInformation Account { get; set; }
        public List<OrderInformation> Orders { get; set; }
    }
}
