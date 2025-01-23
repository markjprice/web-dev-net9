**Improvements** (9 items)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 27 - Connecting to Azure SQL Edge in a Docker container](#page-27---connecting-to-azure-sql-edge-in-a-docker-container)
- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page 36 - Creating a class library for a database context](#page-36---creating-a-class-library-for-a-database-context)
- [Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions](#page-49---setting-up-an-aspnet-core-mvc-website-page-69---controllers-and-actions)
- [Chapter 13 - Installing Umbraco CMS](#chapter-13---installing-umbraco-cms)
- [Page 381 - Configuring the customer repository and Web API controller](#page-381---configuring-the-customer-repository-and-web-api-controller)
- [Page 413 - Calling services in the Northwind MVC website](#page-413---calling-services-in-the-northwind-mvc-website)
- [Page 458 - Using NSubstitute to create test doubles](#page-458---using-nsubstitute-to-create-test-doubles)
- [Page 500 - Good media practices, Page 502 - Uploading images to Umbraco CMS](#page-500---good-media-practices-page-502---uploading-images-to-umbraco-cms)

# Page 27 - Connecting to Azure SQL Edge in a Docker container

> Thanks to [ghlouwho](https://github.com/ghlouwho) for raising [this issue on January 22, 2025](https://github.com/markjprice/web-dev-net9/issues/34).

For readers who fail to connect, I will add a [troubleshooting guide](sql-container-issues.md) with suggestions of how to fix their issues.

# Page 33 - Creating a class library for entity models

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/5).

At the end of Step 1, there is a note that says, "You can target either .NET 8 (LTS) or .NET 9 (STS) for all the projects in this book but you should be consistent. If you choose .NET 9 for the class libraries, then choose .NET 9 for later MVC and Web API projects."

This does not mean that you can download or clone the solution projects and then only change the target framework from `net9.0` to `net8.0` and it will work. What I meant is that you can choose to target .NET 8 when you create all the projects. Some of the project templates have changed between .NET 8 and .NET 9, especially the Aspire templates. Just changing the target version after project creation won't be enough. In the next edition, I will remove this note since every reader should want to target `net10.0` anyway.

# Page 36 - Creating a class library for a database context

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/6).

In Step 9, I tell the reader to "add statements to dynamically build a database connection string for SQL Edge in Docker". In Step 10, I tell the reader to "add a class named `NorthwindContextExtensions.cs`. Modify its contents to define an extension method that adds the Northwind database context to a collection of dependency services". There is duplicate code in these classes because the `NorthwindContext` class and its extensions are written to allow developers to instantiate the context class directly as well as via the extension method. They can also override the connection string or choose to accept defaults. 

In all the .NET 10 editions of all four of my books, I will review this code and explain it more in the books, perhaps with a flow diagram showing the different ways to use the `NorthwindContext` class.

# Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/7).

In the note box on page 49, I wrote, "The MVC design pattern as implemented in ASP.NET Core MVC might have been better named **Route-Controller-Model-View (RCMV)** to match the order of the components that are used in the process. But MVC sounds better."

In the first paragraph on page 69, I wrote, "In MVC, the **C** stands for *controller*. As you saw in *Figure 2.1*, the incoming request is handled by the configured HTTP request pipeline, then by a route handler, and then by a controller, which creates a model and passes it to a view. So, the design pattern could have been named **PRCMV**, for **pipeline-route-controller-model-view**, but MVC is simpler and is easier to say. The letters are not in the order of processing!"

I made up both initialisms so neither is more correct than the other. They both make the same two points: 
1. The MVC pattern is more than just models, views, and controllers. 
2. The order of the letters in MVC says nothing about the order of processing an HTTP request. 

In the next edition, I will pick one and remove the other, since it is redundant to include both. 

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
