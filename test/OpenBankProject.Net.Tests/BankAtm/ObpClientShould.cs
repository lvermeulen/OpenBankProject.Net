using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetBankAtmAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var atms = await _client.GetBankAtmsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            var result = await _client.GetBankAtmAsync(banks.Banks.First().Id, atms.Atms.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBankAtmsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetBankAtmsAsync(banks.Banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
