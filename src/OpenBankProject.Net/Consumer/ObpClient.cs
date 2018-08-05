using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.Common;
using OpenBankProject.Net.Models.Consumer;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetConsumerUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment("/management/consumers");
        }

        public async Task<bool> EnableConsumerAsync(int consumerId, bool value)
        {
            try
            {
                var data = new
                {
                    enabled = value
                };

                var response = await (await GetConsumerUrlAsync())
                    .AppendPathSegment($"/{consumerId}")
                    .PutJsonAsync(data)
                    .ConfigureAwait(false);

                var enable = await HandleResponseAsync<Enable>(response).ConfigureAwait(false);
                return enable.Enabled;
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<Consumer> GetConsumerAsync(int consumerId)
        {
            try
            {
                return await (await GetConsumerUrlAsync())
                    .AppendPathSegment($"/{consumerId}")
                    .GetJsonAsync<Consumer>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<Consumer>> GetConsumersAsync()
        {
            try
            {
                return (await (await GetConsumerUrlAsync())
                    .GetJsonAsync<ConsumerList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<Consumer> UpdateConsumerRedirectUrlAsync(int consumerId, string redirectUrl)
        {
            try
            {
                var data = new
                {
                    redirect_url = redirectUrl
                };

                var response = await (await GetConsumerUrlAsync())
                    .AppendPathSegment($"/{consumerId}/consumer/redirect_url")
                    .PutJsonAsync(data)
                    .ConfigureAwait(false);

                return await HandleResponseAsync<Consumer>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
