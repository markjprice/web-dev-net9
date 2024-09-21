**Setting up your development environment**

- [Downloading and installing Visual Studio](#downloading-and-installing-visual-studio)
- [Downloading and installing VS Code](#downloading-and-installing-vs-code)
  - [Installing other extensions](#installing-other-extensions)
  - [Understanding Code versions](#understanding-code-versions)
  - [Keyboard shortcuts for VS Code](#keyboard-shortcuts-for-vs-code)

Before you start programming, you'll need a code editor for C#, either from Microsoft or a third-party. 

Microsoft has a family of code editors and **Integrated Development Environments (IDEs)**, which include:
- Visual Studio for Windows
- VS Code for Windows, Mac, or Linux
- VS Code for the Web or GitHub Codespaces

Third parties have created their own C# code editors, for example, JetBrains has the cross-platform Rider, which is available for Windows, Mac, or Linux but does have a license cost. Rider is popular with more experienced .NET developers.

> **Warning!** Although JetBrains is a fantastic company with great products, both Rider and the ReSharper extension for Visual Studio are software, and all software have bugs and quirky behavior. For example, they might show errors like `Cannot resolve symbol` in your Razor Pages, Razor views, and Blazor components. Yet you can build and run those files because there is no actual problem. If you have installed the Unity Support plugin, then it will complain about boxing operations (which are a genuine problem for Unity game developers), but in projects that are not Unity, hence the warning does not apply.

Most readers use Visual Studio, which is a large and complex tool that can do many things. But Visual Studio likes to provide its own mechanism to do as much as possible, and a .NET developer who uses it can easily think that Visual Studio is the only way to complete a .NET-related task like modifying project configuration or editing a code file. 

Always try to remember that Visual Studio and all the other code editors are just a tool that does work for you that you could do manually. They just show you a view above what is really happening in the files you're working on, like the project file and all the C# code files. 

# Downloading and installing Visual Studio 

If you do not have a Windows computer, then you can skip this section and continue to the next section where you will download and install VS Code on macOS or Linux.

Since October 2014, Microsoft has made a professional-quality edition of Visual Studio available to students, open-source contributors, and individuals for free. It is called **Community Edition**. Any of the editions are suitable for this book. If you have not already installed it, let's do so now:

1.	Download the latest version of Visual Studio  from the following link: https://visualstudio.microsoft.com/downloads/.

> **Visual Studio vNext**: At the time of writing, Visual Studio is version 17.12 and branded as Visual Studio 2022. I expect the next major version of Visual Studio to be version 18.0 and be branded as Visual Studio 2025. It is likely to be released in the first half of 2025, either February or May during the Build conference. Visual Studio 2025 will have mostly the same features as the 2022 edition although the user interface might move things around a bit.

2.	Run the installer to start the installation.
3.	On the **Workloads** tab, select the following:
    - **ASP.NET and web development**.
    - **.NET desktop development** (because this includes console apps).
    - **Desktop development with C++** with all default components (because this enables publishing console apps and web services that start faster and have smaller memory footprints).
4.	Click **Install** and wait for the installer to acquire the selected software and install it.
5.	When the installation is complete, click **Launch**.
6.	The first time that you run Visual Studio, you will be prompted to sign in. If you have a Microsoft account, you can use that account. If you don't, then register for a new one at the following link: https://signup.live.com/.
7.	The first time that you run Visual Studio, you will be prompted to configure your environment. For **Development Settings**, choose **Visual C#**. For the color theme, I chose **Blue**, but you can choose whatever tickles your fancy.
8.	If you want to customize your keyboard shortcuts, navigate to **Tools** | **Options…**, and then select the **Keyboard** section.

# Downloading and installing VS Code

Even if you plan to only use Visual Studio for development, I recommend that you download and install VS Code and try the coding tasks in this chapter using it, and then decide if you want to stick with just using Visual Studio for the rest of the book.

Let's now download and install VS Code, the .NET SDK, and the C# Dev Kit extension:
1.	Download and install either the Stable build or the Insiders edition of VS Code from the following link: https://code.visualstudio.com/.

> **More Information**: If you need more help installing VS Code, you can read the official setup guide at the following link: https://code.visualstudio.com/docs/setup/setup-overview.

2.	Download and install the .NET SDK for version 9.0 and version 8.0 from the following link: https://www.microsoft.com/net/download.

> In real life, you are extremely unlikely to only have one .NET SDK version installed on your computer. To learn how to control which .NET SDK version is used to build a project, we need multiple versions installed. .NET 8 and .NET 9 are the only supported versions at the time of publishing in November 2024. You can safely install multiple SDKs side by side. The most recent SDK will be used to build your projects.

3.	To install the **C# Dev Kit** extension using a user interface, you must first launch the VS Code application.
4.	In VS Code, click the **Extensions** icon or navigate to **View** | **Extensions**.
5.	C# Dev Kit is one of the most popular extensions available, so you should see it at the top of the list, or you can enter `C#` in the search box.

> **C# Dev Kit** has a dependency on the **C#** extension version 2.0 or later, so you do not have to install the C# extension separately. Note that C# extension version 2.0 or later no longer uses OmniSharp since it has a new **Language Service Protocol (LSP)** host. C# Dev Kit also has dependencies on the **.NET Install Tool** and **IntelliCode for C# Dev Kit** extensions so they will be installed too.

6.	Click **Install** and wait for supporting packages to download and install.

> **Good Practice**: Be sure to read the license agreement for C# Dev Kit. It has a more restrictive license than the C# extension: https://aka.ms/vs/csdevkit/license. 

## Installing other extensions

In later chapters of this book, you will use more VS Code extensions. If you want to install them now, all the extensions that we will use are shown in *Table 1.1*:

Extension name and identifier|Description
---|---
C# Dev Kit<br/>`ms-dotnettools.csdevkit`|Official C# extension from Microsoft. Manage your code with a solution explorer and test your code with integrated unit test discovery and execution. Includes the C# and IntelliCode for C# Dev Kit extensions.
C#<br/>`ms-dotnettools.csharp`|C# editing support, including syntax highlighting, IntelliSense, Go To Definition, Find All References, debugging support for .NET, and support for csproj projects on Windows, macOS, and Linux.
IntelliCode for C# Dev Kit<br/>`ms-dotnettools.vscodeintellicode-csharp`|Provides AI-assisted development features for Python, TypeScript/JavaScript, C#, and Java developers.
SQL Server (mssql)<br/>`ms-mssql.mssql`|For developing SQL Server, Azure SQL Database, and SQL Data Warehouse everywhere with a rich set of functionalities.
MSBuild project tools<br/>tintoy.msbuild-project-tools|Provides IntelliSense for MSBuild project files, including autocomplete for <PackageReference> elements.
Markdown All in One<br/>`yzhang.markdown-all-in-one`|All you need for Markdown (keyboard shortcuts, table of contents, auto preview and more).
REST Client<br/>`humao.rest-client`|Send an HTTP request and view the response directly in VS Code.

*Table 1.1: VS Code extensions for .NET development*

You can install a VS Code extension at the command prompt or terminal, as shown in *Table 1.2*:

Command|Description
---|---
`code --list-extensions`|List installed extensions.
`code --install-extension <extension-id>`|Install the specified extension.
`code --uninstall-extension <extension-id>`|Uninstall the specified extension.

*Table 1.2: Managing VS Code extensions at the command prompt*

For example, to install the C# Dev Kit extension, enter the following at the command prompt:
```
code --install-extension ms-dotnettools.csdevkit
```

I have created PowerShell scripts to install and uninstall the VS Code extensions in the preceding table. You can find them at the following link: https://github.com/markjprice/web-dev-net9/tree/main/scripts/extension-scripts/. 

PowerShell scripts are cross-platform, as you can read about at the following link: https://learn.microsoft.com/en-us/powershell/scripting/overview.

## Understanding Code versions

Microsoft releases a new feature version of VS Code (almost) every month and bug-fix versions more frequently. For example:
- Version 1.91.0, June 2024 feature release
- Version 1.91.1, June 2024 bug fix release

The version used in this book is 1.93.0, August 2024 feature release, but the version of VS Code is less important than the version of the C# Dev Kit or C# extension that you install. I recommend C# extension v2.34.12 or later and C# Dev Kit v1.7.27 or later.

While the C# extension is not required, it provides IntelliSense as you type, code navigation, and debugging features, so it's something that's very handy to install and keep updated to support the latest C# language features.

## Keyboard shortcuts for VS Code

If you want to customize your keyboard shortcuts for VS Code, then you can, as shown at the following link: https://code.visualstudio.com/docs/getstarted/keybindings.

I recommend that you download a PDF of Code keyboard shortcuts for your operating system from the following list:
- Windows: https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf
- macOS: https://code.visualstudio.com/shortcuts/keyboard-shortcuts-macos.pdf
- Linux: https://code.visualstudio.com/shortcuts/keyboard-shortcuts-linux.pdf
