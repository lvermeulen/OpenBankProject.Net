using Newtonsoft.Json;

namespace OpenBankProject.Net.Models.Common
{
    public abstract class VersionGitCommit
    {
        public string Version { get; set; }
        [JsonProperty("git_commit")]
        public string GitCommit { get; set; }
    }
}
