# Org.OpenAPITools.Api.UserApi

All URIs are relative to *http://localhost:5000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiUserBalanceactionsGet**](UserApi.md#apiuserbalanceactionsget) | **GET** /api/User/balanceactions | 
[**ApiUserBalancesGet**](UserApi.md#apiuserbalancesget) | **GET** /api/User/balances | 
[**ApiUserBalanceslistGet**](UserApi.md#apiuserbalanceslistget) | **GET** /api/User/balanceslist | 
[**ApiUserDepositsGet**](UserApi.md#apiuserdepositsget) | **GET** /api/User/deposits | 
[**ApiUserGetapptokenGet**](UserApi.md#apiusergetapptokenget) | **GET** /api/User/getapptoken | 
[**ApiUserOrdersGet**](UserApi.md#apiuserordersget) | **GET** /api/User/orders | 
[**ApiUserTradehistoryGet**](UserApi.md#apiusertradehistoryget) | **GET** /api/User/tradehistory | 
[**ApiUserValidateOauthGet**](UserApi.md#apiuservalidateoauthget) | **GET** /api/User/validateOauth | 
[**ApiUserValidateapptokenPost**](UserApi.md#apiuservalidateapptokenpost) | **POST** /api/User/validateapptoken | 
[**ApiUserWithdrawalsGet**](UserApi.md#apiuserwithdrawalsget) | **GET** /api/User/withdrawals | 
[**User2faPost**](UserApi.md#user2fapost) | **POST** /User/2fa | 
[**UserAffiliatedataPost**](UserApi.md#useraffiliatedatapost) | **POST** /User/affiliatedata | 
[**UserApplicationqrcommandPost**](UserApi.md#userapplicationqrcommandpost) | **POST** /User/applicationqrcommand | 
[**UserConfirmemailGet**](UserApi.md#userconfirmemailget) | **GET** /User/confirmemail | 
[**UserDisable2faPost**](UserApi.md#userdisable2fapost) | **POST** /User/disable2fa | 
[**UserEnable2faPost**](UserApi.md#userenable2fapost) | **POST** /User/enable2fa | 
[**UserExternaltokenPost**](UserApi.md#userexternaltokenpost) | **POST** /User/externaltoken | 
[**UserGetapptokenPost**](UserApi.md#usergetapptokenpost) | **POST** /User/getapptoken | 
[**UserGetreferreremailPost**](UserApi.md#usergetreferreremailpost) | **POST** /User/getreferreremail | 
[**UserResetpasswordPost**](UserApi.md#userresetpasswordpost) | **POST** /User/resetpassword | 
[**UserRestorepasswordPost**](UserApi.md#userrestorepasswordpost) | **POST** /User/restorepassword | 
[**UserSendsmscodePost**](UserApi.md#usersendsmscodepost) | **POST** /User/sendsmscode | 
[**UserSetAffiliatePost**](UserApi.md#usersetaffiliatepost) | **POST** /User/setAffiliate | 
[**UserSigninPost**](UserApi.md#usersigninpost) | **POST** /User/signin | 
[**UserSignupPost**](UserApi.md#usersignuppost) | **POST** /User/signup | 
[**UserValidatePinPost**](UserApi.md#uservalidatepinpost) | **POST** /User/validatePin | 
[**UserVerificationsGet**](UserApi.md#userverificationsget) | **GET** /User/verifications | 
[**UserVerifysmscodePost**](UserApi.md#userverifysmscodepost) | **POST** /User/verifysmscode | 
[**UserWithdrawalsGet**](UserApi.md#userwithdrawalsget) | **GET** /User/withdrawals | 


<a name="apiuserbalanceactionsget"></a>
# **ApiUserBalanceactionsGet**
> void ApiUserBalanceactionsGet (int? page = null, int? size = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalanceactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var page = 56;  // int? |  (optional) 
            var size = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiUserBalanceactionsGet(page, size);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalanceactionsGet: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **size** | **int?**|  | [optional] 

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

<a name="apiuserbalancesget"></a>
# **ApiUserBalancesGet**
> Dictionary&lt;string, double&gt; ApiUserBalancesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                Dictionary<string, double> result = apiInstance.ApiUserBalancesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalancesGet: " + e.Message );
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

**Dictionary<string, double>**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuserbalanceslistget"></a>
# **ApiUserBalanceslistGet**
> void ApiUserBalanceslistGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserBalanceslistGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                apiInstance.ApiUserBalanceslistGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserBalanceslistGet: " + e.Message );
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

<a name="apiuserdepositsget"></a>
# **ApiUserDepositsGet**
> void ApiUserDepositsGet (string currency = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserDepositsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var currency = currency_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiUserDepositsGet(currency);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserDepositsGet: " + e.Message );
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
 **currency** | **string**|  | [optional] 

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

<a name="apiusergetapptokenget"></a>
# **ApiUserGetapptokenGet**
> string ApiUserGetapptokenGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserGetapptokenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                string result = apiInstance.ApiUserGetapptokenGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserGetapptokenGet: " + e.Message );
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

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuserordersget"></a>
# **ApiUserOrdersGet**
> void ApiUserOrdersGet (string pair = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserOrdersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var pair = pair_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiUserOrdersGet(pair);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserOrdersGet: " + e.Message );
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
 **pair** | **string**|  | [optional] 

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

<a name="apiusertradehistoryget"></a>
# **ApiUserTradehistoryGet**
> void ApiUserTradehistoryGet (int? page = null, int? size = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserTradehistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var page = 56;  // int? |  (optional) 
            var size = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiUserTradehistoryGet(page, size);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserTradehistoryGet: " + e.Message );
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
 **page** | **int?**|  | [optional] 
 **size** | **int?**|  | [optional] 

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

<a name="apiuservalidateoauthget"></a>
# **ApiUserValidateOauthGet**
> string ApiUserValidateOauthGet (string id = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserValidateOauthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var id = id_example;  // string |  (optional) 

            try
            {
                string result = apiInstance.ApiUserValidateOauthGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserValidateOauthGet: " + e.Message );
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
 **id** | **string**|  | [optional] 

### Return type

**string**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuservalidateapptokenpost"></a>
# **ApiUserValidateapptokenPost**
> void ApiUserValidateapptokenPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserValidateapptokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.ApiUserValidateapptokenPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserValidateapptokenPost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiuserwithdrawalsget"></a>
# **ApiUserWithdrawalsGet**
> void ApiUserWithdrawalsGet (string currency = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiUserWithdrawalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var currency = currency_example;  // string |  (optional) 

            try
            {
                apiInstance.ApiUserWithdrawalsGet(currency);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.ApiUserWithdrawalsGet: " + e.Message );
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
 **currency** | **string**|  | [optional] 

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

<a name="user2fapost"></a>
# **User2faPost**
> void User2faPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class User2faPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.User2faPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.User2faPost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="useraffiliatedatapost"></a>
# **UserAffiliatedataPost**
> void UserAffiliatedataPost (List<CryptoCurrency> cryptoCurrencies = null, List<Order> orders = null, List<DepositAddress> depositAddresses = null, List<Balance> userBalances = null, List<Market> markets = null, List<TradingPair> tradingPairs = null, List<Transaction> transactions = null, List<WithdrawRequest> withdrawRequests = null, List<Trade> trades = null, List<Quote> quotes = null, List<SmsVerificationMessage> smsVerificationMessages = null, List<TradingAmount> tradingAmounts = null, List<RippleDestinationTag> rippleDestinationTags = null, List<BitcoinBasedCurrency> bitcoinBasedCurrencies = null, List<ERC20Token> eRC20Tokens = null, List<BalanceAction> balanceActions = null, List<KeyValue> keysValues = null, List<IApplicationTokenAccess> applicationTokenAccesses = null, List<IApplicationQrCommand> applicationQrCommands = null, List<PushToken> pushTokens = null, List<StringIdentityUserRole> userRoles = null, List<IdentityRole> roles = null, List<StringIdentityRoleClaim> roleClaims = null, List<ApplicationUser> users = null, List<StringIdentityUserClaim> userClaims = null, List<StringIdentityUserLogin> userLogins = null, List<StringIdentityUserToken> userTokens = null, Guid? databaseCurrentTransactionTransactionId = null, bool? databaseAutoTransactionsEnabled = null, string databaseProviderName = null, bool? changeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerCascadeDeleteTiming = null, Guid? changeTrackerContextDatabaseCurrentTransactionTransactionId = null, bool? changeTrackerContextDatabaseAutoTransactionsEnabled = null, string changeTrackerContextDatabaseProviderName = null, bool? changeTrackerContextChangeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerContextChangeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerContextChangeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerContextChangeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerContextChangeTrackerCascadeDeleteTiming = null, DbContext changeTrackerContextChangeTrackerContext = null, Object changeTrackerContextModel = null, Guid? changeTrackerContextContextIdInstanceId = null, int? changeTrackerContextContextIdLease = null, Object model = null, Guid? contextIdInstanceId = null, int? contextIdLease = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserAffiliatedataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var cryptoCurrencies = new List<CryptoCurrency>(); // List<CryptoCurrency> |  (optional) 
            var orders = new List<Order>(); // List<Order> |  (optional) 
            var depositAddresses = new List<DepositAddress>(); // List<DepositAddress> |  (optional) 
            var userBalances = new List<Balance>(); // List<Balance> |  (optional) 
            var markets = new List<Market>(); // List<Market> |  (optional) 
            var tradingPairs = new List<TradingPair>(); // List<TradingPair> |  (optional) 
            var transactions = new List<Transaction>(); // List<Transaction> |  (optional) 
            var withdrawRequests = new List<WithdrawRequest>(); // List<WithdrawRequest> |  (optional) 
            var trades = new List<Trade>(); // List<Trade> |  (optional) 
            var quotes = new List<Quote>(); // List<Quote> |  (optional) 
            var smsVerificationMessages = new List<SmsVerificationMessage>(); // List<SmsVerificationMessage> |  (optional) 
            var tradingAmounts = new List<TradingAmount>(); // List<TradingAmount> |  (optional) 
            var rippleDestinationTags = new List<RippleDestinationTag>(); // List<RippleDestinationTag> |  (optional) 
            var bitcoinBasedCurrencies = new List<BitcoinBasedCurrency>(); // List<BitcoinBasedCurrency> |  (optional) 
            var eRC20Tokens = new List<ERC20Token>(); // List<ERC20Token> |  (optional) 
            var balanceActions = new List<BalanceAction>(); // List<BalanceAction> |  (optional) 
            var keysValues = new List<KeyValue>(); // List<KeyValue> |  (optional) 
            var applicationTokenAccesses = new List<IApplicationTokenAccess>(); // List<IApplicationTokenAccess> |  (optional) 
            var applicationQrCommands = new List<IApplicationQrCommand>(); // List<IApplicationQrCommand> |  (optional) 
            var pushTokens = new List<PushToken>(); // List<PushToken> |  (optional) 
            var userRoles = new List<StringIdentityUserRole>(); // List<StringIdentityUserRole> |  (optional) 
            var roles = new List<IdentityRole>(); // List<IdentityRole> |  (optional) 
            var roleClaims = new List<StringIdentityRoleClaim>(); // List<StringIdentityRoleClaim> |  (optional) 
            var users = new List<ApplicationUser>(); // List<ApplicationUser> |  (optional) 
            var userClaims = new List<StringIdentityUserClaim>(); // List<StringIdentityUserClaim> |  (optional) 
            var userLogins = new List<StringIdentityUserLogin>(); // List<StringIdentityUserLogin> |  (optional) 
            var userTokens = new List<StringIdentityUserToken>(); // List<StringIdentityUserToken> |  (optional) 
            var databaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var databaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var databaseProviderName = databaseProviderName_example;  // string |  (optional) 
            var changeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextDatabaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextDatabaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextDatabaseProviderName = changeTrackerContextDatabaseProviderName_example;  // string |  (optional) 
            var changeTrackerContextChangeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerContextChangeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerContext = new DbContext(); // DbContext |  (optional) 
            var changeTrackerContextModel = new Object(); // Object |  (optional) 
            var changeTrackerContextContextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextContextIdLease = 56;  // int? |  (optional) 
            var model = new Object(); // Object |  (optional) 
            var contextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var contextIdLease = 56;  // int? |  (optional) 

            try
            {
                apiInstance.UserAffiliatedataPost(cryptoCurrencies, orders, depositAddresses, userBalances, markets, tradingPairs, transactions, withdrawRequests, trades, quotes, smsVerificationMessages, tradingAmounts, rippleDestinationTags, bitcoinBasedCurrencies, eRC20Tokens, balanceActions, keysValues, applicationTokenAccesses, applicationQrCommands, pushTokens, userRoles, roles, roleClaims, users, userClaims, userLogins, userTokens, databaseCurrentTransactionTransactionId, databaseAutoTransactionsEnabled, databaseProviderName, changeTrackerAutoDetectChangesEnabled, changeTrackerLazyLoadingEnabled, changeTrackerQueryTrackingBehavior, changeTrackerDeleteOrphansTiming, changeTrackerCascadeDeleteTiming, changeTrackerContextDatabaseCurrentTransactionTransactionId, changeTrackerContextDatabaseAutoTransactionsEnabled, changeTrackerContextDatabaseProviderName, changeTrackerContextChangeTrackerAutoDetectChangesEnabled, changeTrackerContextChangeTrackerLazyLoadingEnabled, changeTrackerContextChangeTrackerQueryTrackingBehavior, changeTrackerContextChangeTrackerDeleteOrphansTiming, changeTrackerContextChangeTrackerCascadeDeleteTiming, changeTrackerContextChangeTrackerContext, changeTrackerContextModel, changeTrackerContextContextIdInstanceId, changeTrackerContextContextIdLease, model, contextIdInstanceId, contextIdLease);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserAffiliatedataPost: " + e.Message );
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
 **cryptoCurrencies** | [**List&lt;CryptoCurrency&gt;**](CryptoCurrency.md)|  | [optional] 
 **orders** | [**List&lt;Order&gt;**](Order.md)|  | [optional] 
 **depositAddresses** | [**List&lt;DepositAddress&gt;**](DepositAddress.md)|  | [optional] 
 **userBalances** | [**List&lt;Balance&gt;**](Balance.md)|  | [optional] 
 **markets** | [**List&lt;Market&gt;**](Market.md)|  | [optional] 
 **tradingPairs** | [**List&lt;TradingPair&gt;**](TradingPair.md)|  | [optional] 
 **transactions** | [**List&lt;Transaction&gt;**](Transaction.md)|  | [optional] 
 **withdrawRequests** | [**List&lt;WithdrawRequest&gt;**](WithdrawRequest.md)|  | [optional] 
 **trades** | [**List&lt;Trade&gt;**](Trade.md)|  | [optional] 
 **quotes** | [**List&lt;Quote&gt;**](Quote.md)|  | [optional] 
 **smsVerificationMessages** | [**List&lt;SmsVerificationMessage&gt;**](SmsVerificationMessage.md)|  | [optional] 
 **tradingAmounts** | [**List&lt;TradingAmount&gt;**](TradingAmount.md)|  | [optional] 
 **rippleDestinationTags** | [**List&lt;RippleDestinationTag&gt;**](RippleDestinationTag.md)|  | [optional] 
 **bitcoinBasedCurrencies** | [**List&lt;BitcoinBasedCurrency&gt;**](BitcoinBasedCurrency.md)|  | [optional] 
 **eRC20Tokens** | [**List&lt;ERC20Token&gt;**](ERC20Token.md)|  | [optional] 
 **balanceActions** | [**List&lt;BalanceAction&gt;**](BalanceAction.md)|  | [optional] 
 **keysValues** | [**List&lt;KeyValue&gt;**](KeyValue.md)|  | [optional] 
 **applicationTokenAccesses** | [**List&lt;IApplicationTokenAccess&gt;**](IApplicationTokenAccess.md)|  | [optional] 
 **applicationQrCommands** | [**List&lt;IApplicationQrCommand&gt;**](IApplicationQrCommand.md)|  | [optional] 
 **pushTokens** | [**List&lt;PushToken&gt;**](PushToken.md)|  | [optional] 
 **userRoles** | [**List&lt;StringIdentityUserRole&gt;**](StringIdentityUserRole.md)|  | [optional] 
 **roles** | [**List&lt;IdentityRole&gt;**](IdentityRole.md)|  | [optional] 
 **roleClaims** | [**List&lt;StringIdentityRoleClaim&gt;**](StringIdentityRoleClaim.md)|  | [optional] 
 **users** | [**List&lt;ApplicationUser&gt;**](ApplicationUser.md)|  | [optional] 
 **userClaims** | [**List&lt;StringIdentityUserClaim&gt;**](StringIdentityUserClaim.md)|  | [optional] 
 **userLogins** | [**List&lt;StringIdentityUserLogin&gt;**](StringIdentityUserLogin.md)|  | [optional] 
 **userTokens** | [**List&lt;StringIdentityUserToken&gt;**](StringIdentityUserToken.md)|  | [optional] 
 **databaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **databaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **databaseProviderName** | **string**|  | [optional] 
 **changeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextDatabaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextDatabaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextDatabaseProviderName** | **string**|  | [optional] 
 **changeTrackerContextChangeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerContextChangeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerContext** | [**DbContext**](DbContext.md)|  | [optional] 
 **changeTrackerContextModel** | [**Object**](Object.md)|  | [optional] 
 **changeTrackerContextContextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextContextIdLease** | **int?**|  | [optional] 
 **model** | [**Object**](Object.md)|  | [optional] 
 **contextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **contextIdLease** | **int?**|  | [optional] 

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

<a name="userapplicationqrcommandpost"></a>
# **UserApplicationqrcommandPost**
> void UserApplicationqrcommandPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserApplicationqrcommandPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.UserApplicationqrcommandPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserApplicationqrcommandPost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userconfirmemailget"></a>
# **UserConfirmemailGet**
> void UserConfirmemailGet (string userId = null, string code = null, bool? isInApp = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserConfirmemailGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var userId = userId_example;  // string |  (optional) 
            var code = code_example;  // string |  (optional) 
            var isInApp = true;  // bool? |  (optional) 

            try
            {
                apiInstance.UserConfirmemailGet(userId, code, isInApp);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserConfirmemailGet: " + e.Message );
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
 **userId** | **string**|  | [optional] 
 **code** | **string**|  | [optional] 
 **isInApp** | **bool?**|  | [optional] 

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

<a name="userdisable2fapost"></a>
# **UserDisable2faPost**
> void UserDisable2faPost (EnableDisable2Fa enableDisable2Fa = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDisable2faPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var enableDisable2Fa = new EnableDisable2Fa(); // EnableDisable2Fa |  (optional) 

            try
            {
                apiInstance.UserDisable2faPost(enableDisable2Fa);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDisable2faPost: " + e.Message );
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
 **enableDisable2Fa** | [**EnableDisable2Fa**](EnableDisable2Fa.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userenable2fapost"></a>
# **UserEnable2faPost**
> void UserEnable2faPost (EnableDisable2Fa enableDisable2Fa = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserEnable2faPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var enableDisable2Fa = new EnableDisable2Fa(); // EnableDisable2Fa |  (optional) 

            try
            {
                apiInstance.UserEnable2faPost(enableDisable2Fa);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserEnable2faPost: " + e.Message );
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
 **enableDisable2Fa** | [**EnableDisable2Fa**](EnableDisable2Fa.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userexternaltokenpost"></a>
# **UserExternaltokenPost**
> void UserExternaltokenPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserExternaltokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.UserExternaltokenPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserExternaltokenPost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergetapptokenpost"></a>
# **UserGetapptokenPost**
> void UserGetapptokenPost (List<CryptoCurrency> cryptoCurrencies = null, List<Order> orders = null, List<DepositAddress> depositAddresses = null, List<Balance> userBalances = null, List<Market> markets = null, List<TradingPair> tradingPairs = null, List<Transaction> transactions = null, List<WithdrawRequest> withdrawRequests = null, List<Trade> trades = null, List<Quote> quotes = null, List<SmsVerificationMessage> smsVerificationMessages = null, List<TradingAmount> tradingAmounts = null, List<RippleDestinationTag> rippleDestinationTags = null, List<BitcoinBasedCurrency> bitcoinBasedCurrencies = null, List<ERC20Token> eRC20Tokens = null, List<BalanceAction> balanceActions = null, List<KeyValue> keysValues = null, List<IApplicationTokenAccess> applicationTokenAccesses = null, List<IApplicationQrCommand> applicationQrCommands = null, List<PushToken> pushTokens = null, List<StringIdentityUserRole> userRoles = null, List<IdentityRole> roles = null, List<StringIdentityRoleClaim> roleClaims = null, List<ApplicationUser> users = null, List<StringIdentityUserClaim> userClaims = null, List<StringIdentityUserLogin> userLogins = null, List<StringIdentityUserToken> userTokens = null, Guid? databaseCurrentTransactionTransactionId = null, bool? databaseAutoTransactionsEnabled = null, string databaseProviderName = null, bool? changeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerCascadeDeleteTiming = null, Guid? changeTrackerContextDatabaseCurrentTransactionTransactionId = null, bool? changeTrackerContextDatabaseAutoTransactionsEnabled = null, string changeTrackerContextDatabaseProviderName = null, bool? changeTrackerContextChangeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerContextChangeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerContextChangeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerContextChangeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerContextChangeTrackerCascadeDeleteTiming = null, DbContext changeTrackerContextChangeTrackerContext = null, Object changeTrackerContextModel = null, Guid? changeTrackerContextContextIdInstanceId = null, int? changeTrackerContextContextIdLease = null, Object model = null, Guid? contextIdInstanceId = null, int? contextIdLease = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetapptokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var cryptoCurrencies = new List<CryptoCurrency>(); // List<CryptoCurrency> |  (optional) 
            var orders = new List<Order>(); // List<Order> |  (optional) 
            var depositAddresses = new List<DepositAddress>(); // List<DepositAddress> |  (optional) 
            var userBalances = new List<Balance>(); // List<Balance> |  (optional) 
            var markets = new List<Market>(); // List<Market> |  (optional) 
            var tradingPairs = new List<TradingPair>(); // List<TradingPair> |  (optional) 
            var transactions = new List<Transaction>(); // List<Transaction> |  (optional) 
            var withdrawRequests = new List<WithdrawRequest>(); // List<WithdrawRequest> |  (optional) 
            var trades = new List<Trade>(); // List<Trade> |  (optional) 
            var quotes = new List<Quote>(); // List<Quote> |  (optional) 
            var smsVerificationMessages = new List<SmsVerificationMessage>(); // List<SmsVerificationMessage> |  (optional) 
            var tradingAmounts = new List<TradingAmount>(); // List<TradingAmount> |  (optional) 
            var rippleDestinationTags = new List<RippleDestinationTag>(); // List<RippleDestinationTag> |  (optional) 
            var bitcoinBasedCurrencies = new List<BitcoinBasedCurrency>(); // List<BitcoinBasedCurrency> |  (optional) 
            var eRC20Tokens = new List<ERC20Token>(); // List<ERC20Token> |  (optional) 
            var balanceActions = new List<BalanceAction>(); // List<BalanceAction> |  (optional) 
            var keysValues = new List<KeyValue>(); // List<KeyValue> |  (optional) 
            var applicationTokenAccesses = new List<IApplicationTokenAccess>(); // List<IApplicationTokenAccess> |  (optional) 
            var applicationQrCommands = new List<IApplicationQrCommand>(); // List<IApplicationQrCommand> |  (optional) 
            var pushTokens = new List<PushToken>(); // List<PushToken> |  (optional) 
            var userRoles = new List<StringIdentityUserRole>(); // List<StringIdentityUserRole> |  (optional) 
            var roles = new List<IdentityRole>(); // List<IdentityRole> |  (optional) 
            var roleClaims = new List<StringIdentityRoleClaim>(); // List<StringIdentityRoleClaim> |  (optional) 
            var users = new List<ApplicationUser>(); // List<ApplicationUser> |  (optional) 
            var userClaims = new List<StringIdentityUserClaim>(); // List<StringIdentityUserClaim> |  (optional) 
            var userLogins = new List<StringIdentityUserLogin>(); // List<StringIdentityUserLogin> |  (optional) 
            var userTokens = new List<StringIdentityUserToken>(); // List<StringIdentityUserToken> |  (optional) 
            var databaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var databaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var databaseProviderName = databaseProviderName_example;  // string |  (optional) 
            var changeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextDatabaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextDatabaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextDatabaseProviderName = changeTrackerContextDatabaseProviderName_example;  // string |  (optional) 
            var changeTrackerContextChangeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerContextChangeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerContext = new DbContext(); // DbContext |  (optional) 
            var changeTrackerContextModel = new Object(); // Object |  (optional) 
            var changeTrackerContextContextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextContextIdLease = 56;  // int? |  (optional) 
            var model = new Object(); // Object |  (optional) 
            var contextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var contextIdLease = 56;  // int? |  (optional) 

            try
            {
                apiInstance.UserGetapptokenPost(cryptoCurrencies, orders, depositAddresses, userBalances, markets, tradingPairs, transactions, withdrawRequests, trades, quotes, smsVerificationMessages, tradingAmounts, rippleDestinationTags, bitcoinBasedCurrencies, eRC20Tokens, balanceActions, keysValues, applicationTokenAccesses, applicationQrCommands, pushTokens, userRoles, roles, roleClaims, users, userClaims, userLogins, userTokens, databaseCurrentTransactionTransactionId, databaseAutoTransactionsEnabled, databaseProviderName, changeTrackerAutoDetectChangesEnabled, changeTrackerLazyLoadingEnabled, changeTrackerQueryTrackingBehavior, changeTrackerDeleteOrphansTiming, changeTrackerCascadeDeleteTiming, changeTrackerContextDatabaseCurrentTransactionTransactionId, changeTrackerContextDatabaseAutoTransactionsEnabled, changeTrackerContextDatabaseProviderName, changeTrackerContextChangeTrackerAutoDetectChangesEnabled, changeTrackerContextChangeTrackerLazyLoadingEnabled, changeTrackerContextChangeTrackerQueryTrackingBehavior, changeTrackerContextChangeTrackerDeleteOrphansTiming, changeTrackerContextChangeTrackerCascadeDeleteTiming, changeTrackerContextChangeTrackerContext, changeTrackerContextModel, changeTrackerContextContextIdInstanceId, changeTrackerContextContextIdLease, model, contextIdInstanceId, contextIdLease);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetapptokenPost: " + e.Message );
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
 **cryptoCurrencies** | [**List&lt;CryptoCurrency&gt;**](CryptoCurrency.md)|  | [optional] 
 **orders** | [**List&lt;Order&gt;**](Order.md)|  | [optional] 
 **depositAddresses** | [**List&lt;DepositAddress&gt;**](DepositAddress.md)|  | [optional] 
 **userBalances** | [**List&lt;Balance&gt;**](Balance.md)|  | [optional] 
 **markets** | [**List&lt;Market&gt;**](Market.md)|  | [optional] 
 **tradingPairs** | [**List&lt;TradingPair&gt;**](TradingPair.md)|  | [optional] 
 **transactions** | [**List&lt;Transaction&gt;**](Transaction.md)|  | [optional] 
 **withdrawRequests** | [**List&lt;WithdrawRequest&gt;**](WithdrawRequest.md)|  | [optional] 
 **trades** | [**List&lt;Trade&gt;**](Trade.md)|  | [optional] 
 **quotes** | [**List&lt;Quote&gt;**](Quote.md)|  | [optional] 
 **smsVerificationMessages** | [**List&lt;SmsVerificationMessage&gt;**](SmsVerificationMessage.md)|  | [optional] 
 **tradingAmounts** | [**List&lt;TradingAmount&gt;**](TradingAmount.md)|  | [optional] 
 **rippleDestinationTags** | [**List&lt;RippleDestinationTag&gt;**](RippleDestinationTag.md)|  | [optional] 
 **bitcoinBasedCurrencies** | [**List&lt;BitcoinBasedCurrency&gt;**](BitcoinBasedCurrency.md)|  | [optional] 
 **eRC20Tokens** | [**List&lt;ERC20Token&gt;**](ERC20Token.md)|  | [optional] 
 **balanceActions** | [**List&lt;BalanceAction&gt;**](BalanceAction.md)|  | [optional] 
 **keysValues** | [**List&lt;KeyValue&gt;**](KeyValue.md)|  | [optional] 
 **applicationTokenAccesses** | [**List&lt;IApplicationTokenAccess&gt;**](IApplicationTokenAccess.md)|  | [optional] 
 **applicationQrCommands** | [**List&lt;IApplicationQrCommand&gt;**](IApplicationQrCommand.md)|  | [optional] 
 **pushTokens** | [**List&lt;PushToken&gt;**](PushToken.md)|  | [optional] 
 **userRoles** | [**List&lt;StringIdentityUserRole&gt;**](StringIdentityUserRole.md)|  | [optional] 
 **roles** | [**List&lt;IdentityRole&gt;**](IdentityRole.md)|  | [optional] 
 **roleClaims** | [**List&lt;StringIdentityRoleClaim&gt;**](StringIdentityRoleClaim.md)|  | [optional] 
 **users** | [**List&lt;ApplicationUser&gt;**](ApplicationUser.md)|  | [optional] 
 **userClaims** | [**List&lt;StringIdentityUserClaim&gt;**](StringIdentityUserClaim.md)|  | [optional] 
 **userLogins** | [**List&lt;StringIdentityUserLogin&gt;**](StringIdentityUserLogin.md)|  | [optional] 
 **userTokens** | [**List&lt;StringIdentityUserToken&gt;**](StringIdentityUserToken.md)|  | [optional] 
 **databaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **databaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **databaseProviderName** | **string**|  | [optional] 
 **changeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextDatabaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextDatabaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextDatabaseProviderName** | **string**|  | [optional] 
 **changeTrackerContextChangeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerContextChangeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerContext** | [**DbContext**](DbContext.md)|  | [optional] 
 **changeTrackerContextModel** | [**Object**](Object.md)|  | [optional] 
 **changeTrackerContextContextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextContextIdLease** | **int?**|  | [optional] 
 **model** | [**Object**](Object.md)|  | [optional] 
 **contextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **contextIdLease** | **int?**|  | [optional] 

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

<a name="usergetreferreremailpost"></a>
# **UserGetreferreremailPost**
> void UserGetreferreremailPost (PostGetReferrerEmailRequest postGetReferrerEmailRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetreferreremailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var postGetReferrerEmailRequest = new PostGetReferrerEmailRequest(); // PostGetReferrerEmailRequest |  (optional) 

            try
            {
                apiInstance.UserGetreferreremailPost(postGetReferrerEmailRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetreferreremailPost: " + e.Message );
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
 **postGetReferrerEmailRequest** | [**PostGetReferrerEmailRequest**](PostGetReferrerEmailRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userresetpasswordpost"></a>
# **UserResetpasswordPost**
> void UserResetpasswordPost (ResetPassword resetPassword = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserResetpasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var resetPassword = new ResetPassword(); // ResetPassword |  (optional) 

            try
            {
                apiInstance.UserResetpasswordPost(resetPassword);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserResetpasswordPost: " + e.Message );
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
 **resetPassword** | [**ResetPassword**](ResetPassword.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userrestorepasswordpost"></a>
# **UserRestorepasswordPost**
> void UserRestorepasswordPost (ForgotPassword forgotPassword = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserRestorepasswordPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var forgotPassword = new ForgotPassword(); // ForgotPassword |  (optional) 

            try
            {
                apiInstance.UserRestorepasswordPost(forgotPassword);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserRestorepasswordPost: " + e.Message );
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
 **forgotPassword** | [**ForgotPassword**](ForgotPassword.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersendsmscodepost"></a>
# **UserSendsmscodePost**
> void UserSendsmscodePost (PostSendSms postSendSms = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSendsmscodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var postSendSms = new PostSendSms(); // PostSendSms |  (optional) 

            try
            {
                apiInstance.UserSendsmscodePost(postSendSms);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSendsmscodePost: " + e.Message );
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
 **postSendSms** | [**PostSendSms**](PostSendSms.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersetaffiliatepost"></a>
# **UserSetAffiliatePost**
> void UserSetAffiliatePost (List<CryptoCurrency> cryptoCurrencies = null, List<Order> orders = null, List<DepositAddress> depositAddresses = null, List<Balance> userBalances = null, List<Market> markets = null, List<TradingPair> tradingPairs = null, List<Transaction> transactions = null, List<WithdrawRequest> withdrawRequests = null, List<Trade> trades = null, List<Quote> quotes = null, List<SmsVerificationMessage> smsVerificationMessages = null, List<TradingAmount> tradingAmounts = null, List<RippleDestinationTag> rippleDestinationTags = null, List<BitcoinBasedCurrency> bitcoinBasedCurrencies = null, List<ERC20Token> eRC20Tokens = null, List<BalanceAction> balanceActions = null, List<KeyValue> keysValues = null, List<IApplicationTokenAccess> applicationTokenAccesses = null, List<IApplicationQrCommand> applicationQrCommands = null, List<PushToken> pushTokens = null, List<StringIdentityUserRole> userRoles = null, List<IdentityRole> roles = null, List<StringIdentityRoleClaim> roleClaims = null, List<ApplicationUser> users = null, List<StringIdentityUserClaim> userClaims = null, List<StringIdentityUserLogin> userLogins = null, List<StringIdentityUserToken> userTokens = null, Guid? databaseCurrentTransactionTransactionId = null, bool? databaseAutoTransactionsEnabled = null, string databaseProviderName = null, bool? changeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerCascadeDeleteTiming = null, Guid? changeTrackerContextDatabaseCurrentTransactionTransactionId = null, bool? changeTrackerContextDatabaseAutoTransactionsEnabled = null, string changeTrackerContextDatabaseProviderName = null, bool? changeTrackerContextChangeTrackerAutoDetectChangesEnabled = null, bool? changeTrackerContextChangeTrackerLazyLoadingEnabled = null, QueryTrackingBehavior? changeTrackerContextChangeTrackerQueryTrackingBehavior = null, CascadeTiming? changeTrackerContextChangeTrackerDeleteOrphansTiming = null, CascadeTiming? changeTrackerContextChangeTrackerCascadeDeleteTiming = null, DbContext changeTrackerContextChangeTrackerContext = null, Object changeTrackerContextModel = null, Guid? changeTrackerContextContextIdInstanceId = null, int? changeTrackerContextContextIdLease = null, Object model = null, Guid? contextIdInstanceId = null, int? contextIdLease = null, PostSetAffiliateRequest postSetAffiliateRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSetAffiliatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var cryptoCurrencies = new List<CryptoCurrency>(); // List<CryptoCurrency> |  (optional) 
            var orders = new List<Order>(); // List<Order> |  (optional) 
            var depositAddresses = new List<DepositAddress>(); // List<DepositAddress> |  (optional) 
            var userBalances = new List<Balance>(); // List<Balance> |  (optional) 
            var markets = new List<Market>(); // List<Market> |  (optional) 
            var tradingPairs = new List<TradingPair>(); // List<TradingPair> |  (optional) 
            var transactions = new List<Transaction>(); // List<Transaction> |  (optional) 
            var withdrawRequests = new List<WithdrawRequest>(); // List<WithdrawRequest> |  (optional) 
            var trades = new List<Trade>(); // List<Trade> |  (optional) 
            var quotes = new List<Quote>(); // List<Quote> |  (optional) 
            var smsVerificationMessages = new List<SmsVerificationMessage>(); // List<SmsVerificationMessage> |  (optional) 
            var tradingAmounts = new List<TradingAmount>(); // List<TradingAmount> |  (optional) 
            var rippleDestinationTags = new List<RippleDestinationTag>(); // List<RippleDestinationTag> |  (optional) 
            var bitcoinBasedCurrencies = new List<BitcoinBasedCurrency>(); // List<BitcoinBasedCurrency> |  (optional) 
            var eRC20Tokens = new List<ERC20Token>(); // List<ERC20Token> |  (optional) 
            var balanceActions = new List<BalanceAction>(); // List<BalanceAction> |  (optional) 
            var keysValues = new List<KeyValue>(); // List<KeyValue> |  (optional) 
            var applicationTokenAccesses = new List<IApplicationTokenAccess>(); // List<IApplicationTokenAccess> |  (optional) 
            var applicationQrCommands = new List<IApplicationQrCommand>(); // List<IApplicationQrCommand> |  (optional) 
            var pushTokens = new List<PushToken>(); // List<PushToken> |  (optional) 
            var userRoles = new List<StringIdentityUserRole>(); // List<StringIdentityUserRole> |  (optional) 
            var roles = new List<IdentityRole>(); // List<IdentityRole> |  (optional) 
            var roleClaims = new List<StringIdentityRoleClaim>(); // List<StringIdentityRoleClaim> |  (optional) 
            var users = new List<ApplicationUser>(); // List<ApplicationUser> |  (optional) 
            var userClaims = new List<StringIdentityUserClaim>(); // List<StringIdentityUserClaim> |  (optional) 
            var userLogins = new List<StringIdentityUserLogin>(); // List<StringIdentityUserLogin> |  (optional) 
            var userTokens = new List<StringIdentityUserToken>(); // List<StringIdentityUserToken> |  (optional) 
            var databaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var databaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var databaseProviderName = databaseProviderName_example;  // string |  (optional) 
            var changeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextDatabaseCurrentTransactionTransactionId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextDatabaseAutoTransactionsEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextDatabaseProviderName = changeTrackerContextDatabaseProviderName_example;  // string |  (optional) 
            var changeTrackerContextChangeTrackerAutoDetectChangesEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerLazyLoadingEnabled = true;  // bool? |  (optional) 
            var changeTrackerContextChangeTrackerQueryTrackingBehavior = ;  // QueryTrackingBehavior? |  (optional) 
            var changeTrackerContextChangeTrackerDeleteOrphansTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerCascadeDeleteTiming = ;  // CascadeTiming? |  (optional) 
            var changeTrackerContextChangeTrackerContext = new DbContext(); // DbContext |  (optional) 
            var changeTrackerContextModel = new Object(); // Object |  (optional) 
            var changeTrackerContextContextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var changeTrackerContextContextIdLease = 56;  // int? |  (optional) 
            var model = new Object(); // Object |  (optional) 
            var contextIdInstanceId = new Guid?(); // Guid? |  (optional) 
            var contextIdLease = 56;  // int? |  (optional) 
            var postSetAffiliateRequest = new PostSetAffiliateRequest(); // PostSetAffiliateRequest |  (optional) 

            try
            {
                apiInstance.UserSetAffiliatePost(cryptoCurrencies, orders, depositAddresses, userBalances, markets, tradingPairs, transactions, withdrawRequests, trades, quotes, smsVerificationMessages, tradingAmounts, rippleDestinationTags, bitcoinBasedCurrencies, eRC20Tokens, balanceActions, keysValues, applicationTokenAccesses, applicationQrCommands, pushTokens, userRoles, roles, roleClaims, users, userClaims, userLogins, userTokens, databaseCurrentTransactionTransactionId, databaseAutoTransactionsEnabled, databaseProviderName, changeTrackerAutoDetectChangesEnabled, changeTrackerLazyLoadingEnabled, changeTrackerQueryTrackingBehavior, changeTrackerDeleteOrphansTiming, changeTrackerCascadeDeleteTiming, changeTrackerContextDatabaseCurrentTransactionTransactionId, changeTrackerContextDatabaseAutoTransactionsEnabled, changeTrackerContextDatabaseProviderName, changeTrackerContextChangeTrackerAutoDetectChangesEnabled, changeTrackerContextChangeTrackerLazyLoadingEnabled, changeTrackerContextChangeTrackerQueryTrackingBehavior, changeTrackerContextChangeTrackerDeleteOrphansTiming, changeTrackerContextChangeTrackerCascadeDeleteTiming, changeTrackerContextChangeTrackerContext, changeTrackerContextModel, changeTrackerContextContextIdInstanceId, changeTrackerContextContextIdLease, model, contextIdInstanceId, contextIdLease, postSetAffiliateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSetAffiliatePost: " + e.Message );
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
 **cryptoCurrencies** | [**List&lt;CryptoCurrency&gt;**](CryptoCurrency.md)|  | [optional] 
 **orders** | [**List&lt;Order&gt;**](Order.md)|  | [optional] 
 **depositAddresses** | [**List&lt;DepositAddress&gt;**](DepositAddress.md)|  | [optional] 
 **userBalances** | [**List&lt;Balance&gt;**](Balance.md)|  | [optional] 
 **markets** | [**List&lt;Market&gt;**](Market.md)|  | [optional] 
 **tradingPairs** | [**List&lt;TradingPair&gt;**](TradingPair.md)|  | [optional] 
 **transactions** | [**List&lt;Transaction&gt;**](Transaction.md)|  | [optional] 
 **withdrawRequests** | [**List&lt;WithdrawRequest&gt;**](WithdrawRequest.md)|  | [optional] 
 **trades** | [**List&lt;Trade&gt;**](Trade.md)|  | [optional] 
 **quotes** | [**List&lt;Quote&gt;**](Quote.md)|  | [optional] 
 **smsVerificationMessages** | [**List&lt;SmsVerificationMessage&gt;**](SmsVerificationMessage.md)|  | [optional] 
 **tradingAmounts** | [**List&lt;TradingAmount&gt;**](TradingAmount.md)|  | [optional] 
 **rippleDestinationTags** | [**List&lt;RippleDestinationTag&gt;**](RippleDestinationTag.md)|  | [optional] 
 **bitcoinBasedCurrencies** | [**List&lt;BitcoinBasedCurrency&gt;**](BitcoinBasedCurrency.md)|  | [optional] 
 **eRC20Tokens** | [**List&lt;ERC20Token&gt;**](ERC20Token.md)|  | [optional] 
 **balanceActions** | [**List&lt;BalanceAction&gt;**](BalanceAction.md)|  | [optional] 
 **keysValues** | [**List&lt;KeyValue&gt;**](KeyValue.md)|  | [optional] 
 **applicationTokenAccesses** | [**List&lt;IApplicationTokenAccess&gt;**](IApplicationTokenAccess.md)|  | [optional] 
 **applicationQrCommands** | [**List&lt;IApplicationQrCommand&gt;**](IApplicationQrCommand.md)|  | [optional] 
 **pushTokens** | [**List&lt;PushToken&gt;**](PushToken.md)|  | [optional] 
 **userRoles** | [**List&lt;StringIdentityUserRole&gt;**](StringIdentityUserRole.md)|  | [optional] 
 **roles** | [**List&lt;IdentityRole&gt;**](IdentityRole.md)|  | [optional] 
 **roleClaims** | [**List&lt;StringIdentityRoleClaim&gt;**](StringIdentityRoleClaim.md)|  | [optional] 
 **users** | [**List&lt;ApplicationUser&gt;**](ApplicationUser.md)|  | [optional] 
 **userClaims** | [**List&lt;StringIdentityUserClaim&gt;**](StringIdentityUserClaim.md)|  | [optional] 
 **userLogins** | [**List&lt;StringIdentityUserLogin&gt;**](StringIdentityUserLogin.md)|  | [optional] 
 **userTokens** | [**List&lt;StringIdentityUserToken&gt;**](StringIdentityUserToken.md)|  | [optional] 
 **databaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **databaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **databaseProviderName** | **string**|  | [optional] 
 **changeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextDatabaseCurrentTransactionTransactionId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextDatabaseAutoTransactionsEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextDatabaseProviderName** | **string**|  | [optional] 
 **changeTrackerContextChangeTrackerAutoDetectChangesEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerLazyLoadingEnabled** | **bool?**|  | [optional] 
 **changeTrackerContextChangeTrackerQueryTrackingBehavior** | **QueryTrackingBehavior?**|  | [optional] 
 **changeTrackerContextChangeTrackerDeleteOrphansTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerCascadeDeleteTiming** | **CascadeTiming?**|  | [optional] 
 **changeTrackerContextChangeTrackerContext** | [**DbContext**](DbContext.md)|  | [optional] 
 **changeTrackerContextModel** | [**Object**](Object.md)|  | [optional] 
 **changeTrackerContextContextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **changeTrackerContextContextIdLease** | **int?**|  | [optional] 
 **model** | [**Object**](Object.md)|  | [optional] 
 **contextIdInstanceId** | [**Guid?**](Guid?.md)|  | [optional] 
 **contextIdLease** | **int?**|  | [optional] 
 **postSetAffiliateRequest** | [**PostSetAffiliateRequest**](PostSetAffiliateRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersigninpost"></a>
# **UserSigninPost**
> void UserSigninPost (SignIn signIn = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSigninPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var signIn = new SignIn(); // SignIn |  (optional) 

            try
            {
                apiInstance.UserSigninPost(signIn);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSigninPost: " + e.Message );
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
 **signIn** | [**SignIn**](SignIn.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersignuppost"></a>
# **UserSignupPost**
> void UserSignupPost (SignUp signUp = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSignupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var signUp = new SignUp(); // SignUp |  (optional) 

            try
            {
                apiInstance.UserSignupPost(signUp);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSignupPost: " + e.Message );
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
 **signUp** | [**SignUp**](SignUp.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uservalidatepinpost"></a>
# **UserValidatePinPost**
> void UserValidatePinPost (Object body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserValidatePinPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.UserValidatePinPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserValidatePinPost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userverificationsget"></a>
# **UserVerificationsGet**
> void UserVerificationsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserVerificationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);

            try
            {
                apiInstance.UserVerificationsGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserVerificationsGet: " + e.Message );
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

<a name="userverifysmscodepost"></a>
# **UserVerifysmscodePost**
> void UserVerifysmscodePost (PostVefirySms postVefirySms = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserVerifysmscodePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var postVefirySms = new PostVefirySms(); // PostVefirySms |  (optional) 

            try
            {
                apiInstance.UserVerifysmscodePost(postVefirySms);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserVerifysmscodePost: " + e.Message );
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
 **postVefirySms** | [**PostVefirySms**](PostVefirySms.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userwithdrawalsget"></a>
# **UserWithdrawalsGet**
> void UserWithdrawalsGet (string currency = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserWithdrawalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UserApi(config);
            var currency = currency_example;  // string |  (optional) 

            try
            {
                apiInstance.UserWithdrawalsGet(currency);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserWithdrawalsGet: " + e.Message );
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
 **currency** | **string**|  | [optional] 

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

