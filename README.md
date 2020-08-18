# Getting started

The Starling API enables seamless integration of Starling account and transactional data into your application.
You can, subject to permission, use it to view account holder data and to automate actions on their accounts.

Our API is RESTful, using predictable and resource-orientated URLs with standard HTTP methods and status codes.
All responses (expected and errors) are in JSON format.
We also offer webhooks so our API can notify you of events.

All API requests are authorised using [OAuth2](http://oauth.net/2/) with different permission scopes required depending on the services you wish to use.
This allows our account holders to see exactly what data your application can access and allows us to ensure only trusted partners can carry out significant actions, such as transferring money on our account holder's behalf.

We want to make integrating with Starling as easy as possible.
If you have feedback on our APIs or documentation or there is something you wish to see covered, please get in touch by through the [Starling Developer Slack](https://developer.starlingbank.com/community) or by [email](mailto:developer@starlingbank.com).

### Availability

Our APIs are open to everyone to develop and test applications.

First, you need to [Sign up](https://developer.starlingbank.com/signup) for a developer account in our Developer portal.
Then, you can create a personal access token to access your own Starling Bank account if you have one, although you won't be able to make payments from your account using a personal access token.
To access other Starling bank accounts, you need to register your application.
Once you have registered your application, you can test it in our sandbox environment against dummy data.

If you want to access data from live Starling Bank accounts, or make payments from your own account, you need to apply to upgrade your registered application.
We will then review your request, and get back to you.

The base URLs for the APIs are:
- Sandbox: `https://api-sandbox.starlingbank.com`
- Production: `https://api.starlingbank.com`

#### Personal access tokens

As both a developer and Starling account holder, you can issue personal access tokens to yourself at any time without going through the OAuth authorisation process.
They do not expire so you don't need to worry about refreshing them.

To create a personal access token:
- [Login](https://developer.starlingbank.com/login) to the Developer Portal
- Go to the [personal access tokens](https://developer.starlingbank.com/personal) page
- Link your Starling Bank account to your Starling Developer account
- Create a token, selecting the scopes you require (note that the `pay-local:create` scope is not available for personal access tokens)
- Use the token to make API requests against your own Starling bank account

#### Registering an application

To use our APIs to access Starling Bank accounts other than your own, you must [register an application](https://developer.starlingbank.com/application) in our developer portal.
This gives you a unique `client_id` and `client_secret` (which, as the name suggests, should be kept secret).
You can use these to get an access token which allows you to access other Starling Bank accounts (see **OAuth flow** below).

Registering your application gives you access to our [sandbox environment](https://developer.starlingbank.com/sandbox).
Here, you can create dummy customers, accounts and transactions, and test your application against these.

#### Accessing live Starling bank accounts

If you want to access live Starling Bank accounts, other than your own, you must apply to [upgrade your application](https://developer.starlingbank.com/partner) and provide the additional information we require.

#### Live accounts and eIDAS certificates

To access live Starling Bank accounts other than your own, your application also needs a valid eIDAS certificate.
The eIDAS certificate must be qualified (either QWAC or QSeal), and must be unique for each application.
The eIDAS certificate should have roles that cover the [permissions](https://developer.starlingbank.com/permissions) required by your application, so we can automatically grant you the associated scopes.
You can upload your eIDAS certificate in the **Application** page in our Developer Portal.

We require eIDAS certificates for all new applications.
If your application is already registered with us, please upload a suitable eIDAS certificate as soon as possible.
We will be requiring valid eIDAS certificates for all applications in the future. Your current authentication process will not change.

#### Sandbox Environment

Our sandbox environment gives you the chance to thoroughly test your application against our API.
Within the [sandbox interface](https://developer.starlingbank.com/sandbox) you can:
- create account holders of different types for your application
- simulate card, FPS and BACS transactions
- get access tokens for sandbox customers

#### Permissions

Different API endpoints require different permissions to access data. Permissions correspond to OAuth scopes.
These permissions are grouped into the following categories:

| Permission category | Description |
| --- | :---|
| `Read Personal` | Read personal information |
| `Edit Personal` | Edit personal information |
| `Read Financial` | Read financial information and transactions |
| `Edit Financial` | Edit financial information and transactions |
| `Transact Financial` | Create financial transactions on account holder's behalf |
| `Customer Onboarding` | Onboard account holders onto the platform |

A full breakdown of access scopes and their assigned permissions is available on the [permissions information](https://developer.starlingbank.com/permissions) page.

Access is given to an application - not to a developer account. This means each application you register has its own permissions.

### OAuth flow

Starling uses [OAuth2](http://oauth.net/2/) to authenticate and authorise requests to our API.
This allows Starling Bank account holders to authorise your application to access their data, without handing over their Starling credentials.

For those who are unfamiliar with OAuth2, the process is:
1. You direct the user to Starling (usually via a button in your application)
2. We authenticate the user then they authorise your application to access their data
3. Starling redirects the user back to your application and gives you an authorisation code
4. You exchange the authorisation code for an access token and a refresh token
5. You use the Starling API, providing the access token on every request
6. (later) Before the refresh token expires, you use the refresh token to obtain a new access token and refresh token.

If you have a Starling Bank account and want to play around against your own data, you can create a [personal access token](https://developer.starlingbank.com/personal) to skip straight to step 5 for yourself.

#### 1. Redirect to Starling

Starling authentication can be used in two ways:
- Connect your Starling account: The account holder may already have an account with your application and wishes to connect this to their Starling account so they can interact with their account via your application.
- Login with Starling: The account holder may be new to your application and wishes to log in with their Starling credentials, granting access to their Starling data in the process, rather than signing up for another account.

In both cases, the user starts in your application.
This may be a web page or native application, either on their phone with the Starling app or a separate device.

The user will click a button to connect or login with Starling.
We provide standard assets and resources for this [on Google Drive](https://drive.google.com/drive/folders/1PSSUsCriJx5_pxTilxYfaWpS1eH_Iv6i).

Your application redirects the user to the Starling OAuth site so we can verify their identity and confirm they wish to share their data with your application before issuing access tokens.

Redirect the account holder to:
- Sandbox: `https://oauth-sandbox.starlingbank.com`
- Production: `https://oauth.starlingbank.com`

With the query parameters:

| Parameter | Value |
| ----- | ----- |
| `client_id` | Your unique client id for the [registered application](https://developer.starlingbank.com/application) |
| `response_type` | Type of response you are expecting - this must be `code` |
| `state` | An unpredictable randomised string used to protect against cross-site request forgery ([more details](https://auth0.com/docs/protocols/oauth2/oauth-state))
| `redirect_uri` | (Optional) A URI which to redirect the user back to after authorising your application. If provided, this must be equal to or a sub-resource of the redirect URI provided when registering your [application](https://developer.starlingbank.com/application) for security reasons. |

An example valid URI:

```
https://oauth.starlingbank.com/?client_id=aT6TPtsTJvhB1wzGbrRp&response_type=code&state=249a34c4-4588-449a-9ad9-f192581e52fd
```

#### 2. Account holder authenticates themselves and authorises your application

We identify and verify the account holder (authentication).

On a phone with the Starling app installed, the user will be redirected (by the OS) to review the access request in-app.
On other devices, users will be required to approve the request in-app, either by scanning a QR code or via a push notification.
We will explain the relevant process to the account holder.

We ask for permission to share their data with your application (authorisation).

We will tell the user what data will be shared and give the user the option to deny or approve this.
If the user denies access, they user will be redirected to your `redirect_uri` with an `error` of `access_denied`.

#### 3. Get the authorisation code

Once we've verified the user's identity and the user has authorised your application, we will redirect them to the `redirect_uri` with two parameters:

| Parameter | Value |
| ----- | ----- |
| `code` | A temporary authorisation code you can use to obtain an access token for the account holder's data. The code will expire after a few minutes.
| `state` | The `state` you sent us in step 1. You **must** verify the state matches exactly and abort the process if it does not. |

For example, if the `redirect_uri` was `https://your.application.url/redirect/path` the user might be redirected to:

```
https://your.application.url/redirect/path?code=edv79CsZn80frhfxgF4o58aXAc7enpgB1wyv&state=249a34c4-4588-449a-9ad9-f192581e52fd
```

##### Redirects to native mobile applications

If you are developing a native mobile application, you will need to register your application with the OS before sending the user to Starling.
This will allow the OS to seamlessly return the user into the correct screen of your application when we redirect the user back.

iOS [Universal links](https://developer.apple.com/ios/universal-links/) allow your application to use the same URIs as your web site.
This is the recommended approach (especially if you have a website and mobile app).
Alternatively you can use [custom URL schemes](https://developer.apple.com/documentation/uikit/inter-process_communication/allowing_apps_and_websites_to_link_to_your_content/defining_a_custom_url_scheme_for_your_app), which can be quicker to get going with.

Android [App links](https://developer.android.com/training/app-links/index.html) offer the same functionality on Android, allowing a common URI for your web page and deep links into your native application.

#### 4. Exchange for an access token

This authorisation code can now be exchanged for an access token, which you can think of as an encoded user name and password specific to your application and the account holder.
Treat it as such, and keep it secure.

Each access token is valid for a single registered application for a single account holder.

To exchange the authorisation code, `POST` the following parameters as `application/x-www-form-urlencoded` to one of:
- Sandbox: `https://api-sandbox.starlingbank.com/oauth/access-token`
- Production: `https://api.starlingbank.com/oauth/access-token`

As you need to send the `client_secret`, which should never be shared publicly, this must be done from your server.

| Parameter | Value |
| ----- | ----- |
| `code` | The authorisation code you received as the `code` query parameter in step 3 |
| `client_id` | The unique client identifier of your [registered application](https://developer.starlingbank.com/application) |
| `client_secret` | The client secret for your [registered application](https://developer.starlingbank.com/application) (how we verify that the request is really from you) |
| `grant_type` | For an authorisation code exchange this must be `authorization_code` |
| `redirect_uri` | The redirect URI the account holder was sent to when Starling returned with the access code in step 3 (this is validated as a further security check) |

The response returns the details of the access token in `application/json` format, for example:

```json
{
    "access_token": "eyJhbGciOiJQUzI1NiIsInppcCI6IkdaSVAifQ.H4sIAAQ-_pT1TALVKOt8.uLjFJikw--DDv3Pf",
    "refresh_token": "De2yfE70KcoFkaEQvVW236s2UVaVexzKGUjHYAG2OGutlO5GLJiSN0rv2P8dean1",
    "token_type": "Bearer",
    "expires_in": 3600,
    "scope": "account:read balance:read card-control:edit card:read transaction:read"
}
```

| Property | Description |
| ----- | ----- |
| `access_token` | The secret access token to authenticate your requests to our API on behalf of the end user |
| `refresh_token` | The secret refresh token to use to obtain a new access token when the existing token is near expiry |
| `token_type` | The type of token that has been issued - this is always `Bearer` |
| `expires_in` | Number of seconds until the access token expires |
| `scope` | Extent of the authorisation granted by the account holder. The access token can only be used to call services available within the approved scope |

You should treat the access and refresh tokens as arbitrary length strings.

##### Access token scopes

Access tokens are restricted to a particular set of resources.
Each token is issued with a space-separated list of scopes it provides, and each resource method defines the scope(s) required to make the call.
Attempting to access a method beyond the scope of the access token results in a `403 Forbidden` error.

If you wish to expand the scopes you can request, please [apply for upgraded permissions](https://developer.starlingbank.com/partner).

##### eIDAS certificates

**NOTE:** *This feature will be deprecated in the future. We recommend that new applications use `client_id` and `client_secret` to obtain access tokens*.

If you have a **qualified** eIDAS certificate - one signed by a QTSP's certificate present on a Trusted List - you can use that in place of your `client_id` and `client_secret` in an access token request.
To do this, `POST` a signed `application/x-www-form-urlencoded` request to `/oauth/access-token/eidas`, omitting the `client_id` and `client_secret` parameters.

This request must be signed with the private key used to generate your eIDAS certificate (see **Message signing** below).
You must have previously uploaded the public key of this certificate through the Developer Portal.

#### 5. Use the API

That's it! You now have the access token needed to call the Starling APIs on behalf of the account holder.
When making requests, authenticate with the `Authorization` header set to `Bearer $access_token`
For example:

```
Bearer eyJhbGciOiJQUzI1NiIsInppcCI6IkdaSVAifQ.H4sIAAQ-_pT1TALVKOt8.uLjFJikw--DDv3Pf
```

When hitting the API, it'd be helpful to provide a `User-Agent` header that will allow us to identify you in case we need to get in touch.

#### 6. (later) Refresh the access token and refresh token

To minimise the period of risk if an access token is compromised, the access token expires after a predetermined period (1 hour in production, 24 hours in Sandbox).
To carry on accessing resources on the account holder's behalf, you must refresh the access token using the refresh token retrieved in step 4.
Refresh tokens are long lived (6 months) and can be used prior to, or after, the associated access token expiry.

When you refresh the your access token, you also receive a new refresh token.
You should discard your old refresh token, and use the new refresh token the next time you refresh the access token.
Your old refresh token is valid until you successfully refresh the access token using the new refresh token.
So, if you experience a network failure or similar, and do not receive the new refresh token, you can try again (repeatedly if necessary) using the old refresh token.

If the access token expires, you cannot access the account holder's resources, but, unless the refresh token has also expired, you can still refresh the access token to regain access.
If the account holder revokes the access token, or the access token is compromised, the account holder must re-authorise the application.

To refresh an access token, `POST` the following parameters as `application/x-www-form-urlencoded` to one of:
- Sandbox: `https://api-sandbox.starlingbank.com/oauth/access-token`
- Production: `https://api.starlingbank.com/oauth/access-token`

As you need to send the `client_secret`, which should never be shared publicly, this must be done from your server.

| Parameter | Value |
| ----- | ----- |
| `refresh_token` | The refresh token received with the access token |
| `client_id` | The unique client identifier of your [registered application](https://developer.starlingbank.com/application) |
| `client_secret` | The client secret for your [registered application](https://developer.starlingbank.com/application) (how we verify that the request is really from you) |
| `grant_type` | For a refresh token exchange this must be `refresh_token` |

The response is in the same format as the response to the initial token exchange.

##### eIDAS certificates

**NOTE:** *This feature will be deprecated in the future. We recommend that new applications use `client_id` and `client_secret` to obtain access tokens*.

As with the initial access token exchange, you can use your qualified eIDAS certificate in place of your `client_id` and `client_secret` in a refresh token request.
To do this, `POST` a signed `application/x-www-form-urlencoded` request to `/oauth/access-token/eidas`, omitting the `client_id` and `client_secret` parameters.

This request must be signed with the private key used to generate your eIDAS certificate (See **Message signing** below).
You must have previously uploaded the public key of this certificate through the Developer Portal.

#### Additional OAuth Error codes

As well as the standard errors defined by the [OAuth2](https://tools.ietf.org/html/rfc6749) specification, there are further client side error codes that could be received if an HTTP Status `400` is returned from the OAuth authorisation process:

|HTTP Status | Error           | Error description|
|------------|-----------------|------------------|
|`400`       |`invalid_request`|`grant_type must be provided`|
|`400`       |`invalid_request`|`grant_type must be either authorization_code or refresh_token`|
|`400`       |`invalid_request`|`Unexpected parameter: 'parameterName'`|
|`400`       |`invalid_request`|`Incorrect content type. Must be application/x-www-form-urlencoded`|

#### Show me some code!

In English, and with explanations, this sounds like quite a lot of work.
Fear not, it's quick to get going and some tools even handle it for you (Amazon Alexa Skills handle OAuth2 automatically for example).

It's probably easier to explain in code.
Our engineers love to play with new technology so, to prove the concept, we spent a few hours knocking up a sample web application, available on [GitHub](https://github.com/starlingbank/starling-api-web-starter-kit).
The client and server are both in Node.js (the server's necessary to avoid the client secret being sent to the browser).

### Security

We want our bank to be as open and accessible as possible while maintaining a secure environment for all our account holders.
This is why we need to get to know you before permitting wider access to our APIs.

To protect account holder data your application MUST:
* Not transmit the `client_secret` to the browser. This must remain confidential on the production server only
* Maintain a secure production environment with limited and monitored access
* Hold access and refresh tokens in a secure store with limited and monitored access
* Use HTTPS resources for receiving the authorisation code redirect and for displaying Starling data
* Conform with relevant national and international data and personal information protection laws

### Using the APIs

The API uses four HTTP methods:
| Method | Usage |
| ----- | ----- |
| `POST` (create) | Makes a new object, always returns the UUID for the object made |
| `GET` (read) | Returns details of the requested object |
| `PUT` (update) | Updates an existing object, usually no response content is returned |
| `DELETE` (delete) | Deletes an existing object, usually no response content is returned |

All responses, including errors, return JSON.
The `POST` and `PUT` methods require JSON for the request body.

#### Errors

We use common HTTP status codes in the response header to indicate success or failure, including, but not limited to, the following:

| HTTP Status | Meaning |
| ----- | ----- |
| `200` OK | Request succeeded and processed OK |
| `202` Accepted | Received was received OK and will process shortly. Typically you will receive a UUID in response that can be used to check progress |
| `204` No Content | The request was successfully fulfilled and there is no additional content to send in the response payload body. |
| `400` Bad Request | Something was wrong with the request. Check the request to address the error included in the response |
| `401` Unauthorized | You are not authorised to access the requested data |
| `403` Forbidden | Your authentication failed, usually because the access token has expired, or you tried to access a resource outside the scope of the token |
| `404` Not Found | The requested resource does not exist |
| `500` Server Error | Something went wrong on our side - get in touch so we can look into it! |

#### SSL Pinning

SSL Pinning is a client-side security technique to avoid man-in-the-middle attacks by manually re-validating the certificate.
We highly recommend the use of SSL pinning in production.

During the SSL handshake it verifies the certificate provided by the server is a specific, pre-agreed certificate.
This prevents data loss in the unlikely event that an attacker hijacks our API URL and uses a different valid certificate (i.e. one signed by a trusted CA) to pose as us.

You can download our X509 public certificates here:
- [Production Certificate](https://developer.starlingbank.com/starling-prod-api-certificate.crt)
- [Sandbox Certificate](https://developer.starlingbank.com/starling-sandbox-api-certificate.crt)

You will need to embed the certificate during development and associate it with our domain.
Then, during the SSL challenge with us your application should validate our identity with the certificates.
Libraries to do this are available for almost all languages and platforms, for example `TrustKit` on iOS and `okhttp` for Java.

### Webhooks

Webhooks subscriptions are available to OAuth applications for a wide range of events.
Events are loosely grouped into two categories - transactional events and account events.

These enable you to serve real-time information and notify users as events occur without having to poll our servers for changes.

#### Webhook Usage

To create a webhook for your [registered application](https://developer.starlingbank.com/application), you need to supply a `HTTPS` production payload URL and chose the events you would like to subscribe to.

You can also set up a [personal webhook](https://developer.starlingbank.com/personal/webhook), which will notify you of events that occur on your own account.

When an event occurs, our server will send a POST request with the payload as the request body to your chosen URL.

#### Webhook Security

It is important you validate webhooks have originated from Starling's servers and have not been tampered with in transit.

This can be done using a shared secret that is used to sign all hooks.
The signature is placed in the header of the request using `X-Hook-Signature`. It is the Base64 encoding of the `SHA-512` digest of the `secret + payload`.

To validate this, make sure the library you are using provides access to the raw JSON payload.
Any modification or formatting of the payload will leave you unable to validate the signature.

Never hardcode the webhook shared secret into your application - use a secrets manager, environment variable or configuration property instead.

Code samples for this are available on [GitHub](https://github.com/starlingbank/api-samples/tree/master/webhook-verification).

### Message Signing

Some API requests require stricter levels of security (e.g. for payment instruction).
We use digital signatures to validate integrity and provide non-repudiation.

The overview of the process is:
1. You generate two key pairs:
    - an API key pair to sign API requests
    - a rotation key pair to sign new key uploads
2. You upload the public key from each key pair to the Developer Portal
3. You make signed requests (using the private API key) to endpoints requiring signatures
4. (later) You rotate keys, signing the key rotation request with the private rotation key

#### 1. Generate key pairs

You'll need to generate two public/private key pairs - an API key to sign API requests, and a rotation key used just to sign new key uploads.

In the production environment, you must keep the private keys of your key pairs secure.

Key Requirements:

- Keys must be either RSA or ECDSA keys (RSA is mandatory for eIDAS certificates).
- RSA keys should have a length of either 2048 or 4096.
- ECDSA keys should have a length of 256.
- RSA keys should not be SSH keys. All valid RSA key bodies will start `MII`.

You can generate RSA key pairs satisfying these requirements using [OpenSSL](https://www.openssl.org/):

```bash
openssl genpkey -out starling-api-private.key -algorithm RSA -pkeyopt rsa_keygen_bits:4096
openssl rsa -in starling-api-private.key -pubout -out starling-api-public.key

openssl genpkey -out starling-rotation-private.key -algorithm RSA -pkeyopt rsa_keygen_bits:4096
openssl rsa -in starling-rotation-private.key -pubout -out starling-rotation-public.key
```

#### 2. Upload public keys

To upload keys, go to the 'keys' section in your [registered application](https://developer.starlingbank.com/application).

Here you can select the environment (production or sandbox) and add your public API key and public rotation key.

The key should be one of the following:
- a complete public key, across new lines, and with headers and footers such as `-----BEGIN PUBLIC KEY-----`
- the whole body of the public key in a single line (beginning `MII`) without headers and footers

Tip: to quickly copy keys to the clipboard you can use:

```bash
# Windows
cat starling-api-public.key | clip
cat starling-rotation-public.key | clip

# Mac
cat starling-api-public.key | pbcopy
cat starling-rotation-public.key | pbcopy

# Linux
cat starling-api-public.key | xclip
cat starling-rotation-public.key | xclip
```

#### 3. Make signed requests

Now you're ready to start making signed requests to the API!

All requests must be appropriately signed, and include the access token, with an `Authorization` header of the form:

```
Bearer ...;Signature keyid="...",algorithm="...",headers="...",signature="..."
```

where:
- `keyid` is the key uid of the API key used to sign the request
    - This is available from the 'keys' section of the [registered application](https://developer.starlingbank.com/application)
- `algorithm` is the name of the signing algorithm used
    - Supported algorithms are: `rsa-sha256`, `rsa-sha512`, `ecdsa-sha256`, `ecdsa-sha512`
- `headers` is a space-delimited list of the HTTP headers which have been used to create the signature. These must include:
    - `(request-target)`: Path of the requested resource (excludes host name)
    - `Date`: ISO 8601 date and time with offset when the request was made (e.g. `2020-04-01T12:34:56+01:00`)
        - Requests are only valid within 5 seconds of this time
        - NB: this is not the standard HTTP format for the Date header
    - `Digest`: The SHA-512 digest of the request payload (the raw JSON string which makes up the request body), or `X` if no message body is present
    - You may optionally sign any other headers by including them in this list of headers
- `signature` is the signature generated with the private API key
    - This is the signature generated by applying `algorithm` to the header key-value pairs specified in `headers`, encoded in Base64
    - An example string representation of the headers that would be the content to be signed would be:
      ```
      (request-target): put /api/v2/payments/local/account/90d14796-c59f-4944-9146-7fc84deb253c/category/46168325-8d23-4efe-ba48-b3a74f85f23b
      Date: 2020-04-07T18:26:30.668978+01:00
      Digest: Aw4ttuzY7Rn0ad4QFkauxuWrLbgBY3QhtYm8SCKDFY2FlmzKgsk5zwW4CJzdc/8hECqylyXaYyOZsH1/rq1qHQ==
      ```

An example of a complete `Authorization` header is:

```
Bearer eyJhbGciOiJQUzI1NiIsInppcCI6IkdaSVAifQ.H4sIAAQ-_pT1TALVKOt8.uLjFJikw--DDv3Pf;Signature keyid="aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa",algorithm="rsa-sha512",headers="(request-target) Date Digest",signature="Wdg4ZakVT1/wLU0o9XlKkxvf8MaYQWxUIxWq2Z+/1NvD6NXvqkCOFgM/7Nblh8rFKDenmf0iWtS5DSJmBh5Sjg/ZT4OV44Wm0f0zQ2BIVlENHduMj8UqWRLBgq11HWOILF1UIKBhd92iv0huQIohPskbiHkXgW2NUr6qsVUmljY4zClh0hW48WI5sRRDHO9TqTYDBec0mAOiHnSNGVKGps4KORanbCGmqwythxgxMq3es4IgkeBxe5AEtdI13HT73WqfXIi0lZkgTS5vKyW8ieitNvhBq1rCBLrnnTp3BoTPNevVCbOOjvOknWZD4It1XXHdbz0oCAUl0FVLEOfjB8oXO+ss91TuXiIgJ8zq7fvNJUEoYNYxW8NZ41+MqCizZiK3cbTWrDMMvRtB/muCm6CsUp8o8C/wKRo90+jACGn8xVw/WUx1+fWGCqmFFFhIikqFnkamDBjzc+aHseHuQ09GkrGG1SK4yM4k5ffVZFO1HnInRAS7q/n8tW7YFvFjXXX1lT2OvzAAaGGtnSluezKoHYoN1a+URO2vy0tmiFGxMMoXtdKcZX5rCljO3oTe/llYE4YOataa+zj6Y5Xd4bo04TnD+V8bXqf7VUnOUjlaTQDwIft2uQhHKCe3A/WSXoqc0BukRN46Ms+08KFCLVCYYJWYhgcipg38T5GkAg0="
```

Code samples for this are available on [GitHub](https://github.com/starlingbank/api-samples/tree/master/message-signing).

#### 4. (later) Rotate keys

There is no maximum age for keys, but we recommend rotating keys on significant staff departure, or if the private key is suspected to be compromised.

A second API key can be added by signing the new public API key with the private rotation key.
Both keys will then be in service for API calls to support seamless rotation.
Once you've migrated all your applications over, you can then expire the old API key to prevent it being used.

To do this:
- Generate a new API key pair (see step 1, 'Generate key pairs' above).
- Add the new public API key via the 'keys' section in your [registered application](https://developer.starlingbank.com/application).

The signature should be of the form:

```
Signature keyid="...",algorithm="...",headers="Date Digest",signature="..."
```

where:
- `keyid` is the key uid of the rotation key used to sign the request
    - This is available from the 'keys' section of the [registered application](https://developer.starlingbank.com/application)
- `algorithm` is the name of the signing algorithm used
    - Supported algorithms are: `rsa-sha256`, `rsa-sha512`, `ecdsa-sha256`, `ecdsa-sha512`
- `headers` is a space-delimited list of properties which have been used to create the signature. This must be exactly `Date Digest`.
    - `Date`: ISO 8601 date and time with offset when the request was made (e.g. `2020-04-01T12:34:56+01:00`)
        - Requests are only valid within 5 minutes of this time
    - `Digest`: The SHA-512 digest of the the base64 string of the public key
        - If you have a key in PKCS8 format, the base64 string is just the public key file without headers and whitespace
- `signature` is the signature generated with the private rotation key
    - This is the signature generated by applying `algorithm` to the property key-value pairs specified in `headers`, encoded in base64
    - An example string representation of the properties that would be the content to be signed would be:
      ```
      Date: 2020-04-07T19:47:56.801792+01:00
      Digest: D9fiexHEKiuqWIgg3SEl1S5Dohbg96z6L8VJiT4lHjJxoKZ3OYn023u5hUOQgXiP8mbCPwIWMYZqPBiPtPd9iQ==
      ```

An example of a complete signature is:

```
Signature keyid="aaaaaaaa-aaaa-4aaa-aaaa-aaaaaaaaaaaa",algorithm="rsa-sha512",headers="Date Digest",signature="GbJROi2cB9E0A/+WvXBEzfVGJcx7ep868n2lgnkY4GQXBF5e/6g4viilosYwfBY2JrDfhYVcFv/Pd+bBXBebxs/Z75BgvBmen8M8zeV14XbrKPXtKVuz8dnSplEcJ0z1Djucb4c2tb386hkGDeE1eZXKpLr8DEHO1kbDb6Ox65YkMXor0sY7/BrdziumjQMantd4fBwwbHHWJFcTb39c4MCCHJZwhJ8+/Ay9Q3adY3U5c4dTc8cZotKOkKrBbGltY4Cwq0arahz0kkwzERBJbqFOm7O0z638ZPKWK8y2Xgk3wLrFbtuhjf6y70elhTMN/+VtdElWWVTPLqV0r8V1du2gMa+cg4/hwVB6QyUl/QuXB5mQ/TYGzlMI/9S/qclXdnVOLmOQNYLIwah2NCEDL8fl+tWSyiM2dhxSY1/wa7iG89fp60LeOF9qfnKkF16fPgsGaWWhOlxiwQDNnWoEI7Gf4AMWf7iTtqpfx2N5vGwRJtZ7X4yJRt8P1J2sGB9Kau9+Sxq+FcRpZjemyrh0MTw0fpEMcg9zoVkDSTQk+aim4qOqn7hEPErhxAj8x241DYARU/cv4O/tBLu3Dij/FMoj2MJrecVeykqqxYcBfixiKO5O4HZFrbSc8wKAAhAOBjCMo9GG3NroghcCqvcvNeMlAEaKAU7QiUoJcp/yVh8="
```

The signature timestamp is the value of `date` used to generate the signature.

Code samples for this are available on [GitHub](https://github.com/starlingbank/api-samples/tree/master/key-rotation).

### Help & Support

Join in and get help from the [Starling Developer Slack](https://developer.starlingbank.com/community) or contact us by [email](mailto:developer@starlingbank.com).

If you have any non-technical questions concerning Starling Bank, see the help section of your app or our [help centre](https://help.starlingbank.com/).


## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
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



