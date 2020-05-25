using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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

        public static void SetObject(this ISession session, string sessionname, object value)
        {
            session.SetString(sessionname, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string sessionname)
        {
            var value = session.GetString(sessionname);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
