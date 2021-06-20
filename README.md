**Kestrel Hosted Blazor WASM + Microsoft Identity / JWT Template with Roles & Policies.**

![Blazor WASM Identity Template Screenshot](Screenshot.jpg)

Code copied from [Chris Sainty's blog](https://chrissainty.com/securing-your-blazor-apps-authentication-with-clientside-blazor-using-webapi-aspnet-core-identity/): "**Securing Your Blazor Apps (Part 2/3/4)**"

**Changes (Jun 17, 2021):**
 * Updated to use .NET 6 Preview 4
 * Furthermore this template uses a SQLite Database (_which is included in the repo_) instead of SQLServer

**Change log:**
 * Jun 18, 2021 - Updated to .NET 6 preview 5
   * except for `Microsoft.AspNetCore.Authentication.JwtBearer`, it has [a bug](https://github.com/dotnet/aspnetcore/issues/33634)
 * Jun 19, 2021 - Added a couple of additional IdentityUser Fields 
   * /Server/Models/[ApplicationUser.cs](https://github.com/JeepNL/Hosted_Blazor_WASM_Identity/blob/master/Hosted_Blazor_WASM_Identity/Server/Models/ApplicationUser.cs) & DB Migration
 * Jun 20, 2021 - Code Cleanup 

Be sure to check out Chris Sainty's book "**Blazor in Action**". This book is an example-driven guide to building client-side web apps using C# and .NET - and now [available to buy](https://www.manning.com/books/blazor-in-action?utm_source=sainty&utm_medium=affiliate&utm_campaign=book_sainty_blazor_10_7_20&a_aid=sainty&a_bid=a0dc2c45) via the Manning Early Access Program (_MEAP_).

This template uses Microsoft Identity (_which is not IdentityServer_) so you'll get all of the Microsoft Identity Database Tables with normalized fields, security stamps & password hashing etc. etc.

With this you don't need IdentityServer4/5.. for Hosted Blazor WASM anymore, plus authorization & authentication is done in the Blazor Client App itself (_with a REST API/JSON to the server_)), it doesn't redirect you to the IdentityServer (_Areas/Identity_) Register/Login Razor Pages on the server.

**User/Login Information:**

Counter Menu (User Policy)
 * user name: user@example.com
 * password: Qwerty1234#

Fetch Data Menu (Admin Policy)
 * user name: admin@example.com 
 * password: Qwerty1234#
  
**NOTE:** Although it runs out of the box, I've done this upgrade in a day and it's possible I've made some errors. This is just a template to get you started, don't use it in production (_see for example: [Server/Controllers/AccountsController.cs](https://github.com/JeepNL/Hosted_Blazor_WASM_Identity/blob/master/Hosted_Blazor_WASM_Identity/Server/Controllers/AccountsController.cs)_)

Also this sample template needs to be updated so it automatically refreshes its JWT tokens (_Now it uses tokens valid for a day when you login_).
