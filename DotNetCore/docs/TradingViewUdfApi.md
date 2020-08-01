# Org.OpenAPITools.Api.TradingViewUdfApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiTradingViewUdfConfigGet**](TradingViewUdfApi.md#apitradingviewudfconfigget) | **GET** /api/TradingViewUdf/config | 
[**ApiTradingViewUdfHistoryGet**](TradingViewUdfApi.md#apitradingviewudfhistoryget) | **GET** /api/TradingViewUdf/history | 
[**ApiTradingViewUdfSymbolsGet**](TradingViewUdfApi.md#apitradingviewudfsymbolsget) | **GET** /api/TradingViewUdf/symbols | 
[**ApiTradingViewUdfTimeGet**](TradingViewUdfApi.md#apitradingviewudftimeget) | **GET** /api/TradingViewUdf/time | 


<a name="apitradingviewudfconfigget"></a>
# **ApiTradingViewUdfConfigGet**
> void ApiTradingViewUdfConfigGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiTradingViewUdfConfigGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingViewUdfApi(config);

            try
            {
                apiInstance.ApiTradingViewUdfConfigGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingViewUdfApi.ApiTradingViewUdfConfigGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitradingviewudfhistoryget"></a>
# **ApiTradingViewUdfHistoryGet**
> void ApiTradingViewUdfHistoryGet (long? from = null, long? to = null, string symbol = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiTradingViewUdfHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingViewUdfApi(config);
            var from = 789;  // long? |  (optional) 
            var to = 789;  // long? |  (optional) 
            var symbol = symbol_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiTradingViewUdfHistoryGet(from, to, symbol);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingViewUdfApi.ApiTradingViewUdfHistoryGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **long?**|  | [optional] 
 **to** | **long?**|  | [optional] 
 **symbol** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitradingviewudfsymbolsget"></a>
# **ApiTradingViewUdfSymbolsGet**
> void ApiTradingViewUdfSymbolsGet (string symbol = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiTradingViewUdfSymbolsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingViewUdfApi(config);
            var symbol = symbol_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiTradingViewUdfSymbolsGet(symbol);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingViewUdfApi.ApiTradingViewUdfSymbolsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **symbol** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apitradingviewudftimeget"></a>
# **ApiTradingViewUdfTimeGet**
> void ApiTradingViewUdfTimeGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiTradingViewUdfTimeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TradingViewUdfApi(config);

            try
            {
                apiInstance.ApiTradingViewUdfTimeGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TradingViewUdfApi.ApiTradingViewUdfTimeGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

