- [Chapter 1 - Introducing Web Development with Controllers](#chapter-1---introducing-web-development-with-controllers)
  - [Set up your development environment](#set-up-your-development-environment)
  - [Additional Packt books](#additional-packt-books)
  - [Visual Studio](#visual-studio)
  - [VS Code](#vs-code)
  - [Other C# code editors and platforms](#other-c-code-editors-and-platforms)
  - [.NET](#net)
  - [ASP.NET versions and features](#aspnet-versions-and-features)
  - [Help and learning](#help-and-learning)
- [Chapter 2 - Building Websites Using ASP.NET Core MVC](#chapter-2---building-websites-using-aspnet-core-mvc)
  - [General web development](#general-web-development)
  - [ASP.NET Core](#aspnet-core)
- [Chapter 3 - Model Binding, Validation, and Data Using EF Core](#chapter-3---model-binding-validation-and-data-using-ef-core)
  - [MVC Models](#mvc-models)
  - [EF Core and ASP.NET Core](#ef-core-and-aspnet-core)
- [Chapter 4 - Building and Localizing Web User Interfaces](#chapter-4---building-and-localizing-web-user-interfaces)
  - [ASP.NET Core MVC views](#aspnet-core-mvc-views)
  - [Razor syntax and layouts](#razor-syntax-and-layouts)
- [Chapter 5 - Authentication and Authorization](#chapter-5---authentication-and-authorization)
- [Chapter 6 - Performance Optimization Using Caching](#chapter-6---performance-optimization-using-caching)
- [Chapter 7 - Web User Interface Testing Using Playwright](#chapter-7---web-user-interface-testing-using-playwright)
- [Chapter 8 - Configuring and Containerizing ASP.NET Core Projects](#chapter-8---configuring-and-containerizing-aspnet-core-projects)
  - [Endpoint routing](#endpoint-routing)
  - [Setting up and configuring MVC](#setting-up-and-configuring-mvc)
- [Chapter 9 - Building Web Services Using ASP.NET Core Web API](#chapter-9---building-web-services-using-aspnet-core-web-api)
  - [Web service technologies](#web-service-technologies)
  - [Web service routing](#web-service-routing)
  - [Web service clients](#web-service-clients)
  - [Documenting web services](#documenting-web-services)
  - [Securing web services](#securing-web-services)
  - [Health checks and reliable web services](#health-checks-and-reliable-web-services)
- [Chapter 10 - Building Web Services Using ASP.NET Core OData](#chapter-10---building-web-services-using-aspnet-core-odata)
- [Chapter 11 - Building Web Services Using FastEndpoints](#chapter-11---building-web-services-using-fastendpoints)
- [Chapter 12 - Web Service Integration Testing](#chapter-12---web-service-integration-testing)
  - [Unit Testing and Mocking](#unit-testing-and-mocking)
  - [Integration Testing](#integration-testing)
- [Chapter 13 - Web Content Management Using Umbraco](#chapter-13---web-content-management-using-umbraco)
  - [Umbraco CMS](#umbraco-cms)
  - [Other .NET Content Management Systems](#other-net-content-management-systems)
- [Chapter 14 - Customizing and Extending Umbraco](#chapter-14---customizing-and-extending-umbraco)

# Chapter 1 - Introducing Web Development with Controllers

## Set up your development environment
- [Set up your development environment](https://github.com/markjprice/web-dev-net9/blob/main/docs/ch01-setupdev-env.md)
- [Kestrel server](https://github.com/dotnet/aspnetcore/tree/main/src/Servers/Kestrel)
- [Dan Roth quote](https://github.com/dotnet/aspnetcore/issues/51834#issuecomment-1913282747)
- [Dan Roth profile](https://devblogs.microsoft.com/dotnet/author/danroth27/)
- [JetBrains report, The State of Developer Ecosystem 2023, ASP.NET Core question](https://www.jetbrains.com/lp/devecosystem-2023/csharp/#csharp_asp_core)
- [Almost 100,000 websites built using Umbraco](https://trends.builtwith.com/websitelist/Umbraco/Historical)
- [Umbraco is open source and hosted on GitHub](https://github.com/umbraco/Umbraco-CMS)
- [Central Package Management](https://learn.microsoft.com/en-us/nuget/consume-packages/central-package-management)
- [Northwind database SQL scripts](https://github.com/markjprice/web-dev-net9/tree/main/scripts/sql-scripts)

## Additional Packt books
- [ASP.NET Core 8 and Angular - Sixth Edition](https://www.amazon.com/ASP-NET-Core-Angular-Full-stack-development/dp/1805129937/)
- [ASP.NET Core 5 and React](https://www.amazon.com/ASP-NET-Core-React-Full-stack-developmentebook/dp/B08KYKNGCC/)
- [ASP.NET Core and Vue.js](https://www.amazon.com/ASP-NET-Core-Vue-js-real-worldapplications-ebook/dp/B08QTVV8RK/)

## Visual Studio
- [Code Editors](https://github.com/markjprice/web-dev-net9/tree/main/docs/code-editors/)
- [Download Visual Studio for Windows](https://visualstudio.microsoft.com/downloads/)
- [Sign up for a Microsoft account](https://signup.live.com/)
- [Visual Studio for Windows documentation](https://learn.microsoft.com/en-us/visualstudio/windows/)
- [MSBuild and 64-bit Visual Studio 2022](https://devblogs.microsoft.com/dotnet/msbuild-and-64-bit-visual-studio-2022/)

## VS Code
- [Download VS Code](https://code.visualstudio.com/)
- [VS Code documentation](https://code.visualstudio.com/docs)
- [Set up VS Code](https://code.visualstudio.com/docs/setup/setup-overview)
- [VS Code key bindings and shortcuts](https://code.visualstudio.com/docs/getstarted/keybindings)
  - [Windows shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf)
  - [macOS shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf)
  - [Linux shortcuts PDF](https://code.visualstudio.com/shortcuts/keyboard-shortcuts-linux.pdf)

## Other C# code editors and platforms
- [GitHub Codespaces](https://docs.github.com/en/codespaces/overview)
- [JetBrains Rider](https://www.jetbrains.com/rider/)
- [Rider documentation](https://www.jetbrains.com/help/rider/Introduction.html)
- [WebStorm and Rider Are Now Free for Non-Commercial Use](https://blog.jetbrains.com/blog/2024/10/24/webstorm-and-rider-are-now-free-for-non-commercial-use/)

## .NET
- [Download .NET SDK](https://dotnet.microsoft.com/en-us/download)
- [The convenience of .NET](https://devblogs.microsoft.com/dotnet/the-convenience-of-dotnet/)
- [What's new in .NET 9](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-9/overview)
- [What's new in .NET 8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
- [.NET Support Policy](https://dotnet.microsoft.com/platform/support/policy/dotnet-core)
- [.NET versions](https://learn.microsoft.com/en-us/dotnet/core/versions/)
- [.NET Runtime](https://github.com/dotnet/runtime/blob/main/README.md)
- [.NET Release Schedule](https://github.com/dotnet/core/blob/main/roadmap.md)

## ASP.NET versions and features
The official announcement links are useful because they describe the most important new features in each release.
- [State of ASP.NET Core | .NET Conf 2022](https://www.youtube.com/watch?v=gNyEpkJMmcM)
- [Announcing ASP.NET Core in .NET 9](https://github.com/dotnet/aspnetcore/discussions/58908)
- [Announcing ASP.NET Core in .NET 8](https://devblogs.microsoft.com/dotnet/announcing-asp-net-core-in-dotnet-8/)
- [Announcing ASP.NET Core in .NET 7](https://devblogs.microsoft.com/dotnet/announcing-asp-net-core-in-dotnet-7/)
- [ASP.NET Core 6.0 announcement](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-in-net-6/)
- [ASP.NET Core 5.0 announcement](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-in-net-5/)
- [Blazor WebAssembly announcement](https://devblogs.microsoft.com/aspnet/blazor-webassembly-3-2-0-now-available/)
- [ASP.NET Core 3.1 announcement](https://devblogs.microsoft.com/aspnet/asp-net-core-updates-in-net-core-3-1/)
- [ASP.NET Core 3.0 announcement](https://devblogs.microsoft.com/aspnet/a-first-look-at-changes-coming-in-asp-net-core-3-0/)
- [ASP.NET Core 2.2 announcement](https://devblogs.microsoft.com/aspnet/asp-net-core-2-2-available-today/)
- [ASP.NET Core 2.1 announcement](https://devblogs.microsoft.com/aspnet/asp-net-core-2-1-0-now-available/)
- [ASP.NET Core 2.0 announcement](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-2-0/)
- [ASP.NET Core 1.1 announcement](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-1-1/)
- [ASP.NET Core 1.0 announcement](https://devblogs.microsoft.com/aspnet/announcing-asp-net-core-1-0/)

## Help and learning
- [Microsoft Learn - Technical Documentation](https://learn.microsoft.com/en-us/docs/)
- [Official .NET Blog written by the .NET engineering teams](https://devblogs.microsoft.com/dotnet/)
- [Stack Overflow](https://stackoverflow.com/)
- [Google Advanced Search](https://www.google.com/advanced_search)
- [.NET Videos](https://dotnet.microsoft.com/en-us/learn/videos)
- [Microsoft Learn Shows – .NET Videos](https://learn.microsoft.com/en-us/search/?terms=.net&category=Show)

# Chapter 2 - Building Websites Using ASP.NET Core MVC

## General web development
- [Bootstrap](https://getbootstrap.com/)
- [Free TLS/SSL certificates](https://letsencrypt.org)

## ASP.NET Core
- [ASP.NET Core fundamentals](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/)
- [Static files in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/static-files)
- [HttpContext class](https://learn.microsoft.com/en-us/dotnet/api/system.web.httpcontext)
- [Kestrel web server](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/servers/kestrel)
- [ASP.NET Core hosting environments](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments)
- [Performance Improvements in ASP.NET Core 8](https://devblogs.microsoft.com/dotnet/performance-improvements-in-aspnet-core-8/)
- [Handle requests with controllers in ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/actions)

# Chapter 3 - Model Binding, Validation, and Data Using EF Core

## MVC Models
- [Model Binding in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding)
- [Create your own model binders by implementing the IModelBinder interface](https://learn.microsoft.com/en-us/aspnet/core/mvc/advanced/custom-model-binding)
- [Model validation](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation)

## EF Core and ASP.NET Core
- [Tutorial: Get started with EF Core in an ASP.NET MVC web app](https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro)
- [DbContext Lifetime, Configuration, and Initialization](https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/#dbcontext-in-dependency-injection-for-aspnet-core)

# Chapter 4 - Building and Localizing Web User Interfaces

## ASP.NET Core MVC views
- [Views in ASP.NET Core MVC](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/overview)
- [Why it is good to put <script> elements at the bottom of the <body>](https://stackoverflow.com/questions/436411/where-should-i-put-script-tags-in-html-markup)
- [HtmlHelper class](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.viewfeatures.htmlhelper)

## Razor syntax and layouts
- [Razor syntax reference for ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor)
- [Layout in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/layout)
- [Tag Helpers in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/intro)
- [The `<partial>` tag helper](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/partial-tag-helper)
- [VS Code Compact Folders feature](https://github.com/microsoft/vscode-docs/blob/vnext/release-notes/v1_41.md#compact-folders-in-explorer)

# Chapter 5 - Authentication and Authorization

- [What’s new with identity in .NET 8](https://devblogs.microsoft.com/dotnet/whats-new-with-identity-in-dotnet-8/)
- [Built-in features for compliance with modern privacy requirements like GDPR](https://learn.microsoft.com/en-us/aspnet/core/security/gdpr)
- [Enable QR code generation for TOTP authenticator apps in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity-enable-qrcodes)
- [Scaffold Identity in ASP.NET Core projects](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?tabs=netcore-cli)
- [Introduction to authorization in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/authorization/introduction)
- [Prevent Cross-Site Request Forgery (XSRF/CSRF) attacks in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/security/anti-request-forgery)

# Chapter 6 - Performance Optimization Using Caching

- [Hello HybridCache! Streamlining Cache Management for ASP.NET Core Applications](https://devblogs.microsoft.com/dotnet/hybrid-cache-is-now-ga/)
- [Content Delivery Network (CDN)](https://en.wikipedia.org/wiki/Content_delivery_network)
- [Response caching](https://learn.microsoft.com/en-us/aspnet/core/performance/caching/response)
- [Microsoft.AspNetCore.OutputCaching Namespace](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.outputcaching)
- [How cache busting using query strings works](https://stackoverflow.com/questions/9692665/cache-busting-via-params)

# Chapter 7 - Web User Interface Testing Using Playwright

- [Playwright on GitHub](https://github.com/microsoft/playwright)
- [Playwright website and documentation](https://playwright.dev/dotnet/)
- [Selenium developer website](https://www.selenium.dev/)
- [Puppeteer developer website](https://pptr.dev/)
- [Playwright locators](https://playwright.dev/dotnet/docs/locators)
- [Playwright browsers](https://playwright.dev/dotnet/docs/browsers)
- [Valid time zones for Chromium](https://source.chromium.org/chromium/chromium/deps/icu.git/+/faee8bc70570192d82d2978a71e2a615788597d1:source/data/misc/metaZones.txt)
- [Playwright emulation](https://playwright.dev/dotnet/docs/emulation)
- [Unit test controller logic in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/testing)
- [Filters for cross-concern functionality](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters)
- [Free stock photos for commercial use with no attribution](https://www.pexels.com/)

# Chapter 8 - Configuring and Containerizing ASP.NET Core Projects

## Endpoint routing
- [Simple examples of Run, Map, and Use](https://www.vaughanreid.com/2020/05/using-in-line-middleware-in-asp-net-core/)
- [Automatically visualize your endpoints](https://andrewlock.net/visualizing-asp-net-core-endpoints-using-graphvizonline-and-the-dot-language/)
- [Configuring the HTTP pipeline with middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware)
- [DEEP DIVE: HOW IS THE ASP.NET CORE MIDDLEWARE PIPELINE BUILT?](https://www.stevejgordon.co.uk/how-is-the-asp-net-core-middleware-pipeline-built)

## Setting up and configuring MVC
- [Default configuration of web hosts](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/host/web-host)
- [Dependency injection for ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- [Configuring middleware](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/)
- [Announcing YARP 1.0 Release](https://devblogs.microsoft.com/dotnet/announcing-yarp-1-0-release/)

# Chapter 9 - Building Web Services Using ASP.NET Core Web API

## Web service technologies
- [Media types](http://en.wikipedia.org/wiki/Media_type)
- [WS-* standards](https://en.wikipedia.org/wiki/List_of_web_service_specifications)
- [HTTP OPTIONS method and other HTTP methods](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/OPTIONS)
- [HTTP POST requests](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/POST)
- [Create web APIs with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/web-api/)

## Web service routing
- [Design decisions around endpoint routing](https://devblogs.microsoft.com/aspnet/asp-net-core-2-2-0-preview1-endpoint-routing/)
- [Endpoint routing](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing)
- [Previous routing system](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing)
- [Route constraints](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing#route-constraints)
- [Proposed standard for Problem Details for HTTP APIs](https://www.rfc-editor.org/rfc/rfc7807)
- [Implementing problem details](https://learn.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.problemdetails)

## Web service clients
- [REST Client](https://github.com/Huachao/vscode-restclient/blob/master/README.md)
- [It is the BaseAddress and DefaultRequestHeaders properties that you should treat with caution with multiple threads](https://medium.com/@nuno.caneco/c-httpclient-should-not-be-disposed-or-should-it-45d2a8f568bc)
- [You're using HttpClient wrong and it is destabilizing your software](https://aspnetmonsters.com/2016/08/2016-08-27-httpclientwrong/)
- [How to initiate HTTP requests](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/http-requests)
- [Issues with the original HttpClient class available in .NET](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net)
- [HttpClient extension methods for easily working with JSON](https://github.com/dotnet/designs/blob/main/accepted/2020/json-http-extensions/json-http-extensions.md)

## Documenting web services
- [Swagger](https://swagger.io/)
- [Swagger Tools](https://swagger.io/tools/)
- [Swashbuckle for ASP.NET Core](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
- [How Swagger can support multiple versions of an API](https://stackoverflow.com/questions/30789045/leverage-multipleapiversions-in-swagger-with-attribute-versioning/30789944)
- [Importance of documenting services](https://idratherbewriting.com/learnapidoc/)
- [Benefits of setting version compatibility](https://learn.microsoft.com/en-us/aspnet/core/mvc/compatibility-version)
- [Check latest version of analyzers package](http://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Api.Analyzers/)

## Securing web services
- [Verifying that the tokens used to call your web APIs are requested with the expected claims](https://learn.microsoft.com/en-us/azure/active-directory/develop/scenario-protected-web-api-verification-scope-app-roles)
- [CORS can be enabled to allow different origin requests](https://learn.microsoft.com/en-us/aspnet/core/security/cors)
- [Common HTTP security headers that you might want to add](https://www.meziantou.net/security-headers-in-asp-net-core.htm)

## Health checks and reliable web services
- [Health checks in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks)
- [How to extend the health check response](https://devblogs.microsoft.com/dotnet/asp-net-core-2-2-0-preview1-healthcheck/)
- [How Polly can make your web services more reliable](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/implement-http-call-retries-exponential-backoff-polly)
- [Use HttpClientFactory to implement resilient HTTP requests](https://learn.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests)
- [Redis](https://redis.io)
- [Resilience and chaos engineering](https://devblogs.microsoft.com/dotnet/resilience-and-chaos-engineering/)
- [Dev Tunnels: A Game Changer for Mobile Developers](https://devblogs.microsoft.com/dotnet/dev-tunnels-a-game-changer-for-mobile-developers/)

# Chapter 10 - Building Web Services Using ASP.NET Core OData

- [OData - the best way to REST](https://www.odata.org/)
- [Welcome to OData](https://learn.microsoft.com/en-us/odata/overview)
- [OData reference](https://learn.microsoft.com/en-us/dotnet/api/overview/odata-dotnet/)
- [OData DevBlog](https://devblogs.microsoft.com/odata/)
- [$compute and $search in ASP.NET Core OData 8](https://devblogs.microsoft.com/odata/compute-and-search-in-asp-net-core-odata-8/)
- [The Future of OData NxT (Neo)](https://devblogs.microsoft.com/odata/the-future-of-odata-odata-nxt/)
- [API versioning extension with ASP.NET Core OData 8](https://devblogs.microsoft.com/odata/api-versioning-extension-with-asp-net-core-odata-8/)

# Chapter 11 - Building Web Services Using FastEndpoints

- [TechEmpower benchmarks](https://fast-endpoints.com/benchmarks)
- [Official documentation for FastEndpoints](https://fast-endpoints.com/)
- [OpenAPI support for FastEndpoints](https://fast-endpoints.com/docs/swagger-support)
- [FastEndpoints recommends xUnit, WebApplicationFactory, and FluentAssertions for unit and integration testing](https://fast-endpoints.com/docs/integration-unit-testing)
- [FastEndpoints tutorial](https://dev.to/djnitehawk/building-rest-apis-in-net-6-the-easy-way-3h0d)

# Chapter 12 - Web Service Integration Testing

## Unit Testing and Mocking

- [ASP.NET Core team uses xUnit](https://github.com/dotnet/aspnetcore/tree/main/src/Testing/src/xunit)
- [Unit testing framework comparisons](https://xunit.net/docs/comparisons)
- [Moq controversy 1](https://github.com/devlooped/moq/blob/main/CHANGELOG.md#4200-2023-08-07)
- [Moq controversy 2](https://www.reddit.com/r/programming/comments/15m2q0o/moq_a_net_mocking_library_now_ships_with_a/)
- [Moq controversy 3](https://www.reddit.com/r/dotnet/comments/173ddyk/now_that_the_controversy_from_moqs_dependencies/)
- [NSubstitue](https://github.com/nsubstitute/NSubstitute)
- [FakeItEasy](https://fakeiteasy.github.io/)
- [NSubstitute NuGet package](https://www.nuget.org/packages/NSubstitute)
- [FluentAssertions NuGet package](https://www.nuget.org/packages/FluentAssertions/)
- [FluentAssertions](https://fluentassertions.com/)
- [Bogus NuGet package](https://www.nuget.org/packages/Bogus/)
- [xUnit](https://xunit.net/)
- [xUnit packages](https://xunit.net/docs/nuget-packages)
- [nunit](https://nunit.org/)
- [MS Test](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-mstest-intro)
- [Introducing MSTest SDK – Improved Configuration & Flexibility](https://devblogs.microsoft.com/dotnet/introducing-mstest-sdk/)

## Integration Testing

- [Real-world regression example](https://github.com/markjprice/cs11dotnet7/blob/main/docs/errata/errata.md#page-178---reviewing-project-packages)
- [Dev tunnels with ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/test/dev-tunnels)
- [Integration tests in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/test/integration-tests)

# Chapter 13 - Web Content Management Using Umbraco

## Umbraco CMS
- [Umbraco CMS documentation](https://docs.umbraco.com/umbraco-cms)
- [Umbraco CMS Editor’s Manual](https://docs.umbraco.com/umbraco-cms/tutorials/editors-manual)
- [Umbraco versions and support](https://umbraco.com/products/knowledge-center/long-term-support-and-end-of-life/)
- [Umbraco requirements](https://docs.umbraco.com/umbraco-cms/fundamentals/setup/requirements)
- [Umbraco CMS NuGet package](https://www.nuget.org/packages/Umbraco.Cms/#versions-body-tab)
- [Umbraco default data types](https://docs.umbraco.com/umbraco-cms/fundamentals/data/data-types/default-data-types)
- [Umbraco Rich Text Editor](https://docs.umbraco.com/umbraco-cms/tutorials/editors-manual/working-with-content)
- [TinyPNG](https://tinypng.com/)
- [ImageOptim](https://imageoptim.com/)
- [Scheduled publishing](https://docs.umbraco.com/umbraco-cms/fundamentals/data/scheduled-publishing)
- [Dictionary items for translating text into different languages](https://docs.umbraco.com/umbraco-cms/fundamentals/data/dictionary-items)
- [Relations for structuring the content tree](https://docs.umbraco.com/umbraco-cms/fundamentals/data/relations)

## Other .NET Content Management Systems
- [Piranha CMS](https://piranhacms.org/)
- [ABP Framework](https://abp.io/)
- [nopCommerce](https://www.nopcommerce.com/)
- [Umbraco CMS](https://umbraco.com/products/umbraco-cms/umbraco-13/)
- [Optimizely Comtent Cloud (CMS 12)](https://docs.developers.optimizely.com/content-cloud)
- [Orchard Core](http://orchardcore.net/)
- [OSS Spotlight - Build websites with a modern ASP.NET Core CMS – Orchard Core](https://www.youtube.com/watch?v=cKhAVWm845o)

# Chapter 14 - Customizing and Extending Umbraco

- [Umbraco CMS scheduled jobs](https://docs.umbraco.com/umbraco-cms/reference/scheduling)
- [UmbracoContext helper](https://docs.umbraco.com/umbraco-cms/reference/querying/umbraco-context)
- [IPublishedContent interface](https://docs.umbraco.com/umbraco-cms/reference/querying/ipublishedcontent)
- [IMemberManager interface](https://docs.umbraco.com/umbraco-cms/reference/querying/imembermanager)
- [Models Builder](https://docs.umbraco.com/umbraco-cms/reference/templating/modelsbuilder)
- [UmbracoHelper class](https://docs.umbraco.com/umbraco-cms/reference/querying/umbracohelper)
- [Tutorials for Umbraco](https://docs.umbraco.com/umbraco-cms/tutorials/overview)
- [The Starter Kit](https://docs.umbraco.com/umbraco-cms/tutorials/starter-kit)
- [TypeScript documentation](https://www.typescriptlang.org/docs/)
- [Lit documentation](https://lit.dev/docs/)
- [Tutorials about customizing the Umbraco editing experience](https://docs.umbraco.com/umbraco-cms/tutorials/overview#customize-the-editingexperience)
- 
