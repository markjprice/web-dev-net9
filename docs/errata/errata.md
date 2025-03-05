**Errata** (27 items)

If you find any mistakes, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page 15 - Central Package Management](#page-15---central-package-management)
- [Page 23 - Installing Docker and the Azure SQL Edge container image](#page-23---installing-docker-and-the-azure-sql-edge-container-image)
- [Page 33 - Creating a class library for entity models](#page-33---creating-a-class-library-for-entity-models)
- [Page 67 - What does UseMigrationsEndPoint do?](#page-67---what-does-usemigrationsendpoint-do)
- [Page 81 - Implementing views](#page-81---implementing-views)
- [Page 83 - How cache busting with Tag Helpers works](#page-83---how-cache-busting-with-tag-helpers-works)
- [Page 97 - Temporarily storing data](#page-97---temporarily-storing-data)
- [Page 117 - Displaying Northwind suppliers](#page-117---displaying-northwind-suppliers)
- [Page 118 - Inserting, updating, and deleting suppliers](#page-118---inserting-updating-and-deleting-suppliers)
- [Page 129 - Querying a database and using display templates](#page-129---querying-a-database-and-using-display-templates)
- [Page 143 - Comparing HTML Helpers and Tag Helpers](#page-143---comparing-html-helpers-and-tag-helpers)
- [Page 154 - Exploring Forms-related Tag Helpers](#page-154---exploring-forms-related-tag-helpers)
- [Page 158 - Localizing your user interface](#page-158---localizing-your-user-interface)
- [Page 159 - If you are using Visual Studio](#page-159---if-you-are-using-visual-studio)
- [Page 161 - If you are using VS Code](#page-161---if-you-are-using-vs-code)
- [Page 162 - If you are using VS Code](#page-162---if-you-are-using-vs-code)
- [Page 163 - Other resource file tools](#page-163---other-resource-file-tools)
- [Page 208 - Exploring in-memory object caching](#page-208---exploring-in-memory-object-caching)
- [Page 267 - When you cannot use constructor injection](#page-267---when-you-cannot-use-constructor-injection)
- [Page 295 - Configuration validation](#page-295---configuration-validation)
- [Page 307 - Adding Aspire to an existing solution](#page-307---adding-aspire-to-an-existing-solution)
- [Page 308 - Adding Aspire to an existing solution](#page-308---adding-aspire-to-an-existing-solution)
- [Page 337 - Configuring the customer repository and Web API controller](#page-337---configuring-the-customer-repository-and-web-api-controller)
- [Page 399 - Creating an HTTP file for making requests](#page-399---creating-an-http-file-for-making-requests)
- [Page 411 - Calling services in the Northwind MVC website](#page-411---calling-services-in-the-northwind-mvc-website)
- [Page 460 - Mocking with NSubstitute example](#page-460---mocking-with-nsubstitute-example)
- [Page 485 - Creating and initializing a new Umbraco project](#page-485---creating-and-initializing-a-new-umbraco-project)


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

In the **Good Practice** box, I use the phrase "data context". In other places, I use the phrase "database context". Both uses refer to a class that derives from `DbContext` that represents a combination of the **Unit Of Work** and **Repository** patterns such that it can be used to query from a database and group together changes that will then be written back to the store as a unit. 

The Microsoft official documentation just uses the word "context" when referring to this class but I feel that loses some meaning. In future editions, I will try to consistently use the phrase "database context".

# Page 67 - What does UseMigrationsEndPoint do?

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/8).

This section is about trying to find out what path is configured as an endpoint when you call the `UseMigrationsEndPoint` extension method. We already know what calling the `UseMigrationsEndPoint` extension method does conceptually: it configures a route that if called, triggers a database migration. What we don't know is what the relative path is for that route. 

In the fourth paragraph, I wrote, "You can find the source code for the `UseMigrationsEndPoint` extension method at the following link: https://github.com/dotnet/aspnetcore/blob/main/src/Middleware/Diagnostics.EntityFrameworkCore/src/MigrationsEndPointOptions.cs#L18."

But we do not care about the source code for the `UseMigrationsEndPoint` extension method itself. We just want to know the relative path that it uses for its endpoint. 

So the link is correct, because it shows us what the path is defined by a property on the `MigrationsEndPointOptions` class named `DefaultPath`. But the description is misleading. In the next edition I will write, "You can find the source code for the relative path used by the `UseMigrationsEndPoint` extension method at the following link: https://github.com/dotnet/aspnetcore/blob/main/src/Middleware/Diagnostics.EntityFrameworkCore/src/MigrationsEndPointOptions.cs#L18."

# Page 81 - Implementing views

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/9).

At the end of Step 9, I wrote, "If you want to navigate to a feature in a Razor class library, like the employees component that you created in the previous chapter, then you use `asp-area` to specify the feature name."

I originally planned to have sections about view components and Razor class libraries but they were postponed to the next edition. If I do add those sections and have a task that creates an employees component, then I will be able to leave this sentence unchanged. Otherwise, I will change it to, "If you want to navigate to a feature in a Razor class library then you use `asp-area` to specify the feature name."

# Page 83 - How cache busting with Tag Helpers works

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/10).

The path in the `<script>` element has an extra space, as shown in the following markup:
```html
<script src="~/js/site.js? v=Kl_dqr9NVtnMdsM2MUg4qthUnWZm5T1fCEimBPWDNgM"></
script>
```

In the next edition, I will delete the extra space, as shown in the following markup:
```html
<script src="~/js/site.js?v=Kl_dqr9NVtnMdsM2MUg4qthUnWZm5T1fCEimBPWDNgM"></
script>
```

# Page 97 - Temporarily storing data

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 3, 2025](https://github.com/markjprice/web-dev-net9/issues/11).

In Step 2, I wrote, "(You will learn more about middleware later in this chapter.)" But during final drafts of the book, I moved this section from Chapter 8 to Chapter 2, so this note is no longer true. In the next edition, I will delete the note, and I will add a new section briefly introducing middleware and other terminology to Chapter 1.

# Page 117 - Displaying Northwind suppliers

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 4, 2025](https://github.com/markjprice/web-dev-net9/issues/13).

In Step 5, I show the reader how to render the links to edit and delete a supplier using simple anchor tags (and with the wrong path!), as shown in the following markup:
```html
<a href="edit/@s.SupplierId">Edit</a>
<a href="delete/@s.SupplierId">Delete</a>
```

But the links should be rendered using the Anchor Tag Helper to make it clearer, as shown in the following markup:
```html
<a asp-controller="Home" asp-action="EditSupplier"
   asp-route-id="@s.SupplierId">Edit</a>
<a asp-controller="Home" asp-action="DeleteSupplier"
   asp-route-id="@s.SupplierId">Delete</a>
```

I also forgot to add the markup for the **Add New Supplier** button that should appear between the **Suppliers** heading and the table of suppliers, as shown in the following markup:
```html
<h1 class="display-2">Suppliers</h1>
<a class="btn btn-outline-primary"
   asp-controller="Home" asp-action="AddSupplier">Add New Supplier</a>
<table class="table">
```

The markup was already correct in the code solution found here:
https://github.com/markjprice/web-dev-net9/blob/main/code/MatureWeb/Northwind.Mvc/Views/Home/Suppliers.cshtml

# Page 118 - Inserting, updating, and deleting suppliers

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 4, 2025](https://github.com/markjprice/web-dev-net9/issues/12).

In Step 5, the first bullet says, "The `<form>` element with a `PUT` method is ordinary HTML, so an `<input type="submit" />` element inside it will make an HTTP `PUT` request back to the current path with values of any other elements inside that form."

But HTML forms inherently support only two HTTP methods: `GET` and `POST`. They do not natively support `PUT`, `DELETE`, or other HTTP methods. This limitation means that when you need to use `PUT` or `DELETE`, you cannot specify these methods directly in the `<form>` element. 

A convention in ASP.NET Core MVC is to simulate these methods using `POST`, often with the help of a hidden input field called `_method` or specifying the action in the path, like `/home/editsupplier` and `/home/deletesupplier`.

In the next edition, I will change `PUT` to `POST` in that sentence, and I will add a note at the start of this section to explain why we do not use `PUT` or `DELETE` methods, despite in a RESTful API design:
- `POST` is typically used for creating resources.
- `PUT` is used for updating resources.
- `DELETE` is used for deleting resources.

# Page 129 - Querying a database and using display templates

> Thanks to [Paul Marangoni](https://github.com/pmarangoni) for raising [this issue on March 3, 2025](https://github.com/markjprice/web-dev-net9/issues/38).

In Step 3, I tell the reader to modify the contents of `CostlyProducts.cshtml`. But two of the column values for category name and supplier company name do not output because of missing `@` before `Html`. The correct statements should be as shown in the following markup:
```html
@foreach (Product p in Model)
{
  <tr>
    <td>
      @if (p.Category is not null) { @Html.DisplayFor(modelItem => p.Category.CategoryName); }
    </td>
    <td>
      @if (p.Supplier is not null) { @Html.DisplayFor(modelItem => p.Supplier.CompanyName); }
    </td>
```

Or you can use block style, as I use in the [code solution for this file](https://github.com/markjprice/web-dev-net9/blob/main/code/MatureWeb/Northwind.Mvc/Views/Home/CostlyProducts.cshtml#L29), as shown in the following markup:
```html
@foreach (Product p in Model)
{
  <tr>
    <td>
      @if (p.Category is not null) 
      { 
        @Html.DisplayFor(modelItem => p.Category.CategoryName); 
      }
    </td>
    <td>
      @if (p.Supplier is not null) 
      { 
        @Html.DisplayFor(modelItem => p.Supplier.CompanyName); 
      }
    </td>
```

# Page 143 - Comparing HTML Helpers and Tag Helpers

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/14).

I showed two examples of rendering a hyperlink:
```cs
@Html.ActionLink("View our privacy policy.", "Privacy", "Index")

@Html.ActionLink(linkText: "View our privacy policy.",
  action: "Privacy", controller: "Index")
```

But the controller name is `Home`, not `Index`, so the markup should be:
```cs
@Html.ActionLink("View our privacy policy.", "Privacy", "Home")

@Html.ActionLink(linkText: "View our privacy policy.",
  action: "Privacy", controller: "Home")
```

# Page 154 - Exploring Forms-related Tag Helpers

> Thanks to a reader who emailed a question about this issue to Packt.

In Step 1, I told the reader to enter markup for two forms. The second form uses the **Label Tag Helper**, but the `<label>` elements I used were self-closing, as shown in the following markup:
```html
<label asp-for="ShipperId" class="form-label" />
```

Self-closing tags are not supported by the **Label Tag Helper**. You must use a pair of open and close tags, as shown in the following markup:
```html
<label asp-for="ShipperId" class="form-label"></label>
```

The complete corrected second form is shown in the following markup:
```html
<h2>With Form Tag Helper</h2>
<form asp-controller="Home" asp-action="ProcessShipper"
      class="form-horizontal" role="form">
  <div>
    <div class="mb-3">
      <label asp-for="ShipperId" class="form-label"></label>
      <input asp-for="ShipperId" class="form-control">
    </div>
    <div class="mb-3">
      <label asp-for="CompanyName" class="form-label"></label>
      <input asp-for="CompanyName" class="form-control">
    </div>
    <div class="mb-3">
      <label asp-for="Phone" class="form-label"></label>
      <input asp-for="Phone" class="form-control">
    </div>
    <div class="mb-3">
      <input type="submit" class="form-control">
    </div>
  </div>
</form>
```

Also, the **Label Tag Helper** will use the property names from the model as the labels in the form, so it will use **ShipperId** and **CompanyName** by default. 

To override these values, in the `Northwind.EntityModels` project, in the `Shipper.cs` class, you can decorate the properties with the `[Display]` attribute, as shown in the following code:
```cs
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Northwind.EntityModels;

public partial class Shipper
{
  [Key]
  [Display(Name = "Shipper ID")] // Used by the Label Tag Helper.
  public int ShipperId { get; set; }

  [StringLength(40)]
  [Display(Name = "Company Name")] // Used by the Label Tag Helper.
  public string CompanyName { get; set; } = null!;

  [StringLength(24)]
  public string? Phone { get; set; }

  [InverseProperty("ShipViaNavigation")]
  public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
```

# Page 158 - Localizing your user interface

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/15).

I wrote, "In the coding task, you will create a console app with an embedded invariant culture and satellite assemblies for Danish, French, French-Canadian, Polish, and Iranian (Persian)."

I should have written, "In the coding task, you will add resources to the ASP.NET Core MVC project that compile to an embedded invariant culture (English) and satellite assemblies for French (Neutral), French (France), and English (British)."

# Page 159 - If you are using Visual Studio

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/16).

*Figure 4.6* to *Figure 4.9* all show the `Orders.resx` file in a folder structure: `Resources\Views\Orders` but they should be `Resources\Views\Home`.

In the next edition, I will retake or edit the screenshots to show the correct folder name `Home`.

Also, in Step 1, the path says `Resource\Views\Home` when it should be `Resources\Views\Home`.

# Page 161 - If you are using VS Code

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/17).

In Step 1, I wrote, "In `Resources\Views\Orders`, add a new file named `Index.resx`."

This should be, "In `Resources\Views\Home`, add a new file named `Orders.resx`."

# Page 162 - If you are using VS Code

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/18).

In Step 6, I wrote, "modify the `value` column", when I should have written, "modify the `value` element".

# Page 163 - Other resource file tools

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 5, 2025](https://github.com/markjprice/web-dev-net9/issues/19).

I wrote, "...without needing to recompile the original console app." I should have written, "...without needing to recompile the original project."

# Page 208 - Exploring in-memory object caching

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 6, 2025](https://github.com/markjprice/web-dev-net9/issues/20).

In Step 5, I wrote, "add statements to try to get the product from the cache, and if it is not cached, get it from the database and set it in the cache, using a sliding expiration of one hour". The sliding expiration should be five seconds, to match the code: `SlidingExpiration = TimeSpan.FromSeconds(5)`.

In Step 9, I wrote, "Click **Reload this page** within 30 seconds", but this should be "5 seconds". 

In Step 10, I wrote, "Wait at least 30 seconds", but this should be "5 seconds". 

In Step 11, I wrote, "within the 30-second sliding expiration window", but this should be "5-second".

In the next edition, I might change the duration to ten seconds to give readers more time to review the console output and click reload.

# Page 267 - When you cannot use constructor injection

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 7, 2025](https://github.com/markjprice/web-dev-net9/issues/21).

For the **Background services** bullet, I ended with the sentence, "The solution is to use method injection by resolving services within the `ExecuteAsync` method." 

I should have written, "The solution is to create a scope with the `IServiceScopeFactory.CreateScope()` API, as described in the following link: https://learn.microsoft.com/en-us/dotnet/core/extensions/scoped-service."

# Page 295 - Configuration validation

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 9, 2025](https://github.com/markjprice/web-dev-net9/issues/22).

In this section, I wrote, "ASP.NET Core allows you to validate configuration options. This can be done by implementing the `IValidateOptions<T>` interface or using the `Validate` extension method, as shown in the following code:
```cs
builder.Services
  .Configure<NorthwindOptions>(builder.Configuration.GetSection("Northwind"))
  .Validate(settings => settings.PagerSize > 0,
  "PagerSize must be greater than zero.");
```

But to use the `Validate` extension method, you must call the `AddOptions<T>` method, as shown in the following code:
```cs
builder.Services
  .AddOptions<NorthwindOptions>("Northwind")
  .Validate(settings => settings.PagerSize > 0,
  "PagerSize must be greater than zero.");
```

# Page 307 - Adding Aspire to an existing solution

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 9, 2025](https://github.com/markjprice/web-dev-net9/issues/23).

In Step 11, I wrote that I had highlighted the code but the highlight is missing. In the next edition, I will highlight the following code statement:
```cs
IResourceBuilder<ContainerResource> sqlServer = builder
  .AddContainer(name: "azuresqledge",
  image: "mcr.microsoft.com/azure-sql-edge")
  .WithLifetime(ContainerLifetime.Persistent);
```

And the following additional method call after adding the project: `.WaitFor(sqlServer)`.

# Page 308 - Adding Aspire to an existing solution

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 9, 2025](https://github.com/markjprice/web-dev-net9/issues/24).

In Step 14, the output shown is from a different project solution. You can tell because: (1) the version of Aspire is 8.0, (2) the host directory is the Microsoft eShop sample web project, and (3) the port number is different. 

In the next edition, I will replace this output with the correct output for the `MatureWeb` solution.

# Page 337 - Configuring the customer repository and Web API controller

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/25).

In Step 9, the `RetrieveAsync` method should have the `default` value passed to it, but instead I accidently put that in the `GetCustomer` method declaration, as shown in the following code: 
```cs
public async Task<IActionResult> GetCustomer(string id, default)
{
  Customer? c = await _repo.RetrieveAsync(id);
```

It should be as shown in the following code:
```cs
public async Task<IActionResult> GetCustomer(string id)
{
  Customer? c = await _repo.RetrieveAsync(id, default);
```

The code was already correct in the GitHub respository:
https://github.com/markjprice/web-dev-net9/blob/main/code/MatureWeb/Northwind.WebApi/Controllers/CustomersController.cs#L47

# Page 399 - Creating an HTTP file for making requests

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/27).

In Step 4, in *Table 10.2*, the last row has a column value of `products(2)` for the **Relative request**. It should be `products(77)` because the **Response** column value is product 77.

# Page 411 - Calling services in the Northwind MVC website

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 11, 2025](https://github.com/markjprice/web-dev-net9/issues/28).

In Step 1, I wrote, "add a navigation menu item to go to a CORS controller with a JavaScript action method". 

I should have written, "add a navigation menu item to go to a `ODataClient` controller with an `Index` action method".

# Page 460 - Mocking with NSubstitute example

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 13, 2025](https://github.com/markjprice/web-dev-net9/issues/31).

In Step 11, I wrote, "In the `BusinessLogicUnitTests` project, add a package reference for `NSubstitute`, as shown in the following markup:
```xml
<PackageReference Include="NSubstitute" Version="5.1.0" />
```

But we are using CPM, so you should not specify the version number, as shown in the following markup:
```xml
<PackageReference Include="NSubstitute" />
```

# Page 485 - Creating and initializing a new Umbraco project

> Thanks to [P9avel](https://github.com/P9avel) for raising [this issue on January 14, 2025](https://github.com/markjprice/web-dev-net9/issues/32).

In the note box at the end of this section, I wrote, "The relative path to the Umbraco backoffice for your website is `\umbraco`. So, the absolute link to the website will be `https:\\localhost:5131\` and the absolute link to the website will be `https:\\localhost:5131\umbraco`."

I mistakenly repeated, "the absolute link to the website", so I should have written, "The relative path to the Umbraco backoffice for your website is `\umbraco`. So, the absolute link to the website will be `https:\\localhost:5131\` and the absolute link to the Umbraco backoffice will be `https:\\localhost:5131\umbraco`."

And I had previously written a note box before Step 17, "The Umbraco backoffice is accessed through the `/umbraco` relative path, so for our
project, it is at the following link: https://localhost:5131/umbraco."

In the next edition, I will remove one of these note boxes. I will also add a heading between steps 7 and 8 to break up this long task a bit more. 
