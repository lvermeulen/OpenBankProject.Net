using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetApiGlossaryAsync()
        {
            var result = await _client.GetApiGlossaryAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetMessageDocsAsync()
        {
            var result = await _client.GetMessageDocsAsync("kafka_vJune2017").ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetResourceDocsAsync()
        {
            var result = await _client.GetResourceDocsAsync("v3.1.0").ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetSwaggerDocumentationAsync()
        {
            var result = await _client.GetSwaggerDocumentationAsync("v3.1.0").ConfigureAwait(false);
            Assert.NotNull(result);
        }
    }
}
