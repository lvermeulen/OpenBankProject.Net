using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetConsumerAsync()
        {
            var consumers = await _client.GetConsumersAsync().ConfigureAwait(false);
            var result = await _client.GetConsumerAsync(consumers.List.First().ConsumerId).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetConsumersAsync()
        {
            var result = await _client.GetConsumersAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
