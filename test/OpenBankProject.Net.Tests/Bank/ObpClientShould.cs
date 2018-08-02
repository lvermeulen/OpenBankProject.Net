using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetBankAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetBankAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBanksAsync()
        {
            var result = await _client.GetBanksAsync().ConfigureAwait(false);
            Assert.NotEmpty(result.Banks);
        }

        [Fact]
        public async Task GetCreditLimitOrderRequestsAsync()
        {
            //var result = await _client.GetCreditLimitOrderRequestsAsync();
            //Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTransactionTypesAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetTransactionTypesAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCreditCardOrderStatusAsync()
        {
            //var result = await _client.GetCreditCardOrderStatusAsync();
            //Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCheckbookOrdersAsync()
        {
            //var result = await _client.GetCheckbookOrdersAsync();
            //Assert.NotNull(result);
        }
    }
}
