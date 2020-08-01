# Org.OpenAPITools - the C# library for the BITFLEX Public API

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost:5000";
            // Configure API key authorization: Bearer
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AdminApi(config);
            var body = ;  // Object |  (optional) 

            try
            {
                apiInstance.ApiAdminAddcointokenPost(body);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AdminApi.ApiAdminAddcointokenPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost:5000*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AdminApi* | [**ApiAdminAddcointokenPost**](docs/AdminApi.md#apiadminaddcointokenpost) | **POST** /api/Admin/addcointoken | 
*BalanceApi* | [**BalanceCurrencyGet**](docs/BalanceApi.md#balancecurrencyget) | **GET** /Balance/{currency} | 
*BalanceApi* | [**BalanceDepositCurrencyAddressGet**](docs/BalanceApi.md#balancedepositcurrencyaddressget) | **GET** /Balance/deposit/{currency}/address | 
*BalanceApi* | [**BalanceDepositCurrencyAddressPost**](docs/BalanceApi.md#balancedepositcurrencyaddresspost) | **POST** /Balance/deposit/{currency}/address | 
*BalanceApi* | [**BalanceRoute**](docs/BalanceApi.md#balanceroute) | **GET** /Balance | 
*BalanceApi* | [**BalanceWithdrawCurrencyPageGet**](docs/BalanceApi.md#balancewithdrawcurrencypageget) | **GET** /Balance/withdraw/{currency}/page | 
*BalanceApi* | [**BalanceWithdrawCurrencyPost**](docs/BalanceApi.md#balancewithdrawcurrencypost) | **POST** /Balance/withdraw/{currency} | 
*CognitiveApi* | [**CognitiveSavefilePost**](docs/CognitiveApi.md#cognitivesavefilepost) | **POST** /Cognitive/savefile | 
*CognitiveApi* | [**CognitiveVerifyfacesPost**](docs/CognitiveApi.md#cognitiveverifyfacespost) | **POST** /Cognitive/verifyfaces | 
*MarketsApi* | [**ApiMarketsCurrenciesGet**](docs/MarketsApi.md#apimarketscurrenciesget) | **GET** /api/Markets/currencies | 
*MarketsApi* | [**ApiMarketsGet**](docs/MarketsApi.md#apimarketsget) | **GET** /api/Markets | 
*MarketsApi* | [**ApiMarketsHistoryGet**](docs/MarketsApi.md#apimarketshistoryget) | **GET** /api/Markets/history | 
*MarketsApi* | [**ApiMarketsOrderbookGet**](docs/MarketsApi.md#apimarketsorderbookget) | **GET** /api/Markets/orderbook | 
*MarketsApi* | [**ApiMarketsTickersGet**](docs/MarketsApi.md#apimarketstickersget) | **GET** /api/Markets/tickers | 
*OrdersApi* | [**OrdersCancelPost**](docs/OrdersApi.md#orderscancelpost) | **POST** /Orders/cancel | 
*OrdersApi* | [**OrdersPairNameGet**](docs/OrdersApi.md#orderspairnameget) | **GET** /Orders/{pairName} | 
*OrdersApi* | [**OrdersPost**](docs/OrdersApi.md#orderspost) | **POST** /Orders | 
*StaticPagesApi* | [**StaticPagesAffiliateGet**](docs/StaticPagesApi.md#staticpagesaffiliateget) | **GET** /StaticPages/affiliate | 
*StaticPagesApi* | [**StaticPagesStatusGet**](docs/StaticPagesApi.md#staticpagesstatusget) | **GET** /StaticPages/status | 
*TradingViewUdfApi* | [**ApiTradingViewUdfConfigGet**](docs/TradingViewUdfApi.md#apitradingviewudfconfigget) | **GET** /api/TradingViewUdf/config | 
*TradingViewUdfApi* | [**ApiTradingViewUdfHistoryGet**](docs/TradingViewUdfApi.md#apitradingviewudfhistoryget) | **GET** /api/TradingViewUdf/history | 
*TradingViewUdfApi* | [**ApiTradingViewUdfSymbolsGet**](docs/TradingViewUdfApi.md#apitradingviewudfsymbolsget) | **GET** /api/TradingViewUdf/symbols | 
*TradingViewUdfApi* | [**ApiTradingViewUdfTimeGet**](docs/TradingViewUdfApi.md#apitradingviewudftimeget) | **GET** /api/TradingViewUdf/time | 
*UserApi* | [**ApiUserBalanceactionsGet**](docs/UserApi.md#apiuserbalanceactionsget) | **GET** /api/User/balanceactions | 
*UserApi* | [**ApiUserBalancesGet**](docs/UserApi.md#apiuserbalancesget) | **GET** /api/User/balances | 
*UserApi* | [**ApiUserBalanceslistGet**](docs/UserApi.md#apiuserbalanceslistget) | **GET** /api/User/balanceslist | 
*UserApi* | [**ApiUserDepositsGet**](docs/UserApi.md#apiuserdepositsget) | **GET** /api/User/deposits | 
*UserApi* | [**ApiUserGetapptokenGet**](docs/UserApi.md#apiusergetapptokenget) | **GET** /api/User/getapptoken | 
*UserApi* | [**ApiUserOrdersGet**](docs/UserApi.md#apiuserordersget) | **GET** /api/User/orders | 
*UserApi* | [**ApiUserTradehistoryGet**](docs/UserApi.md#apiusertradehistoryget) | **GET** /api/User/tradehistory | 
*UserApi* | [**ApiUserValidateOauthGet**](docs/UserApi.md#apiuservalidateoauthget) | **GET** /api/User/validateOauth | 
*UserApi* | [**ApiUserValidateapptokenPost**](docs/UserApi.md#apiuservalidateapptokenpost) | **POST** /api/User/validateapptoken | 
*UserApi* | [**ApiUserWithdrawalsGet**](docs/UserApi.md#apiuserwithdrawalsget) | **GET** /api/User/withdrawals | 
*UserApi* | [**User2faPost**](docs/UserApi.md#user2fapost) | **POST** /User/2fa | 
*UserApi* | [**UserAffiliatedataPost**](docs/UserApi.md#useraffiliatedatapost) | **POST** /User/affiliatedata | 
*UserApi* | [**UserApplicationqrcommandPost**](docs/UserApi.md#userapplicationqrcommandpost) | **POST** /User/applicationqrcommand | 
*UserApi* | [**UserConfirmemailGet**](docs/UserApi.md#userconfirmemailget) | **GET** /User/confirmemail | 
*UserApi* | [**UserDisable2faPost**](docs/UserApi.md#userdisable2fapost) | **POST** /User/disable2fa | 
*UserApi* | [**UserEnable2faPost**](docs/UserApi.md#userenable2fapost) | **POST** /User/enable2fa | 
*UserApi* | [**UserExternaltokenPost**](docs/UserApi.md#userexternaltokenpost) | **POST** /User/externaltoken | 
*UserApi* | [**UserGetapptokenPost**](docs/UserApi.md#usergetapptokenpost) | **POST** /User/getapptoken | 
*UserApi* | [**UserGetreferreremailPost**](docs/UserApi.md#usergetreferreremailpost) | **POST** /User/getreferreremail | 
*UserApi* | [**UserResetpasswordPost**](docs/UserApi.md#userresetpasswordpost) | **POST** /User/resetpassword | 
*UserApi* | [**UserRestorepasswordPost**](docs/UserApi.md#userrestorepasswordpost) | **POST** /User/restorepassword | 
*UserApi* | [**UserSendsmscodePost**](docs/UserApi.md#usersendsmscodepost) | **POST** /User/sendsmscode | 
*UserApi* | [**UserSetAffiliatePost**](docs/UserApi.md#usersetaffiliatepost) | **POST** /User/setAffiliate | 
*UserApi* | [**UserSigninPost**](docs/UserApi.md#usersigninpost) | **POST** /User/signin | 
*UserApi* | [**UserSignupPost**](docs/UserApi.md#usersignuppost) | **POST** /User/signup | 
*UserApi* | [**UserValidatePinPost**](docs/UserApi.md#uservalidatepinpost) | **POST** /User/validatePin | 
*UserApi* | [**UserVerificationsGet**](docs/UserApi.md#userverificationsget) | **GET** /User/verifications | 
*UserApi* | [**UserVerifysmscodePost**](docs/UserApi.md#userverifysmscodepost) | **POST** /User/verifysmscode | 
*UserApi* | [**UserWithdrawalsGet**](docs/UserApi.md#userwithdrawalsget) | **GET** /User/withdrawals | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApplicationUser](docs/ApplicationUser.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.BalanceAction](docs/BalanceAction.md)
 - [Model.BalanceActionType](docs/BalanceActionType.md)
 - [Model.BitcoinBasedCurrency](docs/BitcoinBasedCurrency.md)
 - [Model.CascadeTiming](docs/CascadeTiming.md)
 - [Model.ChangeTracker](docs/ChangeTracker.md)
 - [Model.CryptoCurrency](docs/CryptoCurrency.md)
 - [Model.DatabaseFacade](docs/DatabaseFacade.md)
 - [Model.DbContext](docs/DbContext.md)
 - [Model.DbContextId](docs/DbContextId.md)
 - [Model.DepositAddress](docs/DepositAddress.md)
 - [Model.DeviceType](docs/DeviceType.md)
 - [Model.ERC20Token](docs/ERC20Token.md)
 - [Model.EnableDisable2Fa](docs/EnableDisable2Fa.md)
 - [Model.ForgotPassword](docs/ForgotPassword.md)
 - [Model.IApplicationQrCommand](docs/IApplicationQrCommand.md)
 - [Model.IApplicationTokenAccess](docs/IApplicationTokenAccess.md)
 - [Model.IDbContextTransaction](docs/IDbContextTransaction.md)
 - [Model.IdentityRole](docs/IdentityRole.md)
 - [Model.InlineObject](docs/InlineObject.md)
 - [Model.KeyValue](docs/KeyValue.md)
 - [Model.Market](docs/Market.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderState](docs/OrderState.md)
 - [Model.OrderTypes](docs/OrderTypes.md)
 - [Model.PostCancelOrderRequest](docs/PostCancelOrderRequest.md)
 - [Model.PostGetReferrerEmailRequest](docs/PostGetReferrerEmailRequest.md)
 - [Model.PostOrdersRequest](docs/PostOrdersRequest.md)
 - [Model.PostSendSms](docs/PostSendSms.md)
 - [Model.PostSetAffiliateRequest](docs/PostSetAffiliateRequest.md)
 - [Model.PostVefirySms](docs/PostVefirySms.md)
 - [Model.PostWithdrawRequest](docs/PostWithdrawRequest.md)
 - [Model.PushToken](docs/PushToken.md)
 - [Model.QrCommand](docs/QrCommand.md)
 - [Model.QueryTrackingBehavior](docs/QueryTrackingBehavior.md)
 - [Model.Quote](docs/Quote.md)
 - [Model.ResetPassword](docs/ResetPassword.md)
 - [Model.RippleDestinationTag](docs/RippleDestinationTag.md)
 - [Model.SignIn](docs/SignIn.md)
 - [Model.SignUp](docs/SignUp.md)
 - [Model.SmsVerificationMessage](docs/SmsVerificationMessage.md)
 - [Model.StringIdentityRoleClaim](docs/StringIdentityRoleClaim.md)
 - [Model.StringIdentityUserClaim](docs/StringIdentityUserClaim.md)
 - [Model.StringIdentityUserLogin](docs/StringIdentityUserLogin.md)
 - [Model.StringIdentityUserRole](docs/StringIdentityUserRole.md)
 - [Model.StringIdentityUserToken](docs/StringIdentityUserToken.md)
 - [Model.Trade](docs/Trade.md)
 - [Model.TradeType](docs/TradeType.md)
 - [Model.TradingAmount](docs/TradingAmount.md)
 - [Model.TradingPair](docs/TradingPair.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionDirection](docs/TransactionDirection.md)
 - [Model.Type](docs/Type.md)
 - [Model.UserCategory](docs/UserCategory.md)
 - [Model.WithdrawRequest](docs/WithdrawRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
