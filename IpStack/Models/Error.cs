using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class Error
    {
        public int Code { get; set; }

        public string Type { get; set; }

        public string Info { get; set; }
    }
}
