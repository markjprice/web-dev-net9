**Startup.cs in ASP.NET Core 5 and earlier**

- [Code examples for ASP.NET Core 5](#code-examples-for-aspnet-core-5)
- [Changes in ASP.NET Core 6 and later](#changes-in-aspnet-core-6-and-later)
- [Reasons for the Change](#reasons-for-the-change)
- [Pros and Cons of Each Approach](#pros-and-cons-of-each-approach)
  - [ASP.NET Core 5 and earlier (Separate Startup Class)](#aspnet-core-5-and-earlier-separate-startup-class)
  - [ASP.NET Core 6 and later (Minimal Hosting Model)](#aspnet-core-6-and-later-minimal-hosting-model)
- [Conclusion](#conclusion)


In ASP.NET Core 5 and earlier, the application configuration process is divided between two files:

- `Program.cs`: This file is responsible for creating and configuring the web host.
- `Startup.cs`: This file contains the application-specific logic, such as configuring services and middleware.

# Code examples for ASP.NET Core 5

`Program.cs`:
```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
```
In this file, the `Host.CreateDefaultBuilder` method initializes the host, sets up defaults like configuration and logging, and calls the `UseStartup<Startup>()` method to link to the `Startup` class.

`Startup.cs`:
```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Register services here
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}
```
In the `Startup.cs` file:
- `ConfigureServices` method is where dependency injection (DI) services are registered.
- `Configure` method defines the middleware pipeline for handling HTTP requests.

# Changes in ASP.NET Core 6 and later

Starting with ASP.NET Core 6, the ASP.NET Core team took advantage of the .NET top-level program feature to introduce the Minimal Hosting Model, which eliminates the need for a separate `Startup` class. The configuration is now centralized in `Program.cs`:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
```

The `WebApplication` class consolidates both host creation and middleware setup, reducing the overall complexity.

# Reasons for the Change

1. **Simplification**: By combining the `Program` and `Startup` classes, the configuration becomes more concise and easier for newcomers to follow.
Eliminates boilerplate code and reduces ceremony.
2. **Flexibility**: Developers can define services, middleware, and routing inline without needing to switch contexts between files.
3. **Performance**: The new model allows the ASP.NET Core team to optimize the hosting and startup process, as it no longer has to split responsibilities across two classes.
4. **Alignment with Minimal APIs**: The minimal hosting model is consistent with the new Minimal APIs introduced in ASP.NET Core 6, providing a streamlined experience.

# Pros and Cons of Each Approach

## ASP.NET Core 5 and earlier (Separate Startup Class)

Pros:
- Clear separation of concerns between host setup in `Program.cs` vs. application setup in `Startup.cs`.
- Familiar and structured approach for developers coming from older versions.

Cons:
- More boilerplate and ceremony.
- Configuration split across multiple files can be harder to navigate for small projects.

## ASP.NET Core 6 and later (Minimal Hosting Model)

Pros:
- Simpler and more concise for most use cases.
- Improved performance with fewer layers of abstraction.
- Easier to understand and use, especially for new developers.

Cons:
- Mixing host configuration and application logic can make `Program.cs` cluttered in larger projects.
- Less clear separation of concerns, which may confuse developers used to the older model.
- Projects upgrading from ASP.NET Core 5 and earlier to 6 and later need to adapt to the new model, which may involve reworking existing patterns.

# Conclusion

The change from the `Startup` class to the Minimal Hosting Model is driven by a desire for simplicity and alignment with modern API design trends. 

While the ASP.NET Core 5 model is still supported in ASP.NET Core 6 and later for backward compatibility, the newer model is preferred for its streamlined approach. Choosing between the two depends on project size, team familiarity, and whether you're starting fresh or upgrading.
