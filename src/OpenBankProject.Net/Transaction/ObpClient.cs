using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Common;
using OpenBankProject.Net.Models.Common;
using OpenBankProject.Net.Models.Transaction;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetTransactionUrlAsync(string bankId, string accountId)
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment($"/banks/{bankId}/accounts/{accountId}");
        }

        private async Task<IFlurlRequest> GetTransactionUrlAsync(string bankId, string accountId, string viewId) => 
            (await GetTransactionUrlAsync(bankId, accountId))
                .AppendPathSegment($"/{viewId}/transactions");

        private async Task<IFlurlRequest> GetTransactionUrlAsync(string bankId, string accountId, string viewId, string transactionId) => 
            (await GetTransactionUrlAsync(bankId, accountId, viewId))
                .AppendPathSegment($"/{transactionId}");

        public async Task<OtherTransactionAccount> GetOtherAccountOfTransactionAsync(string bankId, string accountId, string viewId, string transactionId)
        {
            try
            {
                return await (await GetTransactionUrlAsync(bankId, accountId, viewId, transactionId))
                    .AppendPathSegment("/other")
                    .GetJsonAsync<OtherTransactionAccount>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<Transaction> GetTransactionByIdAsync(string bankId, string accountId, string viewId, string transactionId)
        {
            try
            {
                return await (await GetTransactionUrlAsync(bankId, accountId, viewId, transactionId))
                    .AppendPathSegment("/transaction")
                    .GetJsonAsync<Transaction>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<TransactionInformation>> GetTransactionsAsync(string bankId, string accountId, 
            SortDirection? sortDirection = null,
            int? limit = null,
            int? offset = null,
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            try
            {
                var queryParamValues = new Dictionary<string, object>
                {
                    ["sort_direction"] = sortDirection.ConvertNullableToString(),
                    ["limit"] = limit,
                    ["offset"] = offset,
                    ["from_date"] = fromDate,
                    ["to_date"] = toDate
                };

                return (await (await GetTransactionUrlAsync(bankId, accountId))
                    .AppendPathSegment("/transactions")
                    .SetQueryParams(queryParamValues)
                    .GetJsonAsync<TransactionInformationList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(string bankId, string accountId, string viewId,
            SortDirection? sortDirection = null,
            int? limit = null,
            int? offset = null,
            DateTime? fromDate = null,
            DateTime? toDate = null)
        {
            try
            {
                var queryParamValues = new Dictionary<string, object>
                {
                    ["sort_direction"] = sortDirection.ConvertNullableToString(),
                    ["limit"] = limit,
                    ["offset"] = offset,
                    ["from_date"] = fromDate,
                    ["to_date"] = toDate
                };

                return (await (await GetTransactionUrlAsync(bankId, accountId, viewId))
                    .AppendPathSegment("/transactions")
                    .SetQueryParams(queryParamValues)
                    .GetJsonAsync<TransactionList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
