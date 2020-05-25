using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreExtension.Extensions
{
    public static class ListExtension
    {
        public static bool HashElement(this ICollection list)
        {
            return list != null && list.Count > 0 ? true : false;
        }
    }
}
