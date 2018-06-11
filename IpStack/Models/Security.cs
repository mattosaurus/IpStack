using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class Security
    {
        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with a proxy.
        /// </summary>
        public bool IsProxy { get; set; }

        /// <summary>
        /// Returns the type of proxy the IP is associated with. 
        /// </summary>
        public string ProxyType { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with a crawler.
        /// </summary>
        public bool IsCrawler { get; set; }

        /// <summary>
        /// Returns the name of the crawler the IP is associated with.
        /// </summary>
        public string CrawlerName { get; set; }

        /// <summary>
        /// Returns the type of crawler the IP is associated with.
        /// </summary>
        public string CrawlerType { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with the anonymous Tor system.
        /// </summary>
        public bool IsTor { get; set; }

        /// <summary>
        /// Returns the type of threat level the IP is associated with.
        /// </summary>
        public string ThreatLevel { get; set; }

        /// <summary>
        /// Returns an object containing all threat types associated with the IP.
        /// </summary>
        public List<string> ThreatTypes { get; set; }
    }
}
