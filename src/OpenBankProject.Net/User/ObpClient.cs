using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.Common;
using OpenBankProject.Net.Models.User;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetUsersUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment("/users");
        }

        public async Task<User> CreateUserAsync(string emailAddress, string userName, string password, string firstName, string lastName)
        {
            var data = new
            {
                email = emailAddress,
                username = userName,
                password,
                first_name = firstName,
                last_name = lastName
            };

            var response = await (await GetUsersUrlAsync())
                .PostJsonAsync(data)
                .ConfigureAwait(false);

            return await HandleResponseAsync<User>(response).ConfigureAwait(false);
        }

        public async Task<User> GetCurrentUserAsync()
        {
            try
            {
                return await (await GetUsersUrlAsync())
                    .AppendPathSegment("/current")
                    .GetJsonAsync<User>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<User> GetUserByUserNameAsync(string userName)
        {
            try
            {
                return await (await GetUsersUrlAsync())
                    .AppendPathSegment($"/username/{userName}")
                    .GetJsonAsync<User>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<User> GetUserByUserIdAsync(string userId)
        {
            try
            {
                return await (await GetUsersUrlAsync())
                    .AppendPathSegment($"/user_id/{userId}")
                    .GetJsonAsync<User>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<UserList> GetUsersByEmailAddressAsync(string emailAddress)
        {
            try
            {
                return await (await GetUsersUrlAsync())
                    .AppendPathSegment($"/email/{emailAddress}/terminator")
                    .GetJsonAsync<UserList>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<UserList> GetAllUsersAsync()
        {
            try
            {
                return await (await GetUsersUrlAsync())
                    .GetJsonAsync<UserList>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
