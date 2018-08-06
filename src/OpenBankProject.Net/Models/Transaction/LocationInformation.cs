using System;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Transaction
{
    public class LocationInformation : Location
    {
        public DateTime? Date { get; set; }
        public NamedProvider User { get; set; }
    }
}