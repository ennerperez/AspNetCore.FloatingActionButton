# FloatingActionButton for ASP.NET Core MVC/Razor

[![NuGet](http://img.shields.io/nuget/v/AspNetCore.FloatingActionButton.svg)](https://www.nuget.org/packages/AspNetCore.FloatingActionButton/)

---------------------------------------

See the [changelog](CHANGELOG.md) for changes.

## Table of contents

* [Implementing](#implementing)
* [Quick start](#quick-start)
* [License](#license)

### Implementing

**Add the library to your project**

Add the [NuGet Package](https://www.nuget.org/packages/AspNetCore.FloatingActionButton/). Right click on your project and click 'Manage NuGet Packages...'. Search for 'AspNetCore.FloatingActionButton' and click on install. Once installed the library will be included in your project references. (Or install it through the package manager console: PM> Install-Package AspNetCore.FloatingActionButton).

### Quick start

#### Implementing as Component

On you view:

```csharp
    @using Microsoft.AspNetCore.Mvc.Models
    @await Component.InvokeAsync("FloatingActionButton", Actions)
```

Where `Actions` must be a new instance of `Microsoft.AspNetCore.Mvc.Models.FloatingAction`

#### Implementing as TagHelper


On your view or at `_ViewImports.cshtml`:

```csharp
@using Microsoft.AspNetCore.Mvc.Models
@addTagHelper *, FloatingActionButton
```
On your view:
```html
<FloatingActionButton model="@Actions" ></FloatingActionButton>
```

Where `Actions` must be a new instance of `Microsoft.AspNetCore.Mvc.Models.FloatingAction`

### License

Code released under [The MIT License](LICENSE)
