using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetTransactionsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var accounts = (await _client.GetAccountsAsync(banks.First().Id).ConfigureAwait(false)).ToList();
            var result = await _client.GetTransactionsAsync(accounts.First().BankId, accounts.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
