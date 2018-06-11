using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class IpAddressDetails
    {
        /// <summary>
        /// Returns the requested IP address.
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// Returns the hostname the requested IP resolves to, only returned if Hostname Lookup is enabled.
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Returns the IP address type IPv4 or IPv6.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Returns the 2-letter continent code associated with the IP.
        /// </summary>
        public string ContinentCode { get; set; }

        /// <summary>
        /// Returns the name of the continent associated with the IP.
        /// </summary>
        public string ContinentName { get; set; }

        /// <summary>
        /// Returns the 2-letter country code associated with the IP.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the name of the country associated with the IP.
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Returns the region code of the region associated with the IP.
        /// </summary>
        public string RegionCode { get; set; }

        /// <summary>
        /// Returns the name of the region associated with the IP.
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Returns the name of the city associated with the IP.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Returns the ZIP code associated with the IP.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Returns the latitude value associated with the IP.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Returns the longitude value associated with the IP.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Returns multiple location-related objects.
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Returns an object containing timezone-related data.
        /// </summary>
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// Returns an object containing currency-related data.
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Returns an object containing connection-related data.
        /// </summary>
        public Connection Connection { get; set; }

        /// <summary>
        /// Returns an object containing security-related data.
        /// </summary>
        public Security Security { get; set; }
    }
}
