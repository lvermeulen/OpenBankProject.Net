using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.Bank;
using OpenBankProject.Net.Models.Common;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetBanksUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment("/banks");
        }

        public async Task<Bank> CreateBankAsync(Bank bank)
        {
            var response = await (await GetBanksUrlAsync())
                .PostJsonAsync(bank)
                .ConfigureAwait(false);

            return await HandleResponseAsync<Bank>(response).ConfigureAwait(false);
        }

        public async Task<CreditLimitOrder> CreateCreditLimitOrderAsync(string bankId, string customerId, 
            CreditLimitOrderRequest creditLimitOrderRequest)
        {
            var response = await (await GetBanksUrlAsync())
                .AppendPathSegment($"/{bankId}/customers/{customerId}/credit_limit/requests")
                .PostJsonAsync(creditLimitOrderRequest)
                .ConfigureAwait(false);

            return await HandleResponseAsync<CreditLimitOrder>(response).ConfigureAwait(false);
        }

        public async Task<TransactionType> CreateTransactionTypeAsync(string bankId, TransactionTypeRequest transactionTypeRequest)
        {
            var response = await (await GetBanksUrlAsync())
                .AppendPathSegment($"/{bankId}/transaction-types")
                .PutJsonAsync(transactionTypeRequest)
                .ConfigureAwait(false);

            return await HandleResponseAsync<TransactionType>(response).ConfigureAwait(false);
        }

        public async Task<Bank> GetBankAsync(string bankId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}")
                    .GetJsonAsync<Bank>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<BankList> GetBanksAsync()
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .GetJsonAsync<BankList>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<CreditLimitOrderStatus> GetCreditLimitOrderRequestByRequestIdAsync(string bankId, string customerId, 
            string requestId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}/customers/{customerId}/credit_limit/requests/{requestId}")
                    .GetJsonAsync<CreditLimitOrderStatus>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<string> GetCreditLimitOrderRequestsAsync(string bankId, string customerId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}/customers/{customerId}/credit_limit/requests")
                    .GetStringAsync()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<TransactionTypeRequestList> GetTransactionTypesAsync(string bankId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}/transaction-types")
                    .GetJsonAsync<TransactionTypeRequestList>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<CreditCardOrderStatusList> GetCreditCardOrderStatusAsync(string bankId, string accountId, string viewId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}/accounts/{accountId}/{viewId}/credit_cards/orders")
                    .GetJsonAsync<CreditCardOrderStatusList>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<CheckbookOrders> GetCheckbookOrdersAsync(string bankId, string accountId, string viewId)
        {
            try
            {
                return await (await GetBanksUrlAsync())
                    .AppendPathSegment($"/{bankId}/accounts/{accountId}/{viewId}/checkbook/orders")
                    .GetJsonAsync<CheckbookOrders>()
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
