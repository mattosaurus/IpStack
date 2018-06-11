using System;
using System.Collections.Generic;
using System.Text;

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
        public DateTime CurrentTime { get; set; }

        /// <summary>
        /// Returns the GMT offset of the given time zone in seconds.
        /// </summary>
        public int GmtOffset { get; set; }

        /// <summary>
        /// Returns the universal code of the given time zone.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the given time zone is considered daylight saving time.
        /// </summary>
        public bool IsDaylightSaving { get; set; }
    }
}
