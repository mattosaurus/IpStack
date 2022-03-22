using IpStack.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
