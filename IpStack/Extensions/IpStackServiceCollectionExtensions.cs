using IpStack.Models;
using IpStack.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IpStack.Extensions
{
    public static class IpStackServiceCollectionExtensions
    {
        public static IServiceCollection AddIpStack(this IServiceCollection collection, Action<IpStackOptions> setupAction)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (setupAction == null) throw new ArgumentNullException(nameof(setupAction));

            // Add Met Office HTTP Client
            collection.AddHttpClient<IIpStackService, IpStackService>(client =>
            {
                client.BaseAddress = new Uri("http://api.ipstack.com/");
            });

            collection.Configure(setupAction);
            return collection;
        }

        public static IServiceCollection AddIpStack(this IServiceCollection collection, string apiKey)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (apiKey == null) throw new ArgumentNullException(nameof(apiKey));

            collection.AddHttpClient<IIpStackService, IpStackService>(client =>
            {
                client.BaseAddress = new Uri("http://api.ipstack.com/");
            });

            collection.AddOptions<IpStackOptions>().Configure(options =>
            {
                options.ApiKey = apiKey;
            });

            return collection;
        }

        public static IServiceCollection AddIpStack(this IServiceCollection collection, IConfigurationSection configuration)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));
            if (configuration == null) throw new ArgumentNullException(nameof(configuration));

            // Add Met Office HTTP Client
            collection.AddHttpClient<IIpStackService, IpStackService>(client =>
            {
                client.BaseAddress = new Uri("http://api.ipstack.com/");
            });

            collection.Configure<IpStackOptions>(configuration);
            return collection;
        }
    }
}
