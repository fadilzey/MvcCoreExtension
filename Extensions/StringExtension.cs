using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreExtension.Extensions
{
    public static class StringExtension
    {
        public static int ConvertInt(this string value)
        {
            if (int.TryParse(value, out int x))
                return x;
            else return -1;
        }

    }
}
