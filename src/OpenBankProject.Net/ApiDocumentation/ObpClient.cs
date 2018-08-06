using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.ApiDocumentation;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetApiDocumentationUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token);
        }

        public async Task<IEnumerable<GlossaryItem>> GetApiGlossaryAsync()
        {
            try
            {
                return (await (await GetApiDocumentationUrlAsync())
                    .AppendPathSegment("/api/glossary")
                    .GetJsonAsync<GlossaryItemList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<MessageDoc>> GetMessageDocsAsync(string connector)
        {
            try
            {
                return (await (await GetApiDocumentationUrlAsync())
                        .AppendPathSegment($"/message-docs/{connector}")
                        .GetJsonAsync<MessageDocList>()
                        .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<ResourceDoc>> GetResourceDocsAsync(string version)
        {
            try
            {
                return (await (await GetApiDocumentationUrlAsync())
                        .AppendPathSegment($"/resource-docs/{version}/obp")
                        .GetJsonAsync<ResourceDocList>()
                        .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<object> GetSwaggerDocumentationAsync(string version)
        {
            try
            {
                return await (await GetApiDocumentationUrlAsync())
                    .AppendPathSegment($"/resource-docs/{version}/swagger")
                    .GetJsonAsync<object>()
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
