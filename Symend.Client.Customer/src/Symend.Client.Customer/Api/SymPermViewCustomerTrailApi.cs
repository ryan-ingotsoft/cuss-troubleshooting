/*
 * Customer Service API
 *
 * API for Customer Domain Operations
 *
 * The version of the OpenAPI document: v1
 * Contact: support@symend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Symend.Client.Customer.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermViewCustomerTrailApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Customer Trail events for an Account by Account Key
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerTrailEventPagedModel</returns>
        CustomerTrailEventPagedModel GetCustomerEventsByAccountKey(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0);

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerTrailEventPagedModel</returns>
        ApiResponse<CustomerTrailEventPagedModel> GetCustomerEventsByAccountKeyWithHttpInfo(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermViewCustomerTrailApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Customer Trail events for an Account by Account Key
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomerTrailEventPagedModel</returns>
        System.Threading.Tasks.Task<CustomerTrailEventPagedModel> GetCustomerEventsByAccountKeyAsync(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key
        /// </summary>
        /// <remarks>
        /// Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </remarks>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomerTrailEventPagedModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<CustomerTrailEventPagedModel>> GetCustomerEventsByAccountKeyWithHttpInfoAsync(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISymPermViewCustomerTrailApi : ISymPermViewCustomerTrailApiSync, ISymPermViewCustomerTrailApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SymPermViewCustomerTrailApi : ISymPermViewCustomerTrailApi
    {
        private Symend.Client.Customer.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermViewCustomerTrailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SymPermViewCustomerTrailApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermViewCustomerTrailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SymPermViewCustomerTrailApi(string basePath)
        {
            this.Configuration = Symend.Client.Customer.Client.Configuration.MergeConfigurations(
                Symend.Client.Customer.Client.GlobalConfiguration.Instance,
                new Symend.Client.Customer.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermViewCustomerTrailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SymPermViewCustomerTrailApi(Symend.Client.Customer.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Symend.Client.Customer.Client.Configuration.MergeConfigurations(
                Symend.Client.Customer.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Symend.Client.Customer.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SymPermViewCustomerTrailApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SymPermViewCustomerTrailApi(Symend.Client.Customer.Client.ISynchronousClient client, Symend.Client.Customer.Client.IAsynchronousClient asyncClient, Symend.Client.Customer.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Symend.Client.Customer.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Symend.Client.Customer.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Symend.Client.Customer.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Symend.Client.Customer.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Symend.Client.Customer.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CustomerTrailEventPagedModel</returns>
        public CustomerTrailEventPagedModel GetCustomerEventsByAccountKey(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0)
        {
            Symend.Client.Customer.Client.ApiResponse<CustomerTrailEventPagedModel> localVarResponse = GetCustomerEventsByAccountKeyWithHttpInfo(xSymOrganizationId, accountKey, searchParameter, paging);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CustomerTrailEventPagedModel</returns>
        public Symend.Client.Customer.Client.ApiResponse<CustomerTrailEventPagedModel> GetCustomerEventsByAccountKeyWithHttpInfo(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0)
        {
            // verify the required parameter 'accountKey' is set
            if (accountKey == null)
            {
                throw new Symend.Client.Customer.Client.ApiException(400, "Missing required parameter 'accountKey' when calling SymPermViewCustomerTrailApi->GetCustomerEventsByAccountKey");
            }

            Symend.Client.Customer.Client.RequestOptions localVarRequestOptions = new Symend.Client.Customer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Symend.Client.Customer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Symend.Client.Customer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (searchParameter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "searchParameter", searchParameter));
            }
            if (paging != null)
            {
                localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "paging", paging));
            }
            localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "accountKey", accountKey));
            localVarRequestOptions.HeaderParameters.Add("X-Sym-OrganizationId", Symend.Client.Customer.Client.ClientUtils.ParameterToString(xSymOrganizationId)); // header parameter

            localVarRequestOptions.Operation = "SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKey";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JSON_Web_Token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CustomerTrailEventPagedModel>("/v1/accounts/customer-trail-events", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomerEventsByAccountKey", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CustomerTrailEventPagedModel</returns>
        public async System.Threading.Tasks.Task<CustomerTrailEventPagedModel> GetCustomerEventsByAccountKeyAsync(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Symend.Client.Customer.Client.ApiResponse<CustomerTrailEventPagedModel> localVarResponse = await GetCustomerEventsByAccountKeyWithHttpInfoAsync(xSymOrganizationId, accountKey, searchParameter, paging, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Customer Trail events for an Account by Account Key Returns a detailed list of Customer Trail Events for a specific Account, by Account Key
        /// </summary>
        /// <exception cref="Symend.Client.Customer.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xSymOrganizationId">Organization UUID of the client making the request</param>
        /// <param name="accountKey">This is the account key to be used to return related customer trail events</param>
        /// <param name="searchParameter">Search Parameter (optional)</param>
        /// <param name="paging">Paging Criteria (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CustomerTrailEventPagedModel)</returns>
        public async System.Threading.Tasks.Task<Symend.Client.Customer.Client.ApiResponse<CustomerTrailEventPagedModel>> GetCustomerEventsByAccountKeyWithHttpInfoAsync(Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = default(GetCustomerEventsByAccountKeySearchParameterParameter), GuidPagedMetadata paging = default(GuidPagedMetadata), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'accountKey' is set
            if (accountKey == null)
            {
                throw new Symend.Client.Customer.Client.ApiException(400, "Missing required parameter 'accountKey' when calling SymPermViewCustomerTrailApi->GetCustomerEventsByAccountKey");
            }


            Symend.Client.Customer.Client.RequestOptions localVarRequestOptions = new Symend.Client.Customer.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Symend.Client.Customer.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Symend.Client.Customer.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (searchParameter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "searchParameter", searchParameter));
            }
            if (paging != null)
            {
                localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "paging", paging));
            }
            localVarRequestOptions.QueryParameters.Add(Symend.Client.Customer.Client.ClientUtils.ParameterToMultiMap("", "accountKey", accountKey));
            localVarRequestOptions.HeaderParameters.Add("X-Sym-OrganizationId", Symend.Client.Customer.Client.ClientUtils.ParameterToString(xSymOrganizationId)); // header parameter

            localVarRequestOptions.Operation = "SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKey";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (JSON_Web_Token) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CustomerTrailEventPagedModel>("/v1/accounts/customer-trail-events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCustomerEventsByAccountKey", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
