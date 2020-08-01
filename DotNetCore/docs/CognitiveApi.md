# Org.OpenAPITools.Api.CognitiveApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CognitiveSavefilePost**](CognitiveApi.md#cognitivesavefilepost) | **POST** /Cognitive/savefile | 
[**CognitiveVerifyfacesPost**](CognitiveApi.md#cognitiveverifyfacespost) | **POST** /Cognitive/verifyfaces | 


<a name="cognitivesavefilepost"></a>
# **CognitiveSavefilePost**
> string CognitiveSavefilePost (string contentType = null, string contentDisposition = null, long? length = null, string name = null, string fileName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CognitiveSavefilePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CognitiveApi(config);
            var contentType = contentType_example;  // string |  (optional) 
            var contentDisposition = contentDisposition_example;  // string |  (optional) 
            var length = 789;  // long? |  (optional) 
            var name = name_example;  // string |  (optional) 
            var fileName = fileName_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.CognitiveSavefilePost(contentType, contentDisposition, length, name, fileName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CognitiveApi.CognitiveSavefilePost: " + e.Message );
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
 **contentType** | **string**|  | [optional] 
 **contentDisposition** | **string**|  | [optional] 
 **length** | **long?**|  | [optional] 
 **name** | **string**|  | [optional] 
 **fileName** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cognitiveverifyfacespost"></a>
# **CognitiveVerifyfacesPost**
> string CognitiveVerifyfacesPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CognitiveVerifyfacesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CognitiveApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                string result = apiInstance.CognitiveVerifyfacesPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CognitiveApi.CognitiveVerifyfacesPost: " + e.Message );
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
 **body** | **Object**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

