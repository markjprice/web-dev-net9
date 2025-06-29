**Improvements** (23 items)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 2 - Introducing Web Development Using Controllers](#page-2---introducing-web-development-using-controllers)
- [Page 3 - History of ASP.NET Core](#page-3---history-of-aspnet-core)
- [Page 24 - Running the Azure SQL Edge container image](#page-24---running-the-azure-sql-edge-container-image)
- [Page 27 - Connecting to Azure SQL Edge in a Docker container](#page-27---connecting-to-azure-sql-edge-in-a-docker-container)
- [Page 30 - Creating the Northwind database using a SQL script](#page-30---creating-the-northwind-database-using-a-sql-script)
- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page 34 - Creating a class library for entity models](#page-34---creating-a-class-library-for-entity-models)
- [Page 36 - Creating a class library for a database context](#page-36---creating-a-class-library-for-a-database-context)
- [Page 44 - Testing the class libraries using xUnit](#page-44---testing-the-class-libraries-using-xunit)
- [Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions](#page-49---setting-up-an-aspnet-core-mvc-website-page-69---controllers-and-actions)
- [Page 75 - Using entity and view models](#page-75---using-entity-and-view-models)
- [Page 153 - Exploring the Environment Tag Helper](#page-153---exploring-the-environment-tag-helper)
  - [Static Files Not Being Served in Production](#static-files-not-being-served-in-production)
  - [Bundling and Minification Issues](#bundling-and-minification-issues)
  - [Check If Your Static Files Are Published Correctly](#check-if-your-static-files-are-published-correctly)
  - [Confirm Environment Settings in `_ViewImports.cshtml`](#confirm-environment-settings-in-_viewimportscshtml)
  - [Enable Developer Exception Page for Debugging](#enable-developer-exception-page-for-debugging)
- [Page 155 - Exploring Forms-related Tag Helpers](#page-155---exploring-forms-related-tag-helpers)
- [Page 243 - Page navigation and title verification](#page-243---page-navigation-and-title-verification)
- [Page 323 - Creating an ASP.NET Core Web API with controllers project](#page-323---creating-an-aspnet-core-web-api-with-controllers-project)
- [Page 381 - Summary](#page-381---summary)
- [Page 410 - Enabling entity inserts, updates, and deletes](#page-410---enabling-entity-inserts-updates-and-deletes)
  - [Matching HTTP requests to controller action methods](#matching-http-requests-to-controller-action-methods)
    - [**Routing conventions**](#routing-conventions)
    - [**Method signatures**](#method-signatures)
    - [**Delta and partial updates**](#delta-and-partial-updates)
    - [**Overriding OData routing convention with attribute routing**](#overriding-odata-routing-convention-with-attribute-routing)
- [Page 413 - Calling services in the Northwind MVC website](#page-413---calling-services-in-the-northwind-mvc-website)
- [Page 458 - Using NSubstitute to create test doubles](#page-458---using-nsubstitute-to-create-test-doubles)
- [Page 463 - Installing the dev tunnel CLI](#page-463---installing-the-dev-tunnel-cli)
- [Page 463 - Exploring a dev tunnel with the CLI and an echo service](#page-463---exploring-a-dev-tunnel-with-the-cli-and-an-echo-service)
- [Page 478 - Installing Umbraco CMS](#page-478---installing-umbraco-cms)
- [Page 500 - Good media practices, Page 502 - Uploading images to Umbraco CMS](#page-500---good-media-practices-page-502---uploading-images-to-umbraco-cms)

# Page 2 - Introducing Web Development Using Controllers

> Thanks to [michaelt-94](https://github.com/michaelt-94) for raising [this issue on June 10, 2025](https://github.com/markjprice/web-dev-net9/issues/60).

In the next edition, I plan to swap the order of sections 2 and 3 in Chapter 1:

- Understanding ASP.NET Core
- Structuring projects and managing packages
- Making good use of the GitHub repository for this book
- Building an entity model for use in the rest of the book

This would put the section titled *Making good use of the GitHub repository for this book* immediately after the section titled *Understanding ASP.NET Core*. And I will add a note to tell the reader that the reason that I recommend downloading or cloning the GitHub repository so that they can refer to it while they create their own solution from scratch. That's why the downloaded solution and their own solution should go in different folders. The reader is not just cloning skeleton code that you add to as the book moves forward. Cloning the solution is optional. The book's tasks will walk you through creating all code solutions yourself.

Then the *Structuring projects and managing packages* section would come immediately before the *Building an entity model for use in the rest of the book* section where the reader will create projects in the folder hierarchy. That should improve the flow and reduce confusion.

# Page 3 - History of ASP.NET Core

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on February 13, 2025](https://github.com/markjprice/web-dev-net9/issues/35).

In the second bullet, I describe ASP, as shown in the following bullet:
- **Active Server Pages (ASP)** was released in 1996 and was Microsoft’s first attempt at a platform for dynamic server-side execution of website code. ASP files contain a mix of HTML and code that executes on the server written in the VBScript language.

Readers do not need to know any details of this 30-year-old technology so I will remove the second sentence in the next edition and add a note to explain why I include ASP, as shown in the following bullet:
- **Active Server Pages (ASP)** was released in 1996 and was Microsoft’s first attempt at a platform for dynamic server-side execution of website code. I include this bullet so that you understand where the **ASP** initialism comes from because it is still used today in modern ASP.NET Core.

# Page 24 - Running the Azure SQL Edge container image

> Thanks to a reader who emailed that was having trouble working with Docker and connecting to Azure SQL Edge in the Docker container.

First, in Step 1, I tell the reader to enter a long command. As also mentioned in the improvement for Page 27, in the next edition, I will add a warning about making sure command lines are entered all in one line as shown in the following box:

> **Warning!** The preceding command must be entered all on one line, or the container will not be started up correctly. In particular, the container might start up but without a password set and therefore later you won't be able to connect to it! All command lines used in this book can be found and copied from the following link: https://github.com/markjprice/web-dev-net9/blob/main/docs/command-lines.md

Also, different operating systems may require different quote characters, or none at all. The command line I used on Windows 11 uses single-quotes: '. Note this is not a backtick ` or a double-quote ".

Second, if a reader is unfamiliar with Docker, then they might assume that after starting the container with SQL Server, in Step 3 that the link in the **Port(s)** column is clickable, as shown in *Figure A*, and will navigate to a working website:

![Link in Docker for SQL Server container](docker-sql-uri.png)
*Figure A: Link in Docker for SQL Server container*

But that container image only has SQL Edge in it. SQL Edge is listening on that port and can be connected to using a TCP address, *not* an HTTP address, so Docker is misleading you!. There is *no* web server listening on port 1433 so a web browser that makes a request to `http://localhost:1433` will get an error, as shown in *Figure B*:

![Page not working](docker-sql-uri-fail.png)
*Figure B: Page not working*

This is expected behavior because a database server is not a web server. Many containers in Docker *do* host web server, and in those scenarios having a convenient clickable link is useful. But Docker has no idea which containers have web servers and which do not. All it knows is what ports are mapped from internal ports to external ports. It is up to the developer to know if those links are useful.

Third, if you already have SQL Server installed locally, and it's services are running, then it will be listening to port 1433 and it might take priority over any Docker-hosted SQL Server services that are also trying to listen on port 1433. You might need to stop the local SQL Server before being able to connect to any Docker-hosted SQL Server services. Or change the port number(s) for either the local or Docker-hosted SQL Server services so that they do not conflict.

In the next edition, I will add a warning with the preceding information in all my books.

# Page 27 - Connecting to Azure SQL Edge in a Docker container

> Thanks to [ghlouwho](https://github.com/ghlouwho) for raising [this issue on January 22, 2025](https://github.com/markjprice/web-dev-net9/issues/34).

For readers who fail to connect, I will add a [troubleshooting guide](sql-container-issues.md) with suggestions of how to fix their issues.

I will also add a warning about making sure command lines are entered all in one line as shown in the following box:

> **Warning!** The preceding command must be entered all on one line, or the container will not be started up correctly. All command lines used in this book can be found and copied from the following link: https://github.com/markjprice/web-dev-net9/blob/main/docs/command-lines.md

# Page 30 - Creating the Northwind database using a SQL script

> Thanks to **Mike_H**/`mike_h_16837` for raising asking a question on June 2, 2025 in the Discord channel for this book.

In Step 2, I tell the reader to execute the SQL script to create the Northwind database. But when they see the **Connect** dialog box, some readers don't know what to do.

In the next edition, I will explicitly say that the reader will be shown the **Connect** dialog box and they will need to use the same connection information as a couple of pages earlier to connect to their SQL Server. This is because although they previously connected to their SQL Server via the **Server Explorer** window, they have opened a separate file that does not know about that connection. If the reader were to use the **Server Explorer** to create a new query or other database object then it would already be connected.

# Page 33 - Creating a class library for entity models

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/5).

At the end of Step 1, there is a note that says, "You can target either .NET 8 (LTS) or .NET 9 (STS) for all the projects in this book but you should be consistent. If you choose .NET 9 for the class libraries, then choose .NET 9 for later MVC and Web API projects."

This does not mean that you can download or clone the solution projects and then only change the target framework from `net9.0` to `net8.0` and it will work. What I meant is that you can choose to target .NET 8 when you create all the projects. Some of the project templates have changed between .NET 8 and .NET 9, especially the Aspire templates. Just changing the target version after project creation won't be enough. In the next edition, I will remove this note since every reader should want to target `net10.0` anyway.

# Page 34 - Creating a class library for entity models

> Thanks to [michaelt-94](https://github.com/michaelt-94) for raising [this issue on June 10, 2025](https://github.com/markjprice/web-dev-net9/issues/61).

In Step 6, I wrote, "generate entity class models for all tables, as shown in the following command:"
```
dotnet ef dbcontext scaffold "Data Source=tcp:127.0.0.1,1433;Initial Catalog=Northwind;User Id=sa;Password=s3cret-Ninja;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --namespace Northwind.EntityModels --data-annotations
```

A reader tried this step, but it "did not create any files (maybe this is here the issue is), but there were no errors."

In the next edition, I will add a warning after this step to say that if your database has no user tables, EF Core will silently succeed and generate nothing. I have created an EF Core CLI troubleshooting checklist with suggested fixes here: https://github.com/markjprice/markjprice/blob/main/articles/efcore-cli.md

# Page 36 - Creating a class library for a database context

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/6).

In Step 9, I tell the reader to "add statements to dynamically build a database connection string for SQL Edge in Docker". In Step 10, I tell the reader to "add a class named `NorthwindContextExtensions.cs`. Modify its contents to define an extension method that adds the Northwind database context to a collection of dependency services". There is duplicate code in these classes because the `NorthwindContext` class and its extensions are written to allow developers to instantiate the context class directly as well as via the extension method. They can also override the connection string or choose to accept defaults. 

In all the .NET 10 editions of all four of my books, I will review this code and explain it more in the books, perhaps with a flow diagram showing the different ways to use the `NorthwindContext` class.

# Page 44 - Testing the class libraries using xUnit

At the end of this task, I wrote, "If any of the tests fail, then try to fix the issue." 

In the next edition, I will add an example common error: `System.ArgumentNullException : Value cannot be null. (Parameter 'User ID')` and suggest the reader restart Visual Studio and any command-line terminals so that the environment variables are set and can be read properly.

In the *Setting the user and password for SQL Server authentication* section, in Step 3, after setting the environment variables for username and password, I wrote, "You will need to restart any command prompts, terminal windows, and applications like Visual Studio for this change to take effect." In the next edition, I will make this step more prominent.

# Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/7).

In the note box on page 49, I wrote, "The MVC design pattern as implemented in ASP.NET Core MVC might have been better named **Route-Controller-Model-View (RCMV)** to match the order of the components that are used in the process. But MVC sounds better."

In the first paragraph on page 69, I wrote, "In MVC, the **C** stands for *controller*. As you saw in *Figure 2.1*, the incoming request is handled by the configured HTTP request pipeline, then by a route handler, and then by a controller, which creates a model and passes it to a view. So, the design pattern could have been named **PRCMV**, for **pipeline-route-controller-model-view**, but MVC is simpler and is easier to say. The letters are not in the order of processing!"

I made up both initialisms so neither is more correct than the other. They both make the same two points: 
1. The MVC pattern is more than just models, views, and controllers. 
2. The order of the letters in MVC says nothing about the order of processing an HTTP request. 

In the next edition, I will pick one and remove the other, since it is redundant to include both. 

# Page 75 - Using entity and view models

A reader emailed Packt customer service with the following question: "In a application web ASP.NET Core Mvc if I have in my Model two classes for example: User and Module and User have a property like a collection generics List usermodule; How I can do for what in the various razor pages pass in a object TempData or Session a object of the class User what for inner encapsulate a collection of objects Module. I want pass it TempData or Session of the object User of one razor page to other razor page."

First, this type of question is best asked in the Discord channels because then other readers can answer it too. 

Second, how to store any object graph is the same as storing anything else in `TempData` or `Session`.  The types used just need to be serializable to JSON. Types like `string`, `int`, `float`, and other simple types do not require any additional setup as they are inherently serializable.

In *Chapter 2 Building Websites Using ASP.NET Core MVC*, I explain about models, including, "View models should be immutable, so they are commonly defined using records."

A `record` can easily define an object graph like a `User` combined with multiple `Modules`, as shown in the following code:
```cs
record Module(string ModuleName, [other serializable properties]);

record User(string UserName, List<Module> UserModules, [other serializable properties])
```

# Page 153 - Exploring the Environment Tag Helper

A reader emailed Packt, "In the `Properties` folder, in `launchSettings.json`, for the `https` profile, change the environment setting to `Production`, as shown highlighted in the following JSON: `"https": { ... "environmentVariables": { "ASPNETCORE_ENVIRONMENT": "Production" } },` When I do the above the bootstrap formatting goes away. How do I correct this?"

When you change the `ASPNETCORE_ENVIRONMENT` to `Production`, the behavior of your application changes in a few important ways that could affect Bootstrap formatting. Let's review them one-by-one to troubleshoot your issue.

## Static Files Not Being Served in Production

By default, in ASP.NET Core, static files (like CSS and JavaScript) are not automatically served in production unless explicitly enabled. You should make sure that you have static file middleware enabled in your `Program.cs`:
```cs
// .NET 9 or later.
app.MapStaticAssets();

// .NET 8 or earlier.
app.UseStaticFiles();
```

If one of these is missing, Bootstrap and other front-end assets may not load in production mode.

## Bundling and Minification Issues

In development mode, ASP.NET Core may serve unminified CSS and JavaScript files. However, in production, it may try to serve minified versions (e.g., `bootstrap.min.css` instead of `bootstrap.css`). If those files are missing or not correctly referenced, formatting will break. Ensure your `_Layout.cshtml` (or equivalent view file) includes Bootstrap correctly, as shown in the following markup:
```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" integrity="sha384-whatever" crossorigin="anonymous">
```
Or, if using a local version:
```html
<link rel="stylesheet" href="~/css/bootstrap.min.css" asp-append-version="true">
```

If you're using ASP.NET Core’s built-in bundling/minification, check if Bootstrap’s CSS is included in the right bundle.

## Check If Your Static Files Are Published Correctly

When running in Production, ASP.NET Core expects files to be published before deployment. Run the following command in your terminal:
```shell
dotnet publish -c Release
```
This ensures all static files are included in the published output. Navigate to the `publish/wwwroot/` folder and confirm that Bootstrap’s CSS is there.

## Confirm Environment Settings in `_ViewImports.cshtml`

In some cases, Razor views have conditional rendering based on environment settings. Open `_ViewImports.cshtml` or `_Layout.cshtml` and check if there’s anything like:
```csharp
@if (Env.IsDevelopment())
{
  <link rel="stylesheet" href="~/css/bootstrap.css" />
}
```
This would prevent Bootstrap from loading in production. Instead, explicitly include the correct Bootstrap file.

## Enable Developer Exception Page for Debugging

Try running your app with detailed errors enabled to see if there are any errors preventing Bootstrap from loading. Modify `appsettings.Production.json`:
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "Microsoft.AspNetCore": "Debug"
    }
  }
}
```
Then run:
```shell
dotnet run --environment Production
```

Check the browser’s developer console (*F12*) for any 404 errors related to CSS files.

# Page 155 - Exploring Forms-related Tag Helpers

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on March 5, 2025](https://github.com/markjprice/web-dev-net9/issues/39).

In Step 1, I layout an HTML form using Bootstrap `form-horizontal` class. In Bootstrap 3, `form-horizontal` was used to create a horizontally-aligned form where labels and inputs were placed in a grid layout using `col-*` classes.

Starting with Bootstrap 4, `form-horizontal` was removed. Instead, they recommend using the grid system (`.row` and `.col-*` classes) to achieve the same effect.
The idea is that you explicitly structure your form using `.row` and `.col-*` instead of relying on a dedicated class.

Also, the `.form-control` class is meant for text-based inputs (`<input>`, `<textarea>`, `<select>`), ensuring they are styled consistently.
For buttons, Bootstrap uses `.btn` along with a color class like `.btn-primary`, `.btn-secondary`, and so on.

In the next edition, I will change to use the Bootstrap 4 and 5 way, as shown in the following markup:
```html
<h2>With Form Tag Helper</h2>
<form role="form" asp-controller="Home" asp-action="ProcessShipper">
  <div class="mb-3 row">
    <label asp-for="ShipperId" class="col-sm-2 col-form-label"></label>
    <div class="col-sm-10">
      <input asp-for="ShipperId" class="form-control">
    </div>
  </div>
  <div class="mb-3 row">
    <label asp-for="CompanyName" class="col-sm-2 col-form-label"></label>
    <div class="col-sm-10">
      <input asp-for="CompanyName" class="form-control">
    </div>
  </div>
  <div class="mb-3 row">
    <label asp-for="Phone" class="col-sm-2 col-form-label"></label>
    <div class="col-sm-10">
      <input asp-for="Phone" class="form-control">
    </div>
  </div>
  
  <div class="mb-3">
    <button type="submit" class="btn btn-primary">Submit</button>
  </div>
</form>
```

# Page 243 - Page navigation and title verification

A reader emailed Packt, "I’m having trouble with chapter 7. The command “pwsh” is not recognized. Have not had any luck googling solutions."

In Step 4, I wrote, "Navigate to `Northwind.WebUITests\bin\Debug\net9.0` and, at the command prompt or terminal, install browsers for Playwright to automate, as shown in the following command:"
```shell
pwsh playwright.ps1 install
```

A note links to the official Playwright guide for installing its custom browsers.

> Playwright needs special versions of browser binaries to operate. You must use the Playwright PowerShell script to install these browsers. If you have issues, you can learn more at the following link: https://playwright.dev/dotnet/docs/browsers.

When Googling solutions, a reader should immediately discover that their most likely problem is that PowerShell is not installed properly on their computer (i.e. not installed at all, or installed but not set up so it is found from the command prompt).

In the next edition, I will add extra links to help readers who struggle with this, for example:

**Install PowerShell on Windows, Linux, and macOS**
https://learn.microsoft.com/en-us/powershell/scripting/install/installing-powershell

Some of the answers here might help: **getting started instructions dont work** #1865:
https://github.com/microsoft/playwright-dotnet/issues/1865 

# Page 323 - Creating an ASP.NET Core Web API with controllers project

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on March 10, 2025](https://github.com/markjprice/cs13net9/issues/39) in the C# and .NET book GitHub repository.

In Step 6, I review the `WeatherForecastController.cs` code. This uses a class-level private field to store a `_logger` that is set in the constructor. This is a common pattern, but it means that to execute any action method within that controller, all DI services used in any of the action methods must be instantiated for every call, as shown in the following code:
```cs
using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild",
      "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(
      ILogger<WeatherForecastController> logger)
    {
      _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
      .ToArray();
    }
  }
}
```

This is a waste of time and resources unless every action method needs all the dependency services. A better practice is to use method injection, as shown in the following code:
```cs
using Microsoft.AspNetCore.Mvc;

namespace Northwind.WebApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private static readonly string[] Summaries = new[]
    {
      "Freezing", "Bracing", "Chilly", "Cool", "Mild",
      "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get(ILogger<WeatherForecastController> _logger)
    {
      return Enumerable.Range(1, 5).Select(index => new WeatherForecast
      {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
      })
      .ToArray();
    }
  }
}
```

> **Note**: You can decorate the parameter(s) with `[FromServices]` to explicitly indicate where those parameters will be set from, as shown in the following code: `[FromServices] ILogger<WeatherForecastController> _logger`, but this is optional.

In the next edition, I will add the preceding information. I will also tell the reader to add some calls to `_logger` so that it is actually used in the controller!

# Page 381 - Summary

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/26).

In the **Summary** section, in the second bullet, I wrote, "How to try out and document web service APIs with Swagger."

In casual conversation, people sometimes say "Swagger" when they mean "OpenAPI," but this is technically inaccurate, especially since Swagger is tied to a particular set of tools. Initially, Swagger defined its own specification for APIs, called the Swagger Specification. In 2016, the Swagger Specification was donated to the OpenAPI Initiative, becoming the basis for the OpenAPI Specification. Swagger is now more of a toolset for working with OpenAPI-compliant APIs, including tools for API design, documentation, and testing.

In the next edition, I will write, "How to try out and document web service APIs with OpenAPI." And I will add a note about terminology, as shown above.

# Page 410 - Enabling entity inserts, updates, and deletes

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on April 28, 2025](https://github.com/markjprice/web-dev-net9/issues/48).

In the next edition, I will add a section before implementing the code to explain how OData matches incoming HTTP requests to controller class action methods.

## Matching HTTP requests to controller action methods

In ASP.NET Core OData, the framework determines which HTTP methods are supported by a controller class primarily by inspecting the presence of action methods whose names and parameters match expected OData patterns. It does not use attributes like `[HttpGet]` or `[HttpPost]` in the same way that traditional Web API controllers might.

### **Routing conventions**

ASP.NET Core OData uses routing conventions to map incoming OData requests to controller actions. These conventions examine:

* The **HTTP method** (`GET`, `POST`, `PUT`, `PATCH`, `DELETE`)
* The **OData path** (for example `/Products(78)`)
* The **controller name** (should match the entity set name)
* The **action method name and signature**

For example:

* `GET /Products` → `ProductsController.Get()`
* `GET /Products(78)` → `ProductsController.Get(int key)`
* `POST /Products` → `ProductsController.Post(Product product)`
* `PUT /Products(78)` → `ProductsController.Put(int key, Product update)`
* `PATCH /Products(78)` → `ProductsController.Patch(int key, Delta<Product> delta)`
* `DELETE /Products(78)` → `ProductsController.Delete(int key)`

The supported HTTP methods depend entirely on which matching methods are implemented in your controller.

If you make a call like `PUT /Products(78)` and your OData controller does not define a method with a matching name and signature (`Put(int key, Product product)`), then ASP.NET Core OData returns `HTTP 405 Method Not Allowed`. The framework concludes that the resource exists, but that HTTP method is not allowed on it. The HTTP response also includes an `Allow` header that explicitly lists the HTTP methods supported for the requested resource based on the routes the framework has matched, as shown in the following HTTP response:
```
HTTP/1.1 405 Method Not Allowed
Allow: GET, DELETE
```

The `Allow` header is generated by the OData routing middleware. When a request matches a route pattern but not the HTTP method, ASP.NET Core injects the `Allow` header and lists only the HTTP methods for which your controller implements a matching action method.

### **Method signatures**

The framework uses convention-based method names, so you do not have to decorate methods with `[HttpGet]`, `[HttpPost]`, and so on. The key method names OData looks for include:

| HTTP Method | Controller Method Signature | Notes                             |
| ----------- | ----------------------------| --------------------------------- |
| GET         | `Get()`, `Get([key])`       | Returns entities or entity by key |
| POST        | `Post([entity])`            | Creates a new entity              |
| PUT         | `Put([key], [entity])`      | Full update                       |
| PATCH       | `Patch([key], Delta<T>)`    | Partial update                    |
| DELETE      | `Delete([key])`             | Deletes an entity                 |

You can decorate action method parameters with `[FromRoute]`, `[FromODataUri]`, `[FromBody]`, and other parameter binding attributes, but they do not determine HTTP support. They just clarify how parameters should be resolved.

### **Delta<T> and partial updates**

OData supports partial updates via HTTP `PATCH` using the `Delta<T>` class. If you want to support `PATCH`, you must write a method like:

```cs
public IActionResult Patch(int key, [FromBody] Delta<Product> delta)
```

`Delta<T>` is explicitly designed for `PATCH` requests—not `PUT`—because `PATCH` represents a partial update, whereas `PUT` represents a full replacement of the resource.

With `PUT`, you send the entire entity, any missing properties are assumed to be reset to null or default and the action method parameter must be the full `Product` object. To perform the update in to the entity, you can either find the existing entity and manually set each property (which gives you more control), or you can use a single statement to update the full product: `_context.Entry(updatedProduct).State = EntityState.Modified;`

With `PATCH`, the `Delta<T>` type is a partial representation of the entity. It's designed to track which properties were set and only update those. That's ideal for `PATCH`, where you're not replacing the full resource, as shown in the following code:
```cs
public IActionResult Patch(int key, [FromBody] Delta<Product> delta)
{
    Product? productToUpdate = _context.Products.Find(key);
    if (productToUpdate is null) return NotFound();

    delta.Patch(productToUpdate);
    _context.SaveChanges();

    return Updated(productToUpdate);
}
```

In the HTTP `PATCH` request, you only include the properties you want to change (any omitted properties remain unchanged on the server):
```
### Update an existing product unit price and units in stock.
PATCH {{base_address}}products/78
Content-Type: application/json

{
  "UnitPrice": 60.25,
  "UnitsInStock": 75
}
```

`Delta<T>` internally tracks which properties were set in the incoming JSON. You can inspect it via `delta.GetChangedPropertyNames()` or `delta.TryGetPropertyValue(...)`. This can be useful for validation, logging, or change auditing.

### **Overriding OData routing convention with attribute routing**

Starting with OData 8 and later, ASP.NET Core supports attribute routing for more precise control, which can override the default routing conventions. To make `[HttpPut]` work with a custom method name, you need to switch to attribute routing in your OData configuration, as shown in the following code:
```cs
services.AddControllers()
  .AddOData(opt =>
  {
    opt.EnableAttributeRouting()
    ...
```

Next, map the route to the non-conventionally named method, as shown in the following code:
```cs
[Route("odata/Products({key})")]
[HttpPut]
public IActionResult UpdateProduct(int key, [FromBody] Product product)
{
  ...
}
```

In the preceding code, `UpdateProduct` will correctly respond to `PUT /odata/Products(78)`, because you're explicitly telling ASP.NET Core which path and method it handles. This is more common when you want to support complex custom routes or go beyond the OData conventions. But for basic CRUD with entity sets, you typically don't need this. Using attributes is much more work:
- You must specify the exact OData path in the `[Route]` attribute.
- The method must still match the expected signature conventions like `(int key, [FromBody] Product product)` for a `PUT` method handler.
- You lose the automatic conventions so everything must be mapped manually.
- You still need to define your EDM model correctly otherwise the OData middleware won't understand your entity types or routing logic.

# Page 413 - Calling services in the Northwind MVC website

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/29).

In Step 7, I wrote, "Optionally, start the `Northwind.WebApi` project using the `https` profile without debugging." 

If the reader only clicks the **OData** menu item to try it out, and not any of the features that call the `Northwind.WebApi` web service, then they do not need that project running. 

In the next edition, I will either delete that step, or explain why I've put it in and list the features that require it, or if I encourage the use of Aspire from the very beginning of the book as I plan to do, then all projects will start automatically without needing to have a manual step. 

# Page 458 - Using NSubstitute to create test doubles

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 13, 2025](https://github.com/markjprice/web-dev-net9/issues/30).

In the code on page 461, I use the `When` and `Do` methods but I have not explained how they work. 

In the next edition, I will add rows to *Table 11.5* to explain what these two methods do, as shown below:

Extension method|Description
---|---
`When`|Used to specify a condition or an action you want to monitor or react to. It's often used when you don't just want to return a specific value from a method but want to perform additional behavior when a method is called.
`Do`|Used to define the custom behavior that should be executed when the specified condition (in the `When` method) is met. This is where you write the logic that the mock should perform. `Do` accepts a lambda expression, which provides access to the arguments of the intercepted method call. These arguments are available via the `CallInfo` parameter.

And I will show some example code:
```cs
substitute.When(x => x.SomeMethod(Arg.Any<int>()))
  .Do((CallInfo info) => 
  {
    // Could also use info.Args(0)
    Console.WriteLine($"SomeMethod called with argument: {info[0]}");
  });
```

# Page 463 - Installing the dev tunnel CLI

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on May 7, 2025](https://github.com/markjprice/web-dev-net9/issues/51).

In the next edition, if the CLI is still in preview, then I will add a warning:

> **Warning!** This feature is currently in public preview. The CLI might have bugs that are introduced and fixed over time. Command names and options may change in future releases. The preview version is provided without a service-level agreement, and it's not recommended for production workloads. Certain features might not be supported or might have constrained capabilities. Read the latest about the CLI at the following link: https://learn.microsoft.com/en-us/azure/developer/dev-tunnels/cli-commands

# Page 463 - Exploring a dev tunnel with the CLI and an echo service

After Step 2, I will add a note:

> If you get error, `Missing wamcompat_id_token in WAM case`, then try using device flow to login instead, as shown in the following command: `devtunnel login -d`

# Page 478 - Installing Umbraco CMS

In Step 1, I wrote the command to install project templates for Umbraco CMS version 14.2, as shown in the following command:
```
dotnet new install Umbraco.Templates::14.2.0
```

This installs three project templates, as shown in the following output:
```
Templates            Short Name          Language
-------------------------------------------------
Umbraco Project      umbraco             [C#]
Umbraco Package RCL  umbracopackage-rcl  [C#]
Umbraco Package      umbracopackage      [C#]
```

If you do not explicitly specify the version, then the latest version will be installed. At the time of writing in December 2024, that is version `15.0.0`. This installs three project templates, as shown in the following output:
```
Templates               Short Name         Language
---------------------------------------------------
Umbraco Docker Compose  umbraco-compose            
Umbraco Extension       umbraco-extension  [C#]    
Umbraco Project         umbraco            [C#]    
```

Since we are only using the **Umbraco Project** / `umbraco` project template, the other project templates don't matter.

I recommend that you use version `14.2.0` as I did in the book. If you choose to install a later version like `15.0.0` then be prepared for changes to behavior.

> **Warning!** You might need to restart Visual Studio to see newly added project templates.

> **Note**: The next edition of this book (due to be published in December 2025) will use Umbraco CMS version `17.0.0` which will be an LTS release that targets .NET 10. Umbraco CMS 17 will be supported from November 27, 2025 until November 27, 2028 so it will be a good version to target.

# Page 500 - Good media practices, Page 502 - Uploading images to Umbraco CMS

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 14, 2025](https://github.com/markjprice/web-dev-net9/issues/33).

I wrote, "Editors should name media files descriptively before uploading, for example, `team-photo-john-doe.jpg` instead of `IMG_1234.jpg`." 

But in the next task, in Step 3, I tell the reader to upload sample images `category1.jpeg` to `category8.jpeg`. These images are not named descriptively because they were used earlier in the book to render categories programmtically based on `CategoryId` primary key value. 

In the next edition, I will provide some other images with meaningful names for the reader to upload instead. 
