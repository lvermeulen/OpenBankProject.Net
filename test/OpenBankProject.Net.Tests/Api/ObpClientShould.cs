using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetApiConfigurationAsync()
        {
            var result = await _client.GetApiConfigurationAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetApiInformationAsync()
        {
            var result = await _client.GetApiInformationAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("bnpp.12.be.be")]
        public async Task GetAdapterInformationAsync(string bankId)
        {
            var result = await _client.GetAdapterInformationAsync(bankId).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
