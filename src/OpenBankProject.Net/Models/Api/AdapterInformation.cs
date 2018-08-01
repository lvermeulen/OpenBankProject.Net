using System;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net.Models.Api
{
    public class AdapterInformation : VersionGitCommit
    {
        public string Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
