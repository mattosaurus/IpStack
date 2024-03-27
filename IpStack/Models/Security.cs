using System.Text.Json.Serialization;

namespace IpStack.Models
{
    public class Security
    {
        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with a proxy.
        /// </summary>
        [JsonPropertyName("is_proxy")]
        public bool IsProxy { get; set; }

        /// <summary>
        /// Returns the type of proxy the IP is associated with. 
        /// </summary>
        [JsonPropertyName("proxy_type")]
        public string ProxyType { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with a crawler.
        /// </summary>
        [JsonPropertyName("is_crawler")]
        public bool IsCrawler { get; set; }

        /// <summary>
        /// Returns the name of the crawler the IP is associated with.
        /// </summary>
        [JsonPropertyName("crawler_name")]
        public string CrawlerName { get; set; }

        /// <summary>
        /// Returns the type of crawler the IP is associated with.
        /// </summary>
        [JsonPropertyName("crawler_type")]
        public string CrawlerType { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given IP is associated with the anonymous Tor system.
        /// </summary>
        [JsonPropertyName("is_tor")]
        public bool IsTor { get; set; }

        /// <summary>
        /// Returns the type of threat level the IP is associated with.
        /// </summary>
        [JsonPropertyName("threat_level")]
        public string ThreatLevel { get; set; }

        /// <summary>
        /// Returns an object containing all threat types associated with the IP.
        /// </summary>
        [JsonPropertyName("threat_types")]
        public List<string> ThreatTypes { get; set; }
    }
}
