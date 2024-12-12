**Command-Lines**

To make it easier to enter commands at the prompt, this page lists all commands as a single line that can be copied and pasted.

- [Chapter 1 Introducing Web Development with Controllers](#chapter-1-introducing-web-development-with-controllers)
- [Chapter 2 Building Websites Using ASP.NET Core MVC](#chapter-2-building-websites-using-aspnet-core-mvc)
- [Chapter 7 Web User Interface Testing Using Playwright](#chapter-7-web-user-interface-testing-using-playwright)
- [Chapter 8 Configuring and Containerizing ASP.NET Core Projects](#chapter-8-configuring-and-containerizing-aspnet-core-projects)
- [Chapter 9 Building Web Services Using ASP.NET Core Web API](#chapter-9-building-web-services-using-aspnet-core-web-api)
- [Chapter 10 Building Web Services Using ASP.NET Core OData](#chapter-10-building-web-services-using-aspnet-core-odata)
- [Chapter 11 Building Web Services Using FastEndpoints](#chapter-11-building-web-services-using-fastendpoints)
- [Chapter 12 Web Service Integration Testing](#chapter-12-web-service-integration-testing)
- [Chapter 13 Web Content Management Using Umbraco](#chapter-13-web-content-management-using-umbraco)

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

Use the help switch to see other options for the ASP.NET CoreMVC project template:
```shell
dotnet new mvc --help
```

Run database migrations:
```shell
dotnet ef database update
```

# Chapter 7 Web User Interface Testing Using Playwright

If you’re running tests via the command line, you can specify the run settings :
```shell
dotnet test --settings Playwright.runsettings
```

When running a test project, you can then specify the browser and channel:
```shell
dotnet test -- Playwright.BrowserName=chromium Playwright.LaunchOptions.Channel=msedge
```

To add a new **xUnit Test Project [C#]** / `xunit` project named `Northwind.WebUITests` to the `MatureWeb` solution. In the `MatureWeb` folder, enter the following commands:
```shell
dotnet new xunit -o Northwind.WebUITests
dotnet sln add Northwind.WebUITests
```

Navigate to `Northwind.WebUITests\bin\Debug\net9.0` and, at the command prompt or terminal, install browsers for Playwright to automate:
```shell
pwsh playwright.ps1 install
```

Start the **Playwright Inspector** code generator for the MVC website:
```shell
pwsh bin/Debug/net9.0/playwright.ps1 codegen https://localhost:5021/
```

Start the **Playwright Inspector** code generator with emulation options like setting a view port size:
```shell
pwsh bin/Debug/net9.0/playwright.ps1 codegen --viewport-size=800,600 https://localhost:5021/
```

Start the **Playwright Inspector** code generator to emulate a device:
```shell
pwsh bin/Debug/net9.0/playwright.ps1 codegen --device="iPhone 13" https://localhost:5021/
```

To remove the special browsers (chromium, firefox, and webkit) of the current Playwright installation:
```shell
pwsh bin/Debug/net9.0/playwright.ps1 uninstall
```

To remove browsers of other Playwright installations as well:
```shell
pwsh bin/Debug/net9.0/playwright.ps1 uninstall --all
```

# Chapter 8 Configuring and Containerizing ASP.NET Core Projects

To list the Docker images:
```shell
docker images
```

To download the Docker image for the sample ASP.NET Core project image and run it with external port `8000` mapped to internal port `8080`, interactive TTY mode (`-it`), and remove it when the container stops (`--rm`):
```shell
docker run --rm -it -p 8000:8080 mcr.microsoft.com/dotnet/samples:aspnetapp
```

# Chapter 9 Building Web Services Using ASP.NET Core Web API

In the `MatureWeb` directory:
```shell
dotnet new webapi --use-controllers -o Northwind.WebApi
dotnet sln add Northwind.WebApi
```

To create a local JWT:
```shell
dotnet user-jwts create
```

Result will have an ID that you can use to identify the JWT:
```
New JWT saved with ID 'f2d14dfa'.
```

To print all the information for the ID that was assigned:
```shell
dotnet user-jwts print f2d14dfa --show-all
```

# Chapter 10 Building Web Services Using ASP.NET Core OData

In the `MatureWeb` directory:
```shell
dotnet new webapi --use-controllers -o Northwind.OData
dotnet sln add Northwind.OData
```

# Chapter 11 Building Web Services Using FastEndpoints

In the `MatureWeb` directory:
```shell
dotnet new web -o Northwind.FastEndpoints
dotnet sln add Northwind.FastEndpoints
```

# Chapter 12 Web Service Integration Testing

Whenever you make changes to your models that affect the database schema, you should create a new migration:
```shell
dotnet ef migrations add <MigrationName>
```

To run any outstanding migrations:
```shell
dotnet ef database update
```

To revert to a specified migration point:
```shell
dotnet ef database update <MigrationName>
```

To revert all migrations so that the database returns to its original state:
```shell
dotnet ef database update 0
```

To add a new xUnit project to the `MatureWeb` solution:
```shell
dotnet new xunit -o BusinessLogicUnitTests
dotnet sln add BusinessLogicUnitTests
```
To install the dev tunnel CLI...

On Windows:
```shell
winget install Microsoft.devtunnel
```

On macOS using Homebrew:
```shell
brew install --cask devtunnel
```

On Linux using `curl`:
```shell
curl -sL https://aka.ms/DevTunnelCliInstall | bash
```

To log in with a Microsoft Entra ID, Microsoft, or GitHub account:
```shell
devtunnel user login
```

Start hosting a simple service on port 8080 that just echoes any HTTP requests to it:
```shell
devtunnel echo http -p 8080
```

In another command prompt or terminal window, start hosting a dev tunnel for port 8080:
```shell
devtunnel host -p 8080
```

# Chapter 13 Web Content Management Using Umbraco

To install the Umbraco version 14.2 project templates:
```shell
dotnet new install Umbraco.Templates::14.2.0
```

To confirm that the project templates are installed:
```shell
dotnet new list umbraco
```
