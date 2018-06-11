using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class Location
    {
        /// <summary>
        /// Returns the unique geoname identifier in accordance with the Geonames Registry.
        /// </summary>
        public string GeonameId { get; set; }

        /// <summary>
        /// Returns the capital city of the country associated with the IP.
        /// </summary>
        public string Capital { get; set; }

        /// <summary>
        /// Returns an object containing one or multiple sub-objects per language spoken in the country associated with the IP.
        /// </summary>
        public List<Language> Languages { get; set; }

        /// <summary>
        /// Returns an HTTP URL leading to an SVG-flag icon for the country associated with the IP.
        /// </summary>
        public string CountryFlag { get; set; }

        /// <summary>
        /// Returns the emoji icon for the flag of the country associated with the IP.
        /// </summary>
        public string CountryFlagEmoji { get; set; }

        /// <summary>
        /// Returns the unicode value of the emoji icon for the flag of the country associated with the IP.
        /// </summary>
        public string CountryFlagEmojiUnicode { get; set; }

        /// <summary>
        /// Returns the calling/dial code of the country associated with the IP.
        /// </summary>
        public string CallingCode { get; set; }

        /// <summary>
        /// Returns true or false depending on whether or not the county associated with the IP is in the European Union.
        /// </summary>
        public bool IsEu { get; set; }
    }
}
