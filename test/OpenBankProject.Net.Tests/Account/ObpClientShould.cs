using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetAccountByIdAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var accounts = (await _client.GetAccountsAsync(banks.First().Id).ConfigureAwait(false)).ToList();
            var result = await _client.GetAccountByIdAsync(accounts.First().BankId, accounts.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountByIdWithViewAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var accounts = (await _client.GetAccountsAsync(banks.First().Id).ConfigureAwait(false)).ToList();
            var result = await _client.GetAccountByIdAsync(accounts.First().BankId, accounts.First().Id, accounts.First().ViewsAvailable.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsHeldAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsHeldAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountIdsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountIdsAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsWithViewsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsWithViewsAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetPrivateAccountsAtAllBanksAsync()
        {
            var result = await _client.GetPrivateAccountsAtAllBanksAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
