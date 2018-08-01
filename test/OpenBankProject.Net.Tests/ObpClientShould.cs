using System.IO;
using Microsoft.Extensions.Configuration;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        private readonly ObpClient _client;

        public ObpClientShould()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            _client = new ObpClient(configuration["url"], configuration["userName"], configuration["password"], configuration["consumerKey"]);
        }
    }
}
