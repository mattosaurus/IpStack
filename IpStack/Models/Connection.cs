using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class Connection
    {
        /// <summary>
        /// Returns the Autonomous System Number associated with the IP.
        /// </summary>
        public int Asn { get; set; }

        /// <summary>
        /// Returns the name of the ISP associated with the IP.
        /// </summary>
        public string Isp { get; set; }
    }
}
