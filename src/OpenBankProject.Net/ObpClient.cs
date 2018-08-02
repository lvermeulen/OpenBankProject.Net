using System;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OpenBankProject.Net.Models.Common;
using OpenBankProject.Net.Models.Login;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private static readonly ISerializer s_serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

        private const string VERSION = "v3.1.0";

        private readonly Url _url;
        private readonly string _userName;
        private readonly string _password;
        private readonly string _consumerKey;
        private string _token;

        public ObpClient(string url, string userName, string password, string consumerKey)
        {
            _url = url;
            _userName = userName;
            _password = password;
            _consumerKey = consumerKey;
        }

        private async Task<string> GetTokenAsync()
        {
            var response = await new Url(_url)
                .AppendPathSegment("/my/logins/direct")
                .WithHeader("Authorization", $"DirectLogin username=\"{_userName}\", password=\"{_password}\", consumer_key=\"{_consumerKey}\"")
                .SendAsync(HttpMethod.Post)
                .ConfigureAwait(false);

            var loginToken = await HandleResponseAsync<LoginToken>(response).ConfigureAwait(false);
            return loginToken.Token;
        }

        private async Task CheckTokenAsync()
        {
            if (_token == null)
            {
                _token = await GetTokenAsync();
            }
        }

        private IFlurlRequest GetBaseUrl(string token) => new Url(_url)
            .WithDirectLoginToken(token)
            .WithHeader("Content-Type", "application/json")
            .WithHeader("Accept", "application/json")
            .AppendPathSegment($"/obp/{VERSION}")
            .ConfigureRequest(settings => settings.JsonSerializer = s_serializer);

        private async Task<TResult> ReadResponseContentAsync<TResult>(HttpResponseMessage responseMessage, Func<string, TResult> contentHandler = null)
        {
            string content = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            return contentHandler != null
                ? contentHandler(content)
                : JsonConvert.DeserializeObject<TResult>(content);
        }

        private async Task<bool> ReadResponseContentAsync(HttpResponseMessage responseMessage)
        {
            string content = await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
            return content == "";
        }

        private async Task HandleErrorsAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await ReadResponseContentAsync<ErrorResponse>(response).ConfigureAwait(false);
                throw new InvalidOperationException($"Http request failed ({(int)response.StatusCode} - {response.StatusCode}):\n{errorResponse.Error}");
            }
        }

        private async Task<TResult> HandleResponseAsync<TResult>(HttpResponseMessage responseMessage, Func<string, TResult> contentHandler = null)
        {
            await HandleErrorsAsync(responseMessage).ConfigureAwait(false);
            return await ReadResponseContentAsync(responseMessage, contentHandler).ConfigureAwait(false);
        }

        private async Task<bool> HandleResponseAsync(HttpResponseMessage responseMessage)
        {
            await HandleErrorsAsync(responseMessage).ConfigureAwait(false);
            return await ReadResponseContentAsync(responseMessage).ConfigureAwait(false);
        }
    }
}
