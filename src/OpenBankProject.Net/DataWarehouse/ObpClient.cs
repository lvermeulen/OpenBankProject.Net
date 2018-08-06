using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetDataWarehouseUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment("/search/warehouse");
        }

        public Task<string> SearchDataWarehouseAsync(string queryExpression) => 
            SearchDataWarehouseAsync(queryExpression, "ALL");

        public Task<string> SearchDataWarehouseAsync(string queryExpression, string index) => 
            SearchDataWarehouseAsync(queryExpression, new[] { index });

        public async Task<string> SearchDataWarehouseAsync(string queryExpression, params string[] indexes)
        {
            try
            {
                var response = await (await GetDataWarehouseUrlAsync())
                    .AppendPathSegment($"/{string.Join(",", indexes)}")
                    .PostJsonAsync(queryExpression)
                    .ConfigureAwait(false);

                return await HandleResponseAsync<string>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public Task<string> SearchDataWarehouseStatisticsAsync(string queryExpression) => 
            SearchDataWarehouseStatisticsAsync(queryExpression, "ALL");

        public async Task<string> SearchDataWarehouseStatisticsAsync(string queryExpression, string index)
        {
            try
            {
                var response = await (await GetDataWarehouseUrlAsync())
                    .AppendPathSegment($"/statistics/{index}")
                    .PostJsonAsync(queryExpression)
                    .ConfigureAwait(false);

                return await HandleResponseAsync<string>(response).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
