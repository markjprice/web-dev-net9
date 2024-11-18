using FastEndpoints; // To use AddFastEndpoints and so on.
using Northwind.EntityModels; // To use AddNorthwindContext method.

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.AddNorthwindContext();

var app = builder.Build();

app.MapGet("/", () => """
  Hello FastEndpoints!

  GET /hello?Name=<string>&Age=<int>
  GET /hello/<name>/<age>
  
  GET /customers/
  GET /customers/<country>
  """);

app.MapFastEndpoints();

app.Run();
