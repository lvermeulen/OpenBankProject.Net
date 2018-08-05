using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.Net.Models.Common;
using OpenBankProject.Net.Models.Customer;

namespace OpenBankProject.Net
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetCustomerUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token);
        }

        public async Task<bool> CreateCustomerSocialMediaHandleAsync(string bankId, string customerId, 
            CustomerSocialMediaHandle customerSocialMediaHandle)
        {
            var response = await (await GetCustomerUrlAsync())
                .AppendPathSegment($"/banks/{bankId}/customers/{customerId}/social_media_handles")
                .PostJsonAsync(customerSocialMediaHandle)
                .ConfigureAwait(false);

            var result = await HandleResponseAsync<SuccessResponse>(response).ConfigureAwait(false);
            return result.Success == "Success";
        }

        public async Task<Customer> CreateCustomerAsync(string bankId, CustomerWithUserId customerWithUserId)
        {
            var response = await (await GetCustomerUrlAsync())
                .AppendPathSegment($"/banks/{bankId}/customers")
                .PostJsonAsync(customerWithUserId)
                .ConfigureAwait(false);

            return await HandleResponseAsync<Customer>(response).ConfigureAwait(false);
        }

        public async Task<UserCustomerLink> LinkUserToCustomerAsync(string bankId, string userId, string customerId)
        {
            var data = new
            {
                user_id = userId,
                customer_id = customerId
            };

            var response = await (await GetCustomerUrlAsync())
                .AppendPathSegment($"/banks/{bankId}/user_customer_links")
                .PostJsonAsync(data)
                .ConfigureAwait(false);

            return await HandleResponseAsync<UserCustomerLink>(response).ConfigureAwait(false);
        }

        public async Task<IEnumerable<CrmEvent>> GetCrmEventsAsync(string bankId)
        {
            try
            {
                return (await (await GetCustomerUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/crm-events")
                    .GetJsonAsync<CrmEventList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<CustomerSocialMediaHandle>> GetCustomerSocialMediaHandlesAsync(string bankId, string customerId)
        {
            try
            {
                return (await (await GetCustomerUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/customers/{customerId}/social_media_handles")
                    .GetJsonAsync<CustomerSocialMediaHandleList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<Customer>> GetCustomersForCurrentUserAsync()
        {
            try
            {
                return (await (await GetCustomerUrlAsync())
                    .AppendPathSegment("/users/current/customers")
                    .GetJsonAsync<CustomerList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<Customer>> GetBankCustomersForCurrentUserAsync(string bankId)
        {
            try
            {
                return (await (await GetCustomerUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/customers")
                    .GetJsonAsync<CustomerList>()
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
