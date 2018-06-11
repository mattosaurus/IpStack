using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Models
{
    public class ErrorResponse
    {
        public bool Success { get; set; } = true;

        public Error Error { get; set; }
    }
}
