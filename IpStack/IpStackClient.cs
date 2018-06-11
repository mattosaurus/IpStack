using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using IpStack.Models;
using RestSharp;
using IpStack.AppCode;
using RestSharp.Deserializers;

namespace IpStack
{
    public class IpStackClient
    {
        string baseUri = "http://api.ipstack.com/";

        readonly string _accessKey;
        readonly bool _https;

        public IpStackClient(string accessKey, [Optional] bool https)
        {
            _accessKey = accessKey;
            _https = https;
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var client = new RestClient();

            if (_https)
            {
                client.BaseUrl = new UriBuilder(baseUri) { Scheme = Uri.UriSchemeHttps, Port = -1 }.Uri;
            }
            else
            {
                client.BaseUrl = new Uri(baseUri);
            }
            
            request.AddParameter("access_key", _accessKey);

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                const string message = "Error retrieving response. Check inner details for more info.";
                throw new ApplicationException(message, response.ErrorException);
            }

            // Check for error object
            IDeserializer deserializer = new JsonDeserializer();
            ErrorResponse error = deserializer.Deserialize<ErrorResponse>(response);

            if (error.Success == false)
            {
                throw new ApplicationException(error.Error.Info);
            }

            return response.Data;
        }

        public IpAddressDetails GetIpAddressDetails(string ipAddress, [Optional] string fields, [Optional] bool? hostname, [Optional] bool? security, [Optional] string language, [Optional] string callback)
        {
            var request = new RestRequest();
            request.AddParameter("IpAddress", ipAddress, ParameterType.UrlSegment);
            request.Resource = "{IpAddress}";

            // Add optional parameters
            if (fields != null)
            {
                request.AddParameter("fields", fields);
            }
            if (hostname != null)
            {
                request.AddParameter("hostname", Common.BoolToInt(hostname));
            }
            if (security != null)
            {
                request.AddParameter("security", Common.BoolToInt(security));
            }
            if (language != null)
            {
                request.AddParameter("language", language);
            }
            if (callback != null)
            {
                request.AddParameter("fields", callback);
            }

            return Execute<IpAddressDetails>(request);
        }

        public IpAddressDetails GetIpAddressDetails(List<string> ipAddresses, [Optional] string fields, [Optional] bool? hostname, [Optional] bool? security, [Optional] string language, [Optional] string callback)
        {
            var request = new RestRequest();
            request.AddParameter("IpAddress", string.Join(",", ipAddresses), ParameterType.UrlSegment);
            request.Resource = "{IpAddress}";

            return Execute<IpAddressDetails>(request);
        }

        public IpAddressDetails GetRequesterIpAddressDetails([Optional] string fields, [Optional] bool? hostname, [Optional] bool? security, [Optional] string language, [Optional] string callback)
        {
            var request = new RestRequest();
            request.Resource = "check";

            return Execute<IpAddressDetails>(request);
        }
    }
}
