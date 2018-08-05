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
            var result = await _client.GetCrmEventsAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCustomerSocialMediaHandlesAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var customers = await _client.GetCustomersForCurrentUserAsync().ConfigureAwait(false);
            var result = await _client.GetCustomerSocialMediaHandlesAsync(banks.First().Id, customers.First().CustomerId).ConfigureAwait(false);
            Assert.NotNull(result);
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
            var result = await _client.GetBankCustomersForCurrentUserAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
