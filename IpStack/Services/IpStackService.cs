using IpStack.Models;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace IpStack.Services
{
    public class IpStackService : IIpStackService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<IpStackService> _logger;
        private readonly IpStackOptions _options;

        public IpStackService(HttpClient httpClient, ILoggerFactory loggerFactory, IOptions<IpStackOptions> options)
        {
            _httpClient = httpClient;
            _logger = loggerFactory.CreateLogger<IpStackService>();
            _options = options.Value;
        }

        public async Task<IpAddressDetails> GetIpAddressDetailsAsync(string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"check", new Dictionary<string, string?>()
            {
                ["fields"] = fields,
                ["hostname"] = Helpers.Utilities.BoolToInt(hostname).ToString(),
                ["fielsecurityds"] = Helpers.Utilities.BoolToInt(security).ToString(),
                ["language"] = language,
                ["callback"] = callback,
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<IpAddressDetails>() ?? throw new ArgumentNullException();
        }

        public async Task<IpAddressDetails> GetIpAddressDetailsAsync(string ipAddress, string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"{ipAddress}", new Dictionary<string, string?>()
            {
                ["fields"] = fields,
                ["hostname"] = Helpers.Utilities.BoolToInt(hostname).ToString(),
                ["fielsecurityds"] = Helpers.Utilities.BoolToInt(security).ToString(),
                ["language"] = language,
                ["callback"] = callback,
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<IpAddressDetails>() ?? throw new ArgumentNullException();
        }

        public async Task<IpAddressDetails> GetIpAddressDetailsAsync(IEnumerable<string> ipAddresses, string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null)
        {
            HttpRequestMessage request = CreateHttpRequestMessage(HttpMethod.Get, $"{string.Join(",", ipAddresses)}", new Dictionary<string, string?>()
            {
                ["fields"] = fields,
                ["hostname"] = Helpers.Utilities.BoolToInt(hostname).ToString(),
                ["fielsecurityds"] = Helpers.Utilities.BoolToInt(security).ToString(),
                ["language"] = language,
                ["callback"] = callback,
            });

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            return await response.Content.ReadFromJsonAsync<IpAddressDetails>() ?? throw new ArgumentNullException();
        }

        private HttpRequestMessage CreateHttpRequestMessage(HttpMethod httpMethod, string requestUri)
        {
            Dictionary<string, string> queryParameters = new Dictionary<string, string>()
            {
                ["access_key"] = _options.ApiKey
            };

            string uri = QueryHelpers.AddQueryString(requestUri, queryParameters.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value));

            return new HttpRequestMessage(httpMethod, uri);
        }

        private HttpRequestMessage CreateHttpRequestMessage(HttpMethod httpMethod, string requestUri, Dictionary<string, string?> queryParameters)
        {
            queryParameters.Add("access_key", _options.ApiKey);

            string uri = QueryHelpers.AddQueryString(requestUri, queryParameters.Where(x => !string.IsNullOrEmpty(x.Value)).ToDictionary(x => x.Key, x => x.Value));

            return new HttpRequestMessage(httpMethod, uri);
        }
    }
}
