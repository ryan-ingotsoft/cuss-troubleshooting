# Symend.Client.Customer.Api.SymPermViewCustomerTrailApi

All URIs are relative to *https://localhost:8000/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCustomerEventsByAccountKey**](SymPermViewCustomerTrailApi.md#getcustomereventsbyaccountkey) | **GET** /v1/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key |

<a name="getcustomereventsbyaccountkey"></a>
# **GetCustomerEventsByAccountKey**
> CustomerTrailEventPagedModel GetCustomerEventsByAccountKey (Guid xSymOrganizationId, string accountKey, GetCustomerEventsByAccountKeySearchParameterParameter searchParameter = null, GuidPagedMetadata paging = null)

Get Customer Trail events for an Account by Account Key

Returns a detailed list of Customer Trail Events for a specific Account, by Account Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetCustomerEventsByAccountKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://localhost:8000/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountKey = "accountKey_example";  // string | This is the account key to be used to return related customer trail events
            var searchParameter = new GetCustomerEventsByAccountKeySearchParameterParameter(); // GetCustomerEventsByAccountKeySearchParameterParameter | Search Parameter (optional) 
            var paging = new GuidPagedMetadata(); // GuidPagedMetadata | Paging Criteria (optional) 

            try
            {
                // Get Customer Trail events for an Account by Account Key
                CustomerTrailEventPagedModel result = apiInstance.GetCustomerEventsByAccountKey(xSymOrganizationId, accountKey, searchParameter, paging);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerEventsByAccountKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail events for an Account by Account Key
    ApiResponse<CustomerTrailEventPagedModel> response = apiInstance.GetCustomerEventsByAccountKeyWithHttpInfo(xSymOrganizationId, accountKey, searchParameter, paging);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountKey** | **string** | This is the account key to be used to return related customer trail events |  |
| **searchParameter** | [**GetCustomerEventsByAccountKeySearchParameterParameter**](GetCustomerEventsByAccountKeySearchParameterParameter.md) | Search Parameter | [optional]  |
| **paging** | [**GuidPagedMetadata**](GuidPagedMetadata.md) | Paging Criteria | [optional]  |

### Return type

[**CustomerTrailEventPagedModel**](CustomerTrailEventPagedModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

