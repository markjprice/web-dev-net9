**Improvements** (1 item)

If you have suggestions for improvements, then please [raise an issue in this repository](https://github.com/markjprice/web-dev-net9/issues) or email me at markjprice (at) gmail.com.

- [Page x - Installing Umbraco CMS](#page-x---installing-umbraco-cms)


# Page x - Installing Umbraco CMS

In Step 1, I wrote the command to install project templates for Umbraco CMS version 14.2, as shown in the following command:
```
dotnet new install Umbraco.Templates::14.2.0
```

This installs three project templates, as shown in the following output:
```
Templates            Short Name          Language
-------------------------------------------------
Umbraco Project      umbraco             [C#]
Umbraco Package RCL  umbracopackage-rcl  [C#]
Umbraco Package      umbracopackage      [C#]
```

If you do not explicitly specify the version, then the latest version will be installed. At the time of writing in December 2024, that is version 15.0.0. This installs three project templates, as shown in the following output:
```
Templates               Short Name         Language
---------------------------------------------------
Umbraco Docker Compose  umbraco-compose            
Umbraco Extension       umbraco-extension  [C#]    
Umbraco Project         umbraco            [C#]    
```

Since we are only using the **Umbraco Project** / `umbraco` project template, the other project templates don't matter.

I recommend that you use version 14.2.0 as I did in the book. If you choose to install a later version like 15.0.0 then be prepared for changes to behavior.

> **Warning!** You might need to restart Visual Studio to see newly added project templates.

> **Note**: the next edition will use Umbraco CMS version 17.0.0 which will be an LTS release that targets .NET 10.
