# headway

[![Build status](https://ci.appveyor.com/api/projects/status/xg606j7pr1ib54db?svg=true)](https://ci.appveyor.com/project/grantcolley/headway)

##### Technologies
###### .NET 5.0, Blazor WebAssembly, Blazor Server, IdentityServer4, ASP.NET Core Web API
\
**Headway** is based on the [blazor-solution-setup](https://github.com/grantcolley/blazor-solution-setup) project, providing a solution for a *Blazor* app supporting both hosting models, *Blazor WebAssembly* and *Blazor Server*, a *WebApi* for accessing data and an *Identity Provider* for authentication:
 * **Blazor WebAssembly** - running client-side on the browser.
 * **Blazor Server** - where updates and event handling are run on the server and managed over a SignalR connection. 
 * **IdentityServer4** - an OpenID Connect and OAuth 2.0 framework for authentication. 
 * **ASP.NET Core Web API** - for accessing data repositories by authenticated users.
 * **Razor Class Library** - for shared *Razor* components.
 * **Class Library** - for shared classes and interfaces.
 * **Class Library** - a services library for calling the *WebApi*.
 * **Class Library** - a repository library for access to data behind the *WebApi*.

![Alt text](/readme-images/headway-architecture.png?raw=true "Headway Architecture") 

#### Table of Contents
* [Getting Started](#getting-started)
* [Authentication and Authorization](#authentication-and-authorization)
* [Navigation Menu](#role-based-navigation-menu)
* [Administration](#administration)
* [Configuration](#configuration)
 * [Notes](#notes)
    * [Adding font awesome](#adding-font-awesome)
    * [EntityFramework Core Migrations](#entityframework-core-migrations)

## Getting Started

## Authentication and Authorization

## Navigation Menu

## Administration

## Configuration

## Notes

### Adding Font Awesome
 * Right-click the `wwwroot\css` folder in the Blazor project and click `Add` then `Client-Side Library...`. Search for `font-awesome` and install it.
 * For a Blazor Server app add `@import url('font-awesome/css/all.min.css');` at the top of [site.css](https://github.com/grantcolley/headway/tree/main/src/Headway.BlazorServerApp/wwwroot/css). For a Blazor WebAssembly app add it to [app.css](https://github.com/grantcolley/headway/blob/main/src/Headway.BlazorWebassemblyApp/wwwroot/css/app.css).
  
### EntityFramework Core Migrations
ApplicationDbContext.cs is in the Headway.Repository library. The migrations are output to either Headway.MigrationsSqlite or Headway.MigrationsSqlServer, depending on which connection string is used in Headway.WebApi's appsettings.json. to make this work, the following class must be created in Headway.Repository to specify which project the migration output should target.

```C#
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration
                = new ConfigurationBuilder().SetBasePath(
                    Directory.GetCurrentDirectory())
                       .AddJsonFile(@Directory.GetCurrentDirectory() + "/../Headway.WebApi/appsettings.json")
                       .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            if(connectionString.Contains("Headway.db"))
            {
                builder.UseSqlite(connectionString, x => x.MigrationsAssembly("Headway.MigrationsSqlite"));
            }
            else
            {
                builder.UseSqlServer(connectionString, x => x.MigrationsAssembly("Headway.MigrationsSqlServer"));
            }

            return new ApplicationDbContext(builder.Options);
        }
    }
```

Headway.WebApi's Startup.cs should also specify which project the migration output should target.

```C#
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                if (Configuration.GetConnectionString("DefaultConnection").Contains("Headway.db"))
                {
                    options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("Headway.MigrationsSqlite"));
                }
                else
                {
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsAssembly("Headway.MigrationsSqlServer"));
                }
            });
```
In the Developer PowerShell navigate to the Headway.WebApi project and run the following command to add a migration:
` dotnet ef migrations add UpdateHeadway --project ..\\Utilities\\Headway.MigrationsSqlServer`

And the following command will update the database
`dotnet ef database update --project ..\\Utilities\\Headway.MigrationsSqlServer`

Supporting notes:
 * Create migrations from the repository library and output them to a separate migrations project 
 * https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
 * https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/projects?tabs=dotnet-core-cli
  
