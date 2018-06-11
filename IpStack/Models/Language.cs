using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class Language
    {
        /// <summary>
        /// Returns the 2-letter language code for the given language.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Returns the name (in the API request's main language) of the given language.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Returns the native name of the given language.
        /// </summary>
        public string Native { get; set; }
    }
}
