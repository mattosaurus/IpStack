# IpStack
A .NET Core client wrapper for accessing the ipstack API.

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
# Dependencies
In order to use the ipstack API you'll need an [API key](https://ipstack.com/product), a free usage tier is available that allows up to 10,000 API calls a month.

# Usage
The below code can be used in a .NET Core project.

```C#
    public class Program
    {
        public static void Main(string[] args)
        {
            IpStackClient client = new IpStackClient("<YOUR_API_KEY>");

            // Get single IP address with defaults
            IpAddressDetails singleDetails = client.GetIpAddressDetails("134.201.250.155");

            // Get multiple IP addresses with defaults
            IpAddressDetails bulkDetails = client.GetIpAddressDetails(new List<string>() { "134.201.250.155", "72.229.28.185", "110.174.165.78" });

            // Upgrade client to https
            client = new IpStackAPI("<YOUR_API_KEY>", true);

            // Get requestors address details
            IpAddressDetails requestorDetails = client.GetRequesterIpAddressDetails();
        }
    }
```
