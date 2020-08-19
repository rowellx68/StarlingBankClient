# Getting started

This is an unofficial C# .NET Standard SDK for Starling Bank's API. Starling's API enables seamless integration of Starling account and transactional data into your application.
You can, subject to permission, use it to view account holder data and to automate actions on their accounts.

Before using the SDK, please follow the steps defined at [Getting started] (https://developer.starlingbank.com/get-started)

## Nuget

[![NuGet version (StarlingBank)](https://img.shields.io/nuget/v/StarlingBank.svg?style=flat-square)](https://www.nuget.org/packages/StarlingBank/)

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 or above for compilation."
1. Open the solution (StarlingBankClient.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.


## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the StarlingBankClient library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.


### 3. Add reference of the library project

In order to use the StarlingBankClient library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` StarlingBankClient.Tests ``` and click ``` OK ```. By doing this, we have added a reference of the ```StarlingBankClient.Tests``` project into the new ``` TestConsoleProject ```.

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.


## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | OAuth 2.0 Access Token |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // OAuth 2.0 Access Token

StarlingBankClient client = new StarlingBankClient(StarlingBankClient.Configuration.Environments.SANDBOX, oAuthAccessToken);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [WebhooksController](#webhooks_controller)
* [AccountsController](#accounts_controller)
* [BusinessesController](#businesses_controller)
* [IndividualsAndSoleTradersController](#individuals_and_sole_traders_controller)
* [JointAccountsController](#joint_accounts_controller)
* [SoleTradersController](#sole_traders_controller)
* [SpendingInsightsController](#spending_insights_controller)
* [AccountHoldersController](#account_holders_controller)
* [ProfileImagesController](#profile_images_controller)
* [AddressesController](#addresses_controller)
* [CardsController](#cards_controller)
* [RecurringCardPaymentsController](#recurring_card_payments_controller)
* [DirectDebitMandatesController](#direct_debit_mandates_controller)
* [TransactionFeedController](#transaction_feed_controller)
* [FeedRoundUpController](#feed_round_up_controller)
* [APIUserIdentitiesController](#api_user_identities_controller)
* [KYCController](#kyc_controller)
* [PaymentsController](#payments_controller)
* [OnboardingController](#onboarding_controller)
* [PayeesController](#payees_controller)
* [SavingsGoalsController](#savings_goals_controller)
* [SettleUpController](#settle_up_controller)
* [SubscriptionsController](#subscriptions_controller)

## <a name="webhooks_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.WebhooksController") WebhooksController

### Get singleton instance

The singleton instance of the ``` WebhooksController ``` class can be accessed from the API Client.

```csharp
IWebhooksController webhooks = client.Webhooks;
```

### <a name="create_dispatch_webhook"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.WebhooksController.CreateDispatchWebhook") CreateDispatchWebhook

> TODO: Add a method description


```csharp
Task CreateDispatchWebhook(StarlingBankClient.Models.DefaultWebhookPayloadModel body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new StarlingBankClient.Models.DefaultWebhookPayloadModel();

await webhooks.CreateDispatchWebhook(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="accounts_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.AccountsController") AccountsController

### Get singleton instance

The singleton instance of the ``` AccountsController ``` class can be accessed from the API Client.

```csharp
IAccountsController accounts = client.Accounts;
```

### <a name="get_accounts"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetAccounts") GetAccounts

> This endpoint lists an account holder's bank accounts.
> An account holder, such as a PCA (a *personal current account* - which should really be thought of as a *personal current account holder*), may have many accounts, such as a personal GBP and personal EUR account.
> This is different from the idea of an individual (a human/natural person), and is different from a person (a natural (human)/legal (company) person).
> 
> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.Accounts> GetAccounts()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Accounts result = await accounts.GetAccounts();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_available_periods"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetAvailablePeriods") GetAvailablePeriods

> Get list of statement periods which are available for an account


```csharp
Task<StarlingBankClient.Models.AccountStatementPeriods> GetAvailablePeriods(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.AccountStatementPeriods result = await accounts.GetAvailablePeriods(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_account_identifiers"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetAccountIdentifiers") GetAccountIdentifiers

> Identifiers come in pairs:
> 
> * A bank identifier, which identifies the bank
> * An account identifier, which identifiers the account at the bank
> 
> Identifiers can be:
> * Sort code and account number for domestic UK payments
> * BIC and IBAN for international payments
> * ABA and ACH routing numbers for domestic US payments


```csharp
Task<StarlingBankClient.Models.AccountIdentifiers> GetAccountIdentifiers(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.AccountIdentifiers result = await accounts.GetAccountIdentifiers(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_account_balance"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetAccountBalance") GetAccountBalance

> The balance of the account holder's account is expressed in two ways: cleared balance and effective balance.
> * The **cleared balance** is the balance of settled transactions and so does not include pending transactions. The cleared end of day balance is used to calculate interest.
> * The **effective balance** is the balance of settled and pending outgoing transactions. This is the balance most commonly presented to the account holder (e.g. in-app).
> 
> Many payment types settle effectively instantly (e.g. faster payments). Card transactions usually take a few days to settle and will remain pending for this time. We've actually got a blog on [how card transactions work](https://www.starlingbank.com/blog/card-transactions-explained/).
> 
> To check whether the account has enough money to make a payment, use the confirmation of funds endpoint instead.


```csharp
Task<StarlingBankClient.Models.BalanceV2> GetAccountBalance(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.BalanceV2 result = await accounts.GetAccountBalance(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_confirmation_of_funds"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetConfirmationOfFunds") GetConfirmationOfFunds

> Get whether there are available funds for a requested amount


```csharp
Task<StarlingBankClient.Models.ConfirmationOfFundsResponse> GetConfirmationOfFunds(Guid accountUid, long targetAmountInMinorUnits)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| targetAmountInMinorUnits |  ``` Required ```  | Target amount in minor units |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
long targetAmountInMinorUnits = 70;

StarlingBankClient.Models.ConfirmationOfFundsResponse result = await accounts.GetConfirmationOfFunds(accountUid, targetAmountInMinorUnits);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_download_csv_statement"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetDownloadCSVStatement") GetDownloadCSVStatement

> To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'


```csharp
Task<Stream> GetDownloadCSVStatement(Guid accountUid, string yearMonth)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | TODO: Add a parameter description |
| yearMonth |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
string yearMonth = "2020-08";

Stream result = await accounts.GetDownloadCSVStatement(accountUid, yearMonth);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_download_csv_statement_for_date_range"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountsController.GetDownloadCSVStatementForDateRange") GetDownloadCSVStatementForDateRange

> To choose a file format, set the Accept header to either 'application/pdf' or 'text/csv'


```csharp
Task<Stream> GetDownloadCSVStatementForDateRange(Guid accountUid, DateTime start, DateTime? end = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | TODO: Add a parameter description |
| start |  ``` Required ```  | TODO: Add a parameter description |
| end |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
DateTime start = 2020-08-17;
DateTime? end = 2020-08-17;

Stream result = await accounts.GetDownloadCSVStatementForDateRange(accountUid, start, end);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="businesses_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.BusinessesController") BusinessesController

### Get singleton instance

The singleton instance of the ``` BusinessesController ``` class can be accessed from the API Client.

```csharp
IBusinessesController businesses = client.Businesses;
```

### <a name="get_business"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.BusinessesController.GetBusiness") GetBusiness

> Get a business account holder's details


```csharp
Task<StarlingBankClient.Models.Business> GetBusiness()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Business result = await businesses.GetBusiness();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_registered_address"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.BusinessesController.GetRegisteredAddress") GetRegisteredAddress

> Get a company's registered address


```csharp
Task<StarlingBankClient.Models.AddressV2> GetRegisteredAddress()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AddressV2 result = await businesses.GetRegisteredAddress();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_correspondence_address"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.BusinessesController.GetCorrespondenceAddress") GetCorrespondenceAddress

> Will fallback to registered address if not available


```csharp
Task<StarlingBankClient.Models.AddressV2> GetCorrespondenceAddress()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AddressV2 result = await businesses.GetCorrespondenceAddress();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="individuals_and_sole_traders_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.IndividualsAndSoleTradersController") IndividualsAndSoleTradersController

### Get singleton instance

The singleton instance of the ``` IndividualsAndSoleTradersController ``` class can be accessed from the API Client.

```csharp
IIndividualsAndSoleTradersController individualsAndSoleTraders = client.IndividualsAndSoleTraders;
```

### <a name="get_individual"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.IndividualsAndSoleTradersController.GetIndividual") GetIndividual

> Get an individual account holder's details


```csharp
Task<StarlingBankClient.Models.Individual> GetIndividual()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Individual result = await individualsAndSoleTraders.GetIndividual();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_email"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.IndividualsAndSoleTradersController.UpdateEmail") UpdateEmail

> Update an individual account holder's email address


```csharp
Task UpdateEmail(StarlingBankClient.Models.UpdateEmailRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new StarlingBankClient.Models.UpdateEmailRequest();

await individualsAndSoleTraders.UpdateEmail(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="joint_accounts_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.JointAccountsController") JointAccountsController

### Get singleton instance

The singleton instance of the ``` JointAccountsController ``` class can be accessed from the API Client.

```csharp
IJointAccountsController jointAccounts = client.JointAccounts;
```

### <a name="get_joint_account"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.JointAccountsController.GetJointAccount") GetJointAccount

> Get a joint account holder's details


```csharp
Task<StarlingBankClient.Models.JointAccount> GetJointAccount()
```

#### Example Usage

```csharp

StarlingBankClient.Models.JointAccount result = await jointAccounts.GetJointAccount();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="sole_traders_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.SoleTradersController") SoleTradersController

### Get singleton instance

The singleton instance of the ``` SoleTradersController ``` class can be accessed from the API Client.

```csharp
ISoleTradersController soleTraders = client.SoleTraders;
```

### <a name="get_sole_trader"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SoleTradersController.GetSoleTrader") GetSoleTrader

> Get sole trader business details


```csharp
Task<StarlingBankClient.Models.SoleTrader> GetSoleTrader()
```

#### Example Usage

```csharp

StarlingBankClient.Models.SoleTrader result = await soleTraders.GetSoleTrader();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="spending_insights_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.SpendingInsightsController") SpendingInsightsController

### Get singleton instance

The singleton instance of the ``` SpendingInsightsController ``` class can be accessed from the API Client.

```csharp
ISpendingInsightsController spendingInsights = client.SpendingInsights;
```

### <a name="get_query_spending_insights_by_counterparty"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SpendingInsightsController.GetQuerySpendingInsightsByCounterparty") GetQuerySpendingInsightsByCounterparty

> Get the spending insights grouped by counter party


```csharp
Task<StarlingBankClient.Models.SpendingCounterPartySummary> GetQuerySpendingInsightsByCounterparty(Guid accountUid, string year, StarlingBankClient.Models.MonthEnum month)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| year |  ``` Required ```  | Year |
| month |  ``` Required ```  | Month |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
string year = "year";
var month = StarlingBankClient.Models.MonthEnumHelper.ParseString("JANUARY");

StarlingBankClient.Models.SpendingCounterPartySummary result = await spendingInsights.GetQuerySpendingInsightsByCounterparty(accountUid, year, month);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_query_spending_insights_by_spending_category"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SpendingInsightsController.GetQuerySpendingInsightsBySpendingCategory") GetQuerySpendingInsightsBySpendingCategory

> Get the spending insights grouped by spending category


```csharp
Task<StarlingBankClient.Models.SpendingCategorySummary> GetQuerySpendingInsightsBySpendingCategory(Guid accountUid, string year, StarlingBankClient.Models.MonthEnum month)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| year |  ``` Required ```  | Year |
| month |  ``` Required ```  | Month |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
string year = "year";
var month = StarlingBankClient.Models.MonthEnumHelper.ParseString("JANUARY");

StarlingBankClient.Models.SpendingCategorySummary result = await spendingInsights.GetQuerySpendingInsightsBySpendingCategory(accountUid, year, month);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_query_spending_insights_by_country"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SpendingInsightsController.GetQuerySpendingInsightsByCountry") GetQuerySpendingInsightsByCountry

> Get the spending insights grouped by country


```csharp
Task<StarlingBankClient.Models.SpendingCountrySummary> GetQuerySpendingInsightsByCountry(Guid accountUid, string year, StarlingBankClient.Models.MonthEnum month)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| year |  ``` Required ```  | Year |
| month |  ``` Required ```  | Month |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
string year = "year";
var month = StarlingBankClient.Models.MonthEnumHelper.ParseString("JANUARY");

StarlingBankClient.Models.SpendingCountrySummary result = await spendingInsights.GetQuerySpendingInsightsByCountry(accountUid, year, month);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="account_holders_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.AccountHoldersController") AccountHoldersController

### Get singleton instance

The singleton instance of the ``` AccountHoldersController ``` class can be accessed from the API Client.

```csharp
IAccountHoldersController accountHolders = client.AccountHolders;
```

### <a name="get_account_holder"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountHoldersController.GetAccountHolder") GetAccountHolder

> Get basic information about the account holder


```csharp
Task<StarlingBankClient.Models.AccountHolder> GetAccountHolder()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AccountHolder result = await accountHolders.GetAccountHolder();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_account_holder_name"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AccountHoldersController.GetAccountHolderName") GetAccountHolderName

> Get the name of the account holder


```csharp
Task<StarlingBankClient.Models.AccountHolderName> GetAccountHolderName()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AccountHolderName result = await accountHolders.GetAccountHolderName();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="profile_images_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.ProfileImagesController") ProfileImagesController

### Get singleton instance

The singleton instance of the ``` ProfileImagesController ``` class can be accessed from the API Client.

```csharp
IProfileImagesController profileImages = client.ProfileImages;
```

### <a name="get_download_profile_image"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.ProfileImagesController.GetDownloadProfileImage") GetDownloadProfileImage

> Get a profile image if one exists


```csharp
Task<dynamic> GetDownloadProfileImage(Guid accountHolderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountHolderUid |  ``` Required ```  | Unique identifier of an account holder |


#### Example Usage

```csharp
Guid accountHolderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

dynamic result = await profileImages.GetDownloadProfileImage(accountHolderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_profile_image"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.ProfileImagesController.UpdateProfileImage") UpdateProfileImage

> Update a profile image if one already exists


```csharp
Task UpdateProfileImage(Guid accountHolderUid, string contentType, object body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountHolderUid |  ``` Required ```  | Unique identifier of an account holder |
| contentType |  ``` Required ```  | TODO: Add a parameter description |
| body |  ``` Required ```  | Attachment input stream |


#### Example Usage

```csharp
Guid accountHolderUid = Guid.NewGuid();
string contentType = "Content-Type";
object body = new object();

await profileImages.UpdateProfileImage(accountHolderUid, contentType, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_profile_image"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.ProfileImagesController.DeleteProfileImage") DeleteProfileImage

> Delete a profile image if one exists


```csharp
Task DeleteProfileImage(Guid accountHolderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountHolderUid |  ``` Required ```  | Unique identifier of an account holder |


#### Example Usage

```csharp
Guid accountHolderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await profileImages.DeleteProfileImage(accountHolderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="addresses_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.AddressesController") AddressesController

### Get singleton instance

The singleton instance of the ``` AddressesController ``` class can be accessed from the API Client.

```csharp
IAddressesController addresses = client.Addresses;
```

### <a name="get_addresses"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AddressesController.GetAddresses") GetAddresses

> Get the account holder's addresses


```csharp
Task<StarlingBankClient.Models.AddressesV2> GetAddresses()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AddressesV2 result = await addresses.GetAddresses();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_current_address"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.AddressesController.UpdateCurrentAddress") UpdateCurrentAddress

> Update the account holder's current address


```csharp
Task UpdateCurrentAddress(StarlingBankClient.Models.AddressUpdateRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Update account holder's current address |


#### Example Usage

```csharp
var body = new StarlingBankClient.Models.AddressUpdateRequest();

await addresses.UpdateCurrentAddress(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="cards_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.CardsController") CardsController

### Get singleton instance

The singleton instance of the ``` CardsController ``` class can be accessed from the API Client.

```csharp
ICardsController cards = client.Cards;
```

### <a name="update_enable_gambling_payments"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableGamblingPayments") UpdateEnableGamblingPayments

> Update gambling payments control


```csharp
Task UpdateEnableGamblingPayments(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether gambling payments should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableGamblingPayments(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_pos"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnablePos") UpdateEnablePos

> Update card present payments (contactless and chip and pin) control


```csharp
Task UpdateEnablePos(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether card present payments (contactless and chip and pin) should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnablePos(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_mag_stripe_payment"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableMagStripePayment") UpdateEnableMagStripePayment

> Update magstripe payments control


```csharp
Task UpdateEnableMagStripePayment(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether magstripe payments should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableMagStripePayment(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_currency_switch"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableCurrencySwitch") UpdateEnableCurrencySwitch

> Update currency switch payments control


```csharp
Task UpdateEnableCurrencySwitch(Guid cardUid, StarlingBankClient.Models.CurrencyFlag body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether currency switch payments should be allowed for a given currency. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.CurrencyFlag();

await cards.UpdateEnableCurrencySwitch(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_card"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableCard") UpdateEnableCard

> Update card lock


```csharp
Task UpdateEnableCard(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether the card should be locked. Set to false to lock, true to unlock. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableCard(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_atm"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableAtm") UpdateEnableAtm

> Update ATM withdrawal control


```csharp
Task UpdateEnableAtm(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether ATM withdrawals should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableAtm(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_online_payments"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableOnlinePayments") UpdateEnableOnlinePayments

> Update online payments control


```csharp
Task UpdateEnableOnlinePayments(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether online payments should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableOnlinePayments(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_enable_mobile_wallet"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.UpdateEnableMobileWallet") UpdateEnableMobileWallet

> Update mobile wallet payments control


```csharp
Task UpdateEnableMobileWallet(Guid cardUid, StarlingBankClient.Models.Enabling body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| cardUid |  ``` Required ```  | Card uid of the targeted card |
| body |  ``` Required ```  | Whether mobile wallet payments should be allowed. Set to false to block, true to allow. |


#### Example Usage

```csharp
Guid cardUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Enabling();

await cards.UpdateEnableMobileWallet(cardUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_cards"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.CardsController.ListCards") ListCards

> Get all the cards for an account holder


```csharp
Task<StarlingBankClient.Models.Cards> ListCards()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Cards result = await cards.ListCards();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="recurring_card_payments_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.RecurringCardPaymentsController") RecurringCardPaymentsController

### Get singleton instance

The singleton instance of the ``` RecurringCardPaymentsController ``` class can be accessed from the API Client.

```csharp
IRecurringCardPaymentsController recurringCardPayments = client.RecurringCardPayments;
```

### <a name="list_recurring_payments"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.RecurringCardPaymentsController.ListRecurringPayments") ListRecurringPayments

> Fetch recurring card payments for an account holder


```csharp
Task<StarlingBankClient.Models.RecurringCardPayment> ListRecurringPayments(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.RecurringCardPayment result = await recurringCardPayments.ListRecurringPayments(accountUid);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="direct_debit_mandates_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.DirectDebitMandatesController") DirectDebitMandatesController

### Get singleton instance

The singleton instance of the ``` DirectDebitMandatesController ``` class can be accessed from the API Client.

```csharp
IDirectDebitMandatesController directDebitMandates = client.DirectDebitMandates;
```

### <a name="get_mandate"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.DirectDebitMandatesController.GetMandate") GetMandate

> Get the direct debit mandate with the specified identifier


```csharp
Task<StarlingBankClient.Models.DirectDebitMandateV2> GetMandate(Guid mandateUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateUid |  ``` Required ```  | Unique identifier of the mandate. |


#### Example Usage

```csharp
Guid mandateUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.DirectDebitMandateV2 result = await directDebitMandates.GetMandate(mandateUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_cancel_mandate"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.DirectDebitMandatesController.DeleteCancelMandate") DeleteCancelMandate

> Cancel the direct debit mandate with the specified identifier


```csharp
Task DeleteCancelMandate(Guid mandateUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateUid |  ``` Required ```  | Unique identifier of the mandate. |


#### Example Usage

```csharp
Guid mandateUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await directDebitMandates.DeleteCancelMandate(mandateUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_payments_for_mandate"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.DirectDebitMandatesController.ListPaymentsForMandate") ListPaymentsForMandate

> Get a transaction history for a direct debit


```csharp
Task<StarlingBankClient.Models.DirectDebitPaymentsResponse> ListPaymentsForMandate(Guid mandateUid, DateTime since)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| mandateUid |  ``` Required ```  | Unique identifier of the mandate. |
| since |  ``` Required ```  | Start date for a transaction history |


#### Example Usage

```csharp
Guid mandateUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
DateTime since = 2020-08-17;

StarlingBankClient.Models.DirectDebitPaymentsResponse result = await directDebitMandates.ListPaymentsForMandate(mandateUid, since);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_mandates"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.DirectDebitMandatesController.ListMandates") ListMandates

> Get a list of direct debit mandates


```csharp
Task<StarlingBankClient.Models.DirectDebitMandatesV2> ListMandates()
```

#### Example Usage

```csharp

StarlingBankClient.Models.DirectDebitMandatesV2 result = await directDebitMandates.ListMandates();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="transaction_feed_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.TransactionFeedController") TransactionFeedController

### Get singleton instance

The singleton instance of the ``` TransactionFeedController ``` class can be accessed from the API Client.

```csharp
ITransactionFeedController transactionFeed = client.TransactionFeed;
```

### <a name="update_user_note"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.UpdateUserNote") UpdateUserNote

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task UpdateUserNote(
        Guid accountUid,
        Guid categoryUid,
        Guid feedItemUid,
        StarlingBankClient.Models.UserNoteWrapper body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |
| body |  ``` Required ```  | User Note |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
Guid feedItemUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.UserNoteWrapper();

await transactionFeed.UpdateUserNote(accountUid, categoryUid, feedItemUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_download_feed_item_attachment"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetDownloadFeedItemAttachment") GetDownloadFeedItemAttachment

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<Stream> GetDownloadFeedItemAttachment(
        Guid accountUid,
        Guid categoryUid,
        Guid feedItemUid,
        Guid feedItemAttachmentUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |
| feedItemAttachmentUid |  ``` Required ```  | Feed item attachment uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemAttachmentUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

Stream result = await transactionFeed.GetDownloadFeedItemAttachment(accountUid, categoryUid, feedItemUid, feedItemAttachmentUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_receipt"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetReceipt") GetReceipt

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.Receipt> GetReceipt(Guid accountUid, Guid categoryUid, Guid feedItemUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.Receipt result = await transactionFeed.GetReceipt(accountUid, categoryUid, feedItemUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_or_update_receipt"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.CreateOrUpdateReceipt") CreateOrUpdateReceipt

> Submit a receipt for a feed item


```csharp
Task<StarlingBankClient.Models.ReceiptCreationResponse> CreateOrUpdateReceipt(
        Guid accountUid,
        Guid categoryUid,
        Guid feedItemUid,
        StarlingBankClient.Models.Receipt body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |
| body |  ``` Required ```  | Receipt |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
Guid feedItemUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.Receipt();

StarlingBankClient.Models.ReceiptCreationResponse result = await transactionFeed.CreateOrUpdateReceipt(accountUid, categoryUid, feedItemUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="change_transaction_category"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.ChangeTransactionCategory") ChangeTransactionCategory

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task ChangeTransactionCategory(
        Guid accountUid,
        Guid categoryUid,
        Guid feedItemUid,
        StarlingBankClient.Models.UpdateSpendingCategory body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |
| body |  ``` Required ```  | Spending category |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
Guid feedItemUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.UpdateSpendingCategory();

await transactionFeed.ChangeTransactionCategory(accountUid, categoryUid, feedItemUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_feed_item"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetFeedItem") GetFeedItem

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.FeedItem> GetFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.FeedItem result = await transactionFeed.GetFeedItem(accountUid, categoryUid, feedItemUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_query_feed_items"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetQueryFeedItems") GetQueryFeedItems

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.FeedItems> GetQueryFeedItems(Guid accountUid, Guid categoryUid, DateTime changesSince)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| changesSince |  ``` Required ```  | Items which have changed since |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
DateTime changesSince = 2020-01-01T12:34:56.000Z;

StarlingBankClient.Models.FeedItems result = await transactionFeed.GetQueryFeedItems(accountUid, categoryUid, changesSince);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_query_feed_items_with_transaction_times_between"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetQueryFeedItemsWithTransactionTimesBetween") GetQueryFeedItemsWithTransactionTimesBetween

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.FeedItems> GetQueryFeedItemsWithTransactionTimesBetween(
        Guid accountUid,
        Guid categoryUid,
        DateTime minTransactionTimestamp,
        DateTime maxTransactionTimestamp)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| minTransactionTimestamp |  ``` Required ```  | Minimum transaction timestamp |
| maxTransactionTimestamp |  ``` Required ```  | Maximum transaction timestamp |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
DateTime minTransactionTimestamp = 2020-06-01T12:34:56.000Z;
DateTime maxTransactionTimestamp = 2020-07-01T12:34:56.000Z;

StarlingBankClient.Models.FeedItems result = await transactionFeed.GetQueryFeedItemsWithTransactionTimesBetween(accountUid, categoryUid, minTransactionTimestamp, maxTransactionTimestamp);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_feed_item_attachments"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetFeedItemAttachments") GetFeedItemAttachments

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.FeedItemAttachments> GetFeedItemAttachments(Guid accountUid, Guid categoryUid, Guid feedItemUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.FeedItemAttachments result = await transactionFeed.GetFeedItemAttachments(accountUid, categoryUid, feedItemUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_mastercard_feed_item"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.TransactionFeedController.GetMastercardFeedItem") GetMastercardFeedItem

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.MastercardFeedItem> GetMastercardFeedItem(Guid accountUid, Guid categoryUid, Guid feedItemUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| feedItemUid |  ``` Required ```  | Feed item uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid feedItemUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.MastercardFeedItem result = await transactionFeed.GetMastercardFeedItem(accountUid, categoryUid, feedItemUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="feed_round_up_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.FeedRoundUpController") FeedRoundUpController

### Get singleton instance

The singleton instance of the ``` FeedRoundUpController ``` class can be accessed from the API Client.

```csharp
IFeedRoundUpController feedRoundUp = client.FeedRoundUp;
```

### <a name="fetch_round_up_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.FeedRoundUpController.FetchRoundUpGoal") FetchRoundUpGoal

> Returns the the round-up goal associated with an account if one has been created


```csharp
Task<StarlingBankClient.Models.RoundUpGoalResponse> FetchRoundUpGoal(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.RoundUpGoalResponse result = await feedRoundUp.FetchRoundUpGoal(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_activate_round_up_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.FeedRoundUpController.UpdateActivateRoundUpGoal") UpdateActivateRoundUpGoal

> Activates transaction round-up and adds remainder to savings goal


```csharp
Task UpdateActivateRoundUpGoal(Guid accountUid, StarlingBankClient.Models.RoundUpGoalPayload body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| body |  ``` Required ```  | Round-up goal |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.RoundUpGoalPayload();

await feedRoundUp.UpdateActivateRoundUpGoal(accountUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_stop_round_up_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.FeedRoundUpController.DeleteStopRoundUpGoal") DeleteStopRoundUpGoal

> Deletes the round-up goal associated with an account if one exists


```csharp
Task DeleteStopRoundUpGoal(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await feedRoundUp.DeleteStopRoundUpGoal(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="api_user_identities_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.APIUserIdentitiesController") APIUserIdentitiesController

### Get singleton instance

The singleton instance of the ``` APIUserIdentitiesController ``` class can be accessed from the API Client.

```csharp
IAPIUserIdentitiesController aPIUserIdentities = client.APIUserIdentities;
```

### <a name="get_token_identity"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.APIUserIdentitiesController.GetTokenIdentity") GetTokenIdentity

> This endpoint returns the permissions you have access to, the time until the token expires and the account holder's unique identifier.


```csharp
Task<StarlingBankClient.Models.IdentityV2> GetTokenIdentity()
```

#### Example Usage

```csharp

StarlingBankClient.Models.IdentityV2 result = await aPIUserIdentities.GetTokenIdentity();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_authorising_individual"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.APIUserIdentitiesController.GetAuthorisingIndividual") GetAuthorisingIndividual

> The individual who authorised the application


```csharp
Task<StarlingBankClient.Models.Individual> GetAuthorisingIndividual()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Individual result = await aPIUserIdentities.GetAuthorisingIndividual();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_logout_individual"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.APIUserIdentitiesController.UpdateLogoutIndividual") UpdateLogoutIndividual

> This endpoint logs an individual out by disabling all of their active access tokens.


```csharp
Task UpdateLogoutIndividual()
```

#### Example Usage

```csharp

await aPIUserIdentities.UpdateLogoutIndividual();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="kyc_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.KYCController") KYCController

### Get singleton instance

The singleton instance of the ``` KYCController ``` class can be accessed from the API Client.

```csharp
IKYCController kYC = client.KYC;
```

### <a name="get_kyc_result"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.KYCController.GetKycResult") GetKycResult

> Get KYC result for an account holder


```csharp
Task<StarlingBankClient.Models.KycResult> GetKycResult()
```

#### Example Usage

```csharp

StarlingBankClient.Models.KycResult result = await kYC.GetKycResult();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="payments_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.PaymentsController") PaymentsController

### Get singleton instance

The singleton instance of the ``` PaymentsController ``` class can be accessed from the API Client.

```csharp
IPaymentsController payments = client.Payments;
```

### <a name="get_payment_order"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.GetPaymentOrder") GetPaymentOrder

> Get a payment order


```csharp
Task<StarlingBankClient.Models.PaymentOrderV2> GetPaymentOrder(Guid paymentOrderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| paymentOrderUid |  ``` Required ```  | Payment order uid |


#### Example Usage

```csharp
Guid paymentOrderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.PaymentOrderV2 result = await payments.GetPaymentOrder(paymentOrderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_make_local_payment"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.UpdateMakeLocalPayment") UpdateMakeLocalPayment

> Creates and sends an immediate payment within the UK under the Faster Payments Scheme or via SEPA for payments between Euro accounts. The recipient of the payment must be a payee of the account holder (new payees can be created using the 'Payees' endpoint) OR be defined in the `paymentRecipient` member of the request.
> 
> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.InstructLocalPaymentResponse> UpdateMakeLocalPayment(Guid accountUid, Guid categoryUid, StarlingBankClient.Models.InstructLocalPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| body |  ``` Required ```  | Payment instruction object. |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.InstructLocalPaymentRequest();

StarlingBankClient.Models.InstructLocalPaymentResponse result = await payments.UpdateMakeLocalPayment(accountUid, categoryUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_standing_orders"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.ListStandingOrders") ListStandingOrders

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.StandingOrdersResponse> ListStandingOrders(Guid accountUid, Guid categoryUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.StandingOrdersResponse result = await payments.ListStandingOrders(accountUid, categoryUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_standing_order"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.CreateStandingOrder") CreateStandingOrder

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.CreateStandingOrderResponse> CreateStandingOrder(Guid accountUid, Guid categoryUid, StarlingBankClient.Models.CreateStandingOrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| body |  ``` Required ```  | Standing order creation object. |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.CreateStandingOrderRequest();

StarlingBankClient.Models.CreateStandingOrderResponse result = await payments.CreateStandingOrder(accountUid, categoryUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_standing_order"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.GetStandingOrder") GetStandingOrder

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.StandingOrder> GetStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| paymentOrderUid |  ``` Required ```  | Payment Order uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid paymentOrderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.StandingOrder result = await payments.GetStandingOrder(accountUid, categoryUid, paymentOrderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_standing_order"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.UpdateStandingOrder") UpdateStandingOrder

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.UpdateStandingOrderResponse> UpdateStandingOrder(
        Guid accountUid,
        Guid categoryUid,
        Guid paymentOrderUid,
        StarlingBankClient.Models.UpdateStandingOrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| paymentOrderUid |  ``` Required ```  | Payment order uid |
| body |  ``` Required ```  | Standing order update request. |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid categoryUid = Guid.NewGuid();
Guid paymentOrderUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.UpdateStandingOrderRequest();

StarlingBankClient.Models.UpdateStandingOrderResponse result = await payments.UpdateStandingOrder(accountUid, categoryUid, paymentOrderUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_cancel_standing_order"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.DeleteCancelStandingOrder") DeleteCancelStandingOrder

> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task DeleteCancelStandingOrder(Guid accountUid, Guid categoryUid, Guid paymentOrderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| paymentOrderUid |  ``` Required ```  | Payment order uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid paymentOrderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await payments.DeleteCancelStandingOrder(accountUid, categoryUid, paymentOrderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_next_payment_dates"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.ListNextPaymentDates") ListNextPaymentDates

> N.B. if you're looking for only the next payment date, this is also returned when getting a standing order in the `StandingOrder` response from the field `nextDate`.
> 
> Categories are subdivisions within an account.
> The `defaultCategory` from [`/api/v2/accounts`](#operations-tag-Accounts) is where the main balance and transactions are held.
> Other categories are used for Savings Goals.


```csharp
Task<StarlingBankClient.Models.NextPaymentDatesResponse> ListNextPaymentDates(
        Guid accountUid,
        Guid categoryUid,
        Guid paymentOrderUid,
        int? count = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| categoryUid |  ``` Required ```  | Category uid |
| paymentOrderUid |  ``` Required ```  | Payment Order uid |
| count |  ``` Optional ```  | Number of next payment dates to retrieve, between 1 and 100. If count is greater than the number of future payments all future payments will be returned. Defaults to 10. |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid categoryUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid paymentOrderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
int? count = 28;

StarlingBankClient.Models.NextPaymentDatesResponse result = await payments.ListNextPaymentDates(accountUid, categoryUid, paymentOrderUid, count);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_payment_order_payments"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PaymentsController.GetPaymentOrderPayments") GetPaymentOrderPayments

> Get the payments associated with a payment order


```csharp
Task<StarlingBankClient.Models.PaymentOrderPaymentsResponse> GetPaymentOrderPayments(Guid paymentOrderUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| paymentOrderUid |  ``` Required ```  | Payment order uid |


#### Example Usage

```csharp
Guid paymentOrderUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.PaymentOrderPaymentsResponse result = await payments.GetPaymentOrderPayments(paymentOrderUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="onboarding_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.OnboardingController") OnboardingController

### Get singleton instance

The singleton instance of the ``` OnboardingController ``` class can be accessed from the API Client.

```csharp
IOnboardingController onboarding = client.Onboarding;
```

### <a name="get_onboarding_status"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.OnboardingController.GetOnboardingStatus") GetOnboardingStatus

> Get the onboarding status of the account


```csharp
Task<StarlingBankClient.Models.OnboardingStatus> GetOnboardingStatus()
```

#### Example Usage

```csharp

StarlingBankClient.Models.OnboardingStatus result = await onboarding.GetOnboardingStatus();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_onboard"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.OnboardingController.UpdateOnboard") UpdateOnboard

> Onboard an account


```csharp
Task<StarlingBankClient.Models.OnboardingResponse> UpdateOnboard(StarlingBankClient.Models.OnboardingRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Account onboarding request |


#### Example Usage

```csharp
var body = new StarlingBankClient.Models.OnboardingRequest();

StarlingBankClient.Models.OnboardingResponse result = await onboarding.UpdateOnboard(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="payees_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.PayeesController") PayeesController

### Get singleton instance

The singleton instance of the ``` PayeesController ``` class can be accessed from the API Client.

```csharp
IPayeesController payees = client.Payees;
```

### <a name="get_payees"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.GetPayees") GetPayees

> Get an account holder's payees


```csharp
Task<StarlingBankClient.Models.Payees> GetPayees()
```

#### Example Usage

```csharp

StarlingBankClient.Models.Payees result = await payees.GetPayees();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_payee"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.CreatePayee") CreatePayee

> Create a payee


```csharp
Task<StarlingBankClient.Models.PayeeCreationResponse> CreatePayee(StarlingBankClient.Models.PayeeCreationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Payee creation object |


#### Example Usage

```csharp
var body = new StarlingBankClient.Models.PayeeCreationRequest();

StarlingBankClient.Models.PayeeCreationResponse result = await payees.CreatePayee(body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_payee_account"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.CreatePayeeAccount") CreatePayeeAccount

> Create a payee account


```csharp
Task<StarlingBankClient.Models.PayeeAccountCreationResponse> CreatePayeeAccount(Guid payeeUid, StarlingBankClient.Models.PayeeAccountCreationRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |
| body |  ``` Required ```  | Payee account creation object |


#### Example Usage

```csharp
Guid payeeUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.PayeeAccountCreationRequest();

StarlingBankClient.Models.PayeeAccountCreationResponse result = await payees.CreatePayeeAccount(payeeUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_payment_orders_for_account"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.ListPaymentOrdersForAccount") ListPaymentOrdersForAccount

> Get scheduled payments


```csharp
Task<StarlingBankClient.Models.ScheduledPayments> ListPaymentOrdersForAccount(Guid payeeUid, Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |
| accountUid |  ``` Required ```  | Unique identifier of the payee account |


#### Example Usage

```csharp
Guid payeeUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.ScheduledPayments result = await payees.ListPaymentOrdersForAccount(payeeUid, accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_payee"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.DeletePayee") DeletePayee

> Deletes a payee


```csharp
Task DeletePayee(Guid payeeUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |


#### Example Usage

```csharp
Guid payeeUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await payees.DeletePayee(payeeUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_payee_account"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.DeletePayeeAccount") DeletePayeeAccount

> Delete a payee account


```csharp
Task DeletePayeeAccount(Guid payeeUid, Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |
| accountUid |  ``` Required ```  | Unique identifier of the payee account |


#### Example Usage

```csharp
Guid payeeUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await payees.DeletePayeeAccount(payeeUid, accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="list_payments_for_payee_account"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.ListPaymentsForPayeeAccount") ListPaymentsForPayeeAccount

> View a history of payments to your payee


```csharp
Task<StarlingBankClient.Models.Payments> ListPaymentsForPayeeAccount(Guid payeeUid, Guid accountUid, DateTime since)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |
| accountUid |  ``` Required ```  | Unique identifier of the payee account |
| since |  ``` Required ```  | Start date for a transaction history |


#### Example Usage

```csharp
Guid payeeUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
DateTime since = 2020-08-17;

StarlingBankClient.Models.Payments result = await payees.ListPaymentsForPayeeAccount(payeeUid, accountUid, since);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_serve_payee_image_file"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.PayeesController.GetServePayeeImageFile") GetServePayeeImageFile

> Serves the image for the payee


```csharp
Task<dynamic> GetServePayeeImageFile(Guid payeeUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| payeeUid |  ``` Required ```  | Unique identifier of the payee |


#### Example Usage

```csharp
Guid payeeUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

dynamic result = await payees.GetServePayeeImageFile(payeeUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="savings_goals_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController") SavingsGoalsController

### Get singleton instance

The singleton instance of the ``` SavingsGoalsController ``` class can be accessed from the API Client.

```csharp
ISavingsGoalsController savingsGoals = client.SavingsGoals;
```

### <a name="get_savings_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.GetSavingsGoal") GetSavingsGoal

> Get a savings goal


```csharp
Task<StarlingBankClient.Models.SavingsGoalV2> GetSavingsGoal(Guid accountUid, Guid savingsGoalUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid savingsGoalUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.SavingsGoalV2 result = await savingsGoals.GetSavingsGoal(accountUid, savingsGoalUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_savings_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.UpdateSavingsGoal") UpdateSavingsGoal

> Update an existing goal


```csharp
Task<StarlingBankClient.Models.CreateOrUpdateSavingsGoalResponseV2> UpdateSavingsGoal(Guid accountUid, Guid savingsGoalUid, StarlingBankClient.Models.SavingsGoalRequestV2 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |
| body |  ``` Required ```  | Savings goal request |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid savingsGoalUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.SavingsGoalRequestV2();

StarlingBankClient.Models.CreateOrUpdateSavingsGoalResponseV2 result = await savingsGoals.UpdateSavingsGoal(accountUid, savingsGoalUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_savings_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.DeleteSavingsGoal") DeleteSavingsGoal

> Delete a savings goal


```csharp
Task DeleteSavingsGoal(Guid accountUid, Guid savingsGoalUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid savingsGoalUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await savingsGoals.DeleteSavingsGoal(accountUid, savingsGoalUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_savings_goals"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.GetSavingsGoals") GetSavingsGoals

> Get all savings goals


```csharp
Task<StarlingBankClient.Models.SavingsGoalsV2> GetSavingsGoals(Guid accountUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.SavingsGoalsV2 result = await savingsGoals.GetSavingsGoals(accountUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_savings_goal"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.CreateSavingsGoal") CreateSavingsGoal

> Create a savings goal


```csharp
Task<StarlingBankClient.Models.CreateOrUpdateSavingsGoalResponseV2> CreateSavingsGoal(Guid accountUid, StarlingBankClient.Models.SavingsGoalRequestV2 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| body |  ``` Required ```  | Savings goal request |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.SavingsGoalRequestV2();

StarlingBankClient.Models.CreateOrUpdateSavingsGoalResponseV2 result = await savingsGoals.CreateSavingsGoal(accountUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_savings_goal_photo"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.GetSavingsGoalPhoto") GetSavingsGoalPhoto

> Get the photo associated with a savings goal


```csharp
Task<StarlingBankClient.Models.SavingsGoalPhotoV2> GetSavingsGoalPhoto(Guid accountUid, Guid savingsGoalUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid savingsGoalUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.SavingsGoalPhotoV2 result = await savingsGoals.GetSavingsGoalPhoto(accountUid, savingsGoalUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="add_money"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.AddMoney") AddMoney

> Add money into a savings goal


```csharp
Task<StarlingBankClient.Models.SavingsGoalTransferResponseV2> AddMoney(
        Guid accountUid,
        Guid savingsGoalUid,
        Guid transferUid,
        StarlingBankClient.Models.TopUpRequestV2 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |
| transferUid |  ``` Required ```  | Transfer uid, generated by the caller |
| body |  ``` Required ```  | Top up request |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid savingsGoalUid = Guid.NewGuid();
Guid transferUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.TopUpRequestV2();

StarlingBankClient.Models.SavingsGoalTransferResponseV2 result = await savingsGoals.AddMoney(accountUid, savingsGoalUid, transferUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="update_withdraw_money"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.UpdateWithdrawMoney") UpdateWithdrawMoney

> Withdraw money from a savings goal


```csharp
Task<StarlingBankClient.Models.SavingsGoalTransferResponseV2> UpdateWithdrawMoney(
        Guid accountUid,
        Guid savingsGoalUid,
        Guid transferUid,
        StarlingBankClient.Models.WithdrawalRequestV2 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |
| transferUid |  ``` Required ```  | Transfer uid, generated by the caller |
| body |  ``` Required ```  | Withdrawal request |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid savingsGoalUid = Guid.NewGuid();
Guid transferUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.WithdrawalRequestV2();

StarlingBankClient.Models.SavingsGoalTransferResponseV2 result = await savingsGoals.UpdateWithdrawMoney(accountUid, savingsGoalUid, transferUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="get_recurring_transfer"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.GetRecurringTransfer") GetRecurringTransfer

> Get the recurring transfer of a savings goal


```csharp
Task<StarlingBankClient.Models.ScheduledSavingsPaymentV2> GetRecurringTransfer(Guid accountUid, Guid savingsGoalUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid savingsGoalUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

StarlingBankClient.Models.ScheduledSavingsPaymentV2 result = await savingsGoals.GetRecurringTransfer(accountUid, savingsGoalUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="create_or_update_recurring_transfer"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.CreateOrUpdateRecurringTransfer") CreateOrUpdateRecurringTransfer

> Create a recurring transfer into a savings goal


```csharp
Task<StarlingBankClient.Models.SavingsGoalTransferResponseV2> CreateOrUpdateRecurringTransfer(Guid accountUid, Guid savingsGoalUid, StarlingBankClient.Models.ScheduledSavingsPaymentRequestV2 body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |
| body |  ``` Required ```  | Recurring transfer request |


#### Example Usage

```csharp
Guid accountUid = Guid.NewGuid();
Guid savingsGoalUid = Guid.NewGuid();
var body = new StarlingBankClient.Models.ScheduledSavingsPaymentRequestV2();

StarlingBankClient.Models.SavingsGoalTransferResponseV2 result = await savingsGoals.CreateOrUpdateRecurringTransfer(accountUid, savingsGoalUid, body);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


### <a name="delete_recurring_transfer"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SavingsGoalsController.DeleteRecurringTransfer") DeleteRecurringTransfer

> Delete the recurring transfer of a savings goal


```csharp
Task DeleteRecurringTransfer(Guid accountUid, Guid savingsGoalUid)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountUid |  ``` Required ```  | Account uid |
| savingsGoalUid |  ``` Required ```  | Savings goal uid |


#### Example Usage

```csharp
Guid accountUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;
Guid savingsGoalUid = aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa;

await savingsGoals.DeleteRecurringTransfer(accountUid, savingsGoalUid);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Client error |
| 500 | Server error |


[Back to List of Controllers](#list_of_controllers)

## <a name="settle_up_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.SettleUpController") SettleUpController

### Get singleton instance

The singleton instance of the ``` SettleUpController ``` class can be accessed from the API Client.

```csharp
ISettleUpController settleUp = client.SettleUp;
```

### <a name="get_settle_up_profile"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SettleUpController.GetSettleUpProfile") GetSettleUpProfile

> Fetch Settle Up profile for an account holder


```csharp
Task<StarlingBankClient.Models.SettleUpProfile> GetSettleUpProfile()
```

#### Example Usage

```csharp

StarlingBankClient.Models.SettleUpProfile result = await settleUp.GetSettleUpProfile();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="subscriptions_controller"></a>![Class: ](https://www.collaborotech.com/img/class.png "StarlingBankClient.Tests.Controllers.SubscriptionsController") SubscriptionsController

### Get singleton instance

The singleton instance of the ``` SubscriptionsController ``` class can be accessed from the API Client.

```csharp
ISubscriptionsController subscriptions = client.Subscriptions;
```

### <a name="get_account_holder_subscription"></a>![Method: ](https://www.collaborotech.com/img/method.png "StarlingBankClient.Tests.Controllers.SubscriptionsController.GetAccountHolderSubscription") GetAccountHolderSubscription

> Fetch product subscription details for an account holder


```csharp
Task<StarlingBankClient.Models.AccountHolderSubscription> GetAccountHolderSubscription()
```

#### Example Usage

```csharp

StarlingBankClient.Models.AccountHolderSubscription result = await subscriptions.GetAccountHolderSubscription();

```


[Back to List of Controllers](#list_of_controllers)



