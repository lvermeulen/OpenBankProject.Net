using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetCrmEventsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetCrmEventsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCustomerSocialMediaHandlesAsync()
        {
            //var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            //var result = await _client.GetCustomerSocialMediaHandlesAsync(banks.Banks.First().Id).ConfigureAwait(false);
            //Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCustomersForCurrentUserAsync()
        {
            var result = await _client.GetCustomersForCurrentUserAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBankCustomersForCurrentUserAsync()
        {
            var banks = await _client.GetBanksAsync();
            var result = await _client.GetBankCustomersForCurrentUserAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
