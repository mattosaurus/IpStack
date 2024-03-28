using System.Text.Json.Serialization;

namespace IpStack.Models
{
    public class TimeZone
    {
        /// <summary>
        /// Returns the ID of the time zone associated with the IP.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Returns the current date and time in the location associated with the IP.
        /// </summary>
        [JsonPropertyName("current_time")]
        public DateTime CurrentTime { get; set; }

        /// <summary>
        /// Returns the GMT offset of the given time zone in seconds.
        /// </summary>
        [JsonPropertyName("gmt_offset")]
        public int? GmtOffset { get; set; }

        /// <summary>
        /// Returns the universal code of the given time zone.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given time zone is considered daylight saving time.
        /// </summary>
        [JsonPropertyName("is_daylight_saving")]
        public bool? IsDaylightSaving { get; set; }
    }
}
