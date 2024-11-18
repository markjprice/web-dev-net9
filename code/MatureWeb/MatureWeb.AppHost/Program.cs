var builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<ContainerResource> sqlServer = builder
  .AddContainer(name: "azuresqledge", 
    image: "mcr.microsoft.com/azure-sql-edge")
  .WithLifetime(ContainerLifetime.Persistent);

builder.AddProject<Projects.Northwind_Mvc>("northwind-mvc")
  .WaitFor(sqlServer);

builder.Build().Run();
