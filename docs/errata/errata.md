**Errata** (4 items)

If you find any mistakes, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 15 - Central Package Management](#page-15---central-package-management)
- [Page 23 - Installing Docker and the Azure SQL Edge container image](#page-23---installing-docker-and-the-azure-sql-edge-container-image)
- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page x - What does UseMigrationsEndPoint do?](#page-x---what-does-usemigrationsendpoint-do)


# Page 15 - Central Package Management

> Thanks to [Rob](https://github.com/robyyo) for raising [this issue on December 26, 2024](https://github.com/markjprice/web-dev-net9/issues/2).

Packt publishes Early Access editions of some of their books. They are available on the website via Packt subscription. The content uses preliminary drafts of books that will change during the writing and editing process. Once the final version is signed off by author and publisher, the paperback, Kindle, and other ebook formats are produced. The final step is to update the Early Access online web edition to match the published edition but sometimes this process takes up to a week after publish date. 

In the Early Access edition of this book, *Chapter 1* included the following package versions for testing in the `Directory.Packages.props` file:
```xml
<ItemGroup Label="For unit testing.">
  <PackageVersion Include="coverlet.collector" Version="6.0.2" />
  <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="18.0.0" />
  <PackageVersion Include="xunit" Version="2.9.0" />
  <PackageVersion Include="xunit.runner.visualstudio" Version="3.0.0" />
</ItemGroup>
```

But in the final published editions they are as shown in the following markup:
```xml
<ItemGroup Label="For testing.">
  <PackageVersion Include="coverlet.collector" Version="6.0.2" />
  <PackageVersion Include="Microsoft.NET.Test.Sdk" Version="17.11.1" />
  <PackageVersion Include="xunit" Version="2.9.2" />
  <!--The following package was still a preview on .NET 9 release day.-->
  <PackageVersion Include="xunit.runner.visualstudio" Version="3.0.0-pre.49" />
  <PackageVersion Include="Microsoft.Playwright" Version="1.49.0" />
  <PackageVersion Include="Microsoft.AspNetCore.Mvc.Testing" Version="9.0.0" />
</ItemGroup>
```

And remember to check if a newer package version has been released. For example, the `Microsoft.NET.Test.Sdk` package is already now `17.12.0`, so I updated the solution code in the book's GitHub repository. 

# Page 23 - Installing Docker and the Azure SQL Edge container image

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/3).

In the paragraph that leads in to the numbered steps, I wrote, "Azure SQL Edge requires a 64-bit processor (either x64 or ARM64), with a minimum of one processor and 1 GB RAM on the host:"

In the next edition, I will simplify that statement to the following, "Azure SQL Edge requires a 64-bit processor (either x64 or ARM64), with a minimum of 1 GB RAM on the host:"

# Page 33 - Creating a class library for entity models

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 2, 2025](https://github.com/markjprice/web-dev-net9/issues/4).

In the **Good Practice** box, I use the phrase "data context". In other places, I use the phrase "database context". Both uses refer to a class that derives from `DbContext` that represents a combination of the Unit Of Work and Repository patterns such that it can be used to query from a database and group together changes that will then be written back to the store as a unit. 

The Microsoft official documentation just uses the word "context" when referring to this class but I feel that loses some meaning. In future editions, I will try to consistently use the phrase "database context".

# Page x - What does UseMigrationsEndPoint do?

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/8).

In the fourth paragraph, I wrote, "You can find the source code for the `UseMigrationsEndPoint` extension method at the following link: https://github.com/dotnet/aspnetcore/blob/main/src/Middleware/Diagnostics.EntityFrameworkCore/src/MigrationsEndPointOptions.cs#L18."

But we do not care about the source code for the `UseMigrationsEndPoint` extension method itself. We just want to know the relative path that it uses. 

So the link is correct, because it shows us what the path is defined by a property on the `MigrationsEndPointOptions` class named `DefaultPath`. But the description is misleading, so in the next edition I will write, "You can find the source code for the relative path used by the `UseMigrationsEndPoint` extension method at the following link: https://github.com/dotnet/aspnetcore/blob/main/src/Middleware/Diagnostics.EntityFrameworkCore/src/MigrationsEndPointOptions.cs#L18."
