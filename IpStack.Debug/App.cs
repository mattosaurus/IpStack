using IpStack.Services;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace IpStack.Debug
{
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
            _logger.LogInformation($"Retrieved IP address details: {JsonSerializer.Serialize(ipAddressDetails)}");
            var ipAddressDetails2 = await _IpStackService.GetIpAddressDetailsAsync(ipAddress: "127.0.0.1");
            _logger.LogInformation($"Retrieved IP address details: {JsonSerializer.Serialize(ipAddressDetails2)}");
        }
    }
}
