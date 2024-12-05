**Command-Lines**

To make it easier to enter commands at the prompt, this page lists all commands as a single line that can be copied and pasted.

> Note: Page numbers will be updated once the final print files are made available to me in November 2023.

- [Chapter 1 Introducing Web Development with Controllers](#chapter-1-introducing-web-development-with-controllers)
- [Chapter 2 Building Websites Using ASP.NET Core MVC](#chapter-2-building-websites-using-aspnet-core-mvc)
- [Chapter 3 Model Binding, Validation, and Data Using EF Core](#chapter-3-model-binding-validation-and-data-using-ef-core)
- [Chapter 4 Building and Localizing Web User Interfaces](#chapter-4-building-and-localizing-web-user-interfaces)
- [Chapter 5 Authentication and Authorization](#chapter-5-authentication-and-authorization)
- [Chapter 6 Performance Optimization Using Caching](#chapter-6-performance-optimization-using-caching)
- [Chapter 7 Web User Interface Testing Using Playwright](#chapter-7-web-user-interface-testing-using-playwright)
- [Chapter 8 Configuring and Containerizing ASP.NET Core Projects](#chapter-8-configuring-and-containerizing-aspnet-core-projects)
- [Chapter 9 Building Web Services Using ASP.NET Core Web API](#chapter-9-building-web-services-using-aspnet-core-web-api)
- [Chapter 10 Building Web Services Using ASP.NET Core OData](#chapter-10-building-web-services-using-aspnet-core-odata)
- [Chapter 11 Building Web Services Using FastEndpoints](#chapter-11-building-web-services-using-fastendpoints)
- [Chapter 12 Web Service Integration Testing](#chapter-12-web-service-integration-testing)
- [Chapter 13 Web Content Management Using Umbraco](#chapter-13-web-content-management-using-umbraco)
- [Chapter 14 Customizing and Extending Umbraco](#chapter-14-customizing-and-extending-umbraco)

# Chapter 1 Introducing Web Development with Controllers

To clone the book's GitHub repository:
```shell
git clone https://github.com/markjprice/web-dev-net9.git
```

To pull down the latest container image for Azure SQL Edge:
```shell
docker pull mcr.microsoft.com/azure-sql-edge:latest
```

To run the container image for Azure SQL Edge with a strong password and name the container `azuresqledge`:
```shell
docker run --cap-add SYS_PTRACE -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=s3cret-Ninja' -p 1433:1433 --name azuresqledge -d mcr.microsoft.com/azure-sql-edge
```

To ask Docker to list all containers, both running and stopped:
```shell
docker ps -a
```

To stop the `azuresqledge` container:
```shell
docker stop azuresqledge
```

To remove the `azuresqledge` container:
```shell
docker rm azuresqledge
```

To remove the azure-sql-edge image to release its disk space:
```shell
docker rmi mcr.microsoft.com/azure-sql-edge
```

To check if you have already installed `dotnet-ef` as a global tool:
```shell
dotnet tool list --global
```

To update the tool:
```shell
dotnet tool update --global dotnet-ef
```

To install the latest version:
```shell
dotnet tool install --global dotnet-ef
```

To explicitly set a version, for example, to use a preview, add the `--version` switch:
```shell
dotnet tool update --global dotnet-ef --version 10.0-*
```

To remove the tool:
```shell
dotnet tool uninstall --global dotnet-ef
```

> **Warning!** Make sure that the SQL Edge container is running because you are about to connect to the server and its Northwind database.

In the `Northwind.EntityModels` project folder (the folder that contains the `.csproj` project file), generate entity class models for all tables:
```shell
dotnet ef dbcontext scaffold "Data Source=tcp:127.0.0.1,1433;Initial Catalog=Northwind;User Id=sa;Password=s3cret-Ninja;TrustServerCertificate=true;" Microsoft.EntityFrameworkCore.SqlServer --namespace Northwind.EntityModels --data-annotations
```

To set the two environment variables at the command prompt or terminal.

On Windows:
```shell
setx MY_SQL_USR <your_user_name>
setx MY_SQL_PWD <your_password>
```

On macOS and Linux:
```shell
export MY_SQL_USR=<your_user_name>
export MY_SQL_PWD=<your_password>
```

# Chapter 2 Building Websites Using ASP.NET Core MVC

# Chapter 3 Model Binding, Validation, and Data Using EF Core

# Chapter 4 Building and Localizing Web User Interfaces

# Chapter 5 Authentication and Authorization

# Chapter 6 Performance Optimization Using Caching

# Chapter 7 Web User Interface Testing Using Playwright

# Chapter 8 Configuring and Containerizing ASP.NET Core Projects

# Chapter 9 Building Web Services Using ASP.NET Core Web API

# Chapter 10 Building Web Services Using ASP.NET Core OData

# Chapter 11 Building Web Services Using FastEndpoints

# Chapter 12 Web Service Integration Testing

# Chapter 13 Web Content Management Using Umbraco

# Chapter 14 Customizing and Extending Umbraco

