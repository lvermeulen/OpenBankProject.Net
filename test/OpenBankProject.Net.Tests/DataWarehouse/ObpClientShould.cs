using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task SearchDataWarehouseAsync()
        {
            string result = await _client.SearchDataWarehouseAsync("q=_index:20170531-transactions").ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
