**Improvements** (14 items)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 3 - History of ASP.NET Core](#page-3---history-of-aspnet-core)
- [Page 27 - Connecting to Azure SQL Edge in a Docker container](#page-27---connecting-to-azure-sql-edge-in-a-docker-container)
- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page 36 - Creating a class library for a database context](#page-36---creating-a-class-library-for-a-database-context)
- [Page 44 - Testing the class libraries using xUnit](#page-44---testing-the-class-libraries-using-xunit)
- [Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions](#page-49---setting-up-an-aspnet-core-mvc-website-page-69---controllers-and-actions)
- [Page x - Using entity and view models](#page-x---using-entity-and-view-models)
- [Page 153 - Exploring the Environment Tag Helper](#page-153---exploring-the-environment-tag-helper)
  - [Static Files Not Being Served in Production](#static-files-not-being-served-in-production)
  - [Bundling and Minification Issues](#bundling-and-minification-issues)
  - [Check If Your Static Files Are Published Correctly](#check-if-your-static-files-are-published-correctly)
  - [Confirm Environment Settings in `_ViewImports.cshtml`](#confirm-environment-settings-in-_viewimportscshtml)
  - [Enable Developer Exception Page for Debugging](#enable-developer-exception-page-for-debugging)
- [Chapter 7 - Page navigation and title verification](#chapter-7---page-navigation-and-title-verification)
- [Chapter 13 - Installing Umbraco CMS](#chapter-13---installing-umbraco-cms)
- [Page 381 - Configuring the customer repository and Web API controller](#page-381---configuring-the-customer-repository-and-web-api-controller)
- [Page 413 - Calling services in the Northwind MVC website](#page-413---calling-services-in-the-northwind-mvc-website)
- [Page 458 - Using NSubstitute to create test doubles](#page-458---using-nsubstitute-to-create-test-doubles)
- [Page 500 - Good media practices, Page 502 - Uploading images to Umbraco CMS](#page-500---good-media-practices-page-502---uploading-images-to-umbraco-cms)

# Page 3 - History of ASP.NET Core

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on February 13, 2025](https://github.com/markjprice/web-dev-net9/issues/35).

In the second bullet, I describe ASP:
- **Active Server Pages (ASP)** was released in 1996 and was Microsoft’s first attempt at a platform for dynamic server-side execution of website code. ASP files contain a mix of HTML and code that executes on the server written in the VBScript language.

Readers do not need to know any details of this 30-year-old technology so I will remove the second sentence in the next edition and add a note to explain why I include the bullet for ASP:
- **Active Server Pages (ASP)** was released in 1996 and was Microsoft’s first attempt at a platform for dynamic server-side execution of website code. I include this bullet so that you understand where the **ASP** initialism comes from because it is still used today in modern ASP.NET Core.

# Page 27 - Connecting to Azure SQL Edge in a Docker container

> Thanks to [ghlouwho](https://github.com/ghlouwho) for raising [this issue on January 22, 2025](https://github.com/markjprice/web-dev-net9/issues/34).

For readers who fail to connect, I will add a [troubleshooting guide](sql-container-issues.md) with suggestions of how to fix their issues.

I will also add a warning about making sure command lines are entered all in one line:

> **Warning!** The preceding command must be entered all on one line, or the container will not be started up correctly. All command lines used in this book can be found and copied from the following link: https://github.com/markjprice/web-dev-net9/blob/main/docs/command-lines.md

# Page 33 - Creating a class library for entity models

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/5).

At the end of Step 1, there is a note that says, "You can target either .NET 8 (LTS) or .NET 9 (STS) for all the projects in this book but you should be consistent. If you choose .NET 9 for the class libraries, then choose .NET 9 for later MVC and Web API projects."

This does not mean that you can download or clone the solution projects and then only change the target framework from `net9.0` to `net8.0` and it will work. What I meant is that you can choose to target .NET 8 when you create all the projects. Some of the project templates have changed between .NET 8 and .NET 9, especially the Aspire templates. Just changing the target version after project creation won't be enough. In the next edition, I will remove this note since every reader should want to target `net10.0` anyway.

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

# Page x - Using entity and view models

A reader emailed Packt customer service with the following question: "In a application web ASP.NET Core Mvc if I have in my Model two classes for example: User and Module and User have a property like a collection generics List usermodule; How I can do for what in the various razor pages pass in a object TempData or Session a object of the class User what for inner encapsulate a collection of objects Module. I want pass it TempData or Session of the object User of one razor page to other razor page."

First, this type of question is best asked in the Discord channels because then other readers can answer it too. 

Second, how to store any object graph is the same as storing anything else in `TempData` or `Session`.  The types used just need to be serializable to JSON. Types like `string`, `int`, `float`, and other simple types do not require any additional setup as they are inherently serializable.

In Chapter 2, I explain about models, including, "View models should be immutable, so they are commonly defined using records."

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

# Chapter 7 - Page navigation and title verification

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

# Chapter 13 - Installing Umbraco CMS

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

> **Note**: The next edition will use Umbraco CMS version `17.0.0` which will be an LTS release that targets .NET 10.

# Page 381 - Configuring the customer repository and Web API controller

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/26).

In the **Summary** section, in the second bullet, I wrote, "How to try out and document web service APIs with Swagger."

In casual conversation, people sometimes say "Swagger" when they mean "OpenAPI," but this is technically inaccurate, especially since Swagger is tied to a particular set of tools. Initially, Swagger defined its own specification for APIs, called the Swagger Specification. In 2016, the Swagger Specification was donated to the OpenAPI Initiative, becoming the basis for the OpenAPI Specification. Swagger is now more of a toolset for working with OpenAPI-compliant APIs, including tools for API design, documentation, and testing.

In the next edition, I will write, "How to try out and document web service APIs with OpenAPI." And I will add a note about terminology, as shown above.

# Page 413 - Calling services in the Northwind MVC website

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/29).

In Step 7, I wrote, "Optionally, start the `Northwind.WebApi` project using the `https` profile without debugging." 

If the reader only clicks the OData menu item to try it out, and not any of the features that call the `Northwind.WebApi` web service, then they do not need that project running. 

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

# Page 500 - Good media practices, Page 502 - Uploading images to Umbraco CMS

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 14, 2025](https://github.com/markjprice/web-dev-net9/issues/33).

I wrote, "Editors should name media files descriptively before uploading, for example, `team-photo-john-doe.jpg` instead of `IMG_1234.jpg`." 

But in the next task, I tell the reader to upload sample images `category1.jpeg` to `category8.jpeg`. These images are not named descriptively because they were used earlier in the book to render categories programmtically based on `CategoryId` primary key value. 

In the next edition, I will provide some other images with meaningful names for the reader to upload instead. 
