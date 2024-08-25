using Microsoft.AspNetCore.OData; // To use AddOData.
using Northwind.EntityModels; // To use AddNorthwindContext.

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddNorthwindContext();

builder.Services.AddControllers()
  // Register OData models.
  .AddOData(options => options

    // GET /catalog and /catalog/$metadata
    .AddRouteComponents(routePrefix: "catalog",
      model: GetEdmModelForCatalog())

    // GET /ordersystem and /ordersystem/$metadata
    .AddRouteComponents(routePrefix: "ordersystem",
      model: GetEdmModelForOrderSystem())

    // GET /catalog/v1, /catalog/v2, and so on.
    .AddRouteComponents(routePrefix: "catalog/v{version}",
      model: GetEdmModelForCatalog())

    // Enable query options:
    .Select()       // $select for projection
    .Expand()       // $expand to navigate to related entities
    .Filter()       // $filter
    .OrderBy()      // $orderby
    .SetMaxTop(100) // $top
    .Count()        // $count
  );

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
