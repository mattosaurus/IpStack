# IpStack
.NET wrapper to query the IpStack API for IP address data.

# Installation
To use IpStack in your C# project, you can either download the IpStack C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package IpStack
```
Once you have the IpStack libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using IpStack;
using IpStack.Models;
```

# Usage
The client is intended to be used via Dependency Injection and added using the `AddIpStack` extension.

```C#
// Add API client
serviceCollection.AddIpStack(
    "<API KEY>"
    );
```

The injected client can then be used as expected.

```C#
public class App
{
    private readonly ILogger<App> _logger;
    private readonly IIpStackService _IpStackService;

    public App(ILoggerFactory loggerFactory, IIpStackService IpStackService)
    {
        _logger = loggerFactory.CreateLogger<App>();
        _IpStackService = IpStackService;
    }

    public async Task RunAsync()
    {
        var ipAddressDetails = await _IpStackService.GetIpAddressDetailsAsync();
    }
}
```

See the [debug project](https://github.com/mattosaurus/IpStack/tree/master/IpStack.Debug) for an example.
