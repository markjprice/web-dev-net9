**Improvements** (4 items)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page 36 - Creating a class library for a database context](#page-36---creating-a-class-library-for-a-database-context)
- [Page 49 - Setting up an ASP.NET Core MVC website, Page 69 - Controllers and actions](#page-49---setting-up-an-aspnet-core-mvc-website-page-69---controllers-and-actions)
- [Chapter 13 - Installing Umbraco CMS](#chapter-13---installing-umbraco-cms)

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

If you do not explicitly specify the version, then the latest version will be installed. At the time of writing in December 2024, that is version 15.0.0. This installs three project templates, as shown in the following output:
```
Templates               Short Name         Language
---------------------------------------------------
Umbraco Docker Compose  umbraco-compose            
Umbraco Extension       umbraco-extension  [C#]    
Umbraco Project         umbraco            [C#]    
```

Since we are only using the **Umbraco Project** / `umbraco` project template, the other project templates don't matter.

I recommend that you use version 14.2.0 as I did in the book. If you choose to install a later version like 15.0.0 then be prepared for changes to behavior.

> **Warning!** You might need to restart Visual Studio to see newly added project templates.

> **Note**: The next edition will use Umbraco CMS version 17.0.0 which will be an LTS release that targets .NET 10.

