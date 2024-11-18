using Microsoft.AspNetCore.Mvc.Formatters; // To use IOutputFormatter.
using Northwind.EntityModels; // To use AddNorthwindContext method.
using Northwind.Repositories; // To use ICustomerRepository.
using Microsoft.Extensions.Caching.Hybrid; // To use HybridCacheEntryOptions.
using Microsoft.AspNetCore.HttpLogging; // To use HttpLoggingFields.
using System.Security.Claims; // To use ClaimsPrincipal.

public class Program
{
  public static void Main(string[] args)
  {
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddAuthorization();
    builder.Services.AddAuthentication(defaultScheme: "Bearer")
      .AddJwtBearer();

    builder.Services.AddCors(options =>
    {
      options.AddPolicy(name: "Northwind.Mvc.Policy",
        policy =>
        {
          policy.WithOrigins("https://localhost:5021");
        });
    });

    builder.Services.AddNorthwindContext();

    builder.Services.AddControllers(options =>
    {
      WriteLine("Default output formatters:");
      foreach (IOutputFormatter formatter in options.OutputFormatters)
      {
        OutputFormatter? mediaFormatter = formatter as OutputFormatter;
        if (mediaFormatter is null)
        {
          WriteLine($"  {formatter.GetType().Name}");
        }
        else // OutputFormatter class has SupportedMediaTypes.
        {
          WriteLine("  {0}, Media types: {1}",
            arg0: mediaFormatter.GetType().Name,
            arg1: string.Join(", ",
              mediaFormatter.SupportedMediaTypes));
        }
      }
    })
    .AddXmlDataContractSerializerFormatters()
    .AddXmlSerializerFormatters();

    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();

    builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

#pragma warning disable EXTEXP0018 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
    builder.Services.AddHybridCache(options =>
    {
      options.DefaultEntryOptions = new HybridCacheEntryOptions
      {
        Expiration = TimeSpan.FromSeconds(60),
        LocalCacheExpiration = TimeSpan.FromSeconds(30)
      };
    });
#pragma warning restore EXTEXP0018 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

    builder.Services.AddResponseCaching();

    builder.Services.AddHttpLogging(options =>
    {
      // Add the Origin header so it will not be redacted.
      options.RequestHeaders.Add("Origin");

      options.LoggingFields = HttpLoggingFields.All;
      options.RequestBodyLogLimit = 4096; // Default is 32k.
      options.ResponseBodyLogLimit = 4096; // Default is 32k.
    });

    var app = builder.Build();

    app.UseCors(policyName: "Northwind.Mvc.Policy");

    app.UseHttpLogging();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
      app.MapOpenApi();
    }

    app.UseHttpsRedirection();

    app.UseResponseCaching();

    app.UseAuthorization();

    app.MapControllers();

    app.MapGet("/secret", (ClaimsPrincipal user) =>
      string.Format("Welcome, {0}. The secret ingredient is love.",
        user.Identity?.Name ?? "secure user"))
      .RequireAuthorization();

    string? tunnelUrl = Environment.GetEnvironmentVariable("VS_TUNNEL_URL");
    if (tunnelUrl is not null)
    {
      WriteLine($"Tunnel URL: {tunnelUrl}");
    }

    app.Run();
  }
}
