using System;
using System.Collections.Generic;
using System.Linq;

namespace Chef.Extensions
{
    public static class EnumerableExtension
    {
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> me, int count)
        {
            return me.Skip(Math.Max(0, me.Count() - count));
        }
    }
}