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
            var accounts = await _client.GetAccountsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            var result = await _client.GetAccountByIdAsync(accounts.Accounts.First().BankId, accounts.Accounts.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountByIdWithViewAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var accounts = await _client.GetAccountsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            var result = await _client.GetAccountByIdAsync(accounts.Accounts.First().BankId, accounts.Accounts.First().Id, accounts.Accounts.First().ViewsAvailable.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsHeldAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsHeldAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountIdsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountIdsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsWithViewsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsWithViewsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAccountsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetAccountsAsync(banks.Banks.First().Id).ConfigureAwait(false);
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
