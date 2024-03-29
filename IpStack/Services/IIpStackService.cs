﻿using IpStack.Models;

namespace IpStack.Services
{
    public interface IIpStackService
    {
        Task<IpAddressDetails> GetIpAddressDetailsAsync(string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null);

        Task<IpAddressDetails> GetIpAddressDetailsAsync(string ipAddress, string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null);

        Task<IpAddressDetails> GetIpAddressDetailsAsync(IEnumerable<string> ipAddresses, string? fields = null, bool? hostname = null, bool? security = null, string? language = null, string? callback = null);
    }
}
