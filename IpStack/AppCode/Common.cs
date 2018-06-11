using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.AppCode
{
    public static class Common
    {
        public static int? BoolToInt(bool? value)
        {
            if (value == true)
            {
                return 1;
            }
            else if (value == false)
            {
                return 0;
            }
            else
            {
                return null;
            }
        }
    }
}
