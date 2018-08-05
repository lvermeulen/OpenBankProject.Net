using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.Net.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetCurrentUserAsync()
        {
            var result = await _client.GetCurrentUserAsync().ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetUserByUserNameAsync()
        {
            var user = await _client.GetCurrentUserAsync().ConfigureAwait(false);
            var result = await _client.GetUserByUserNameAsync(user.Username).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetUserByUserIdAsync()
        {
            var user = await _client.GetCurrentUserAsync().ConfigureAwait(false);
            var result = await _client.GetUserByUserIdAsync(user.UserId).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetUsersByEmailAddressAsync()
        {
            var user = await _client.GetCurrentUserAsync().ConfigureAwait(false);
            var result = await _client.GetUsersByEmailAddressAsync(user.Email).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAllUsersAsync()
        {
            var results = await _client.GetAllUsersAsync().ConfigureAwait(false);
            Assert.NotEmpty(results);
        }
    }
}
