using System;
using System.Globalization;

namespace Chef.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime SpecifyTime(this DateTime me, int hour, int minute, int second)
        {
            return new DateTime(me.Year, me.Month, me.Day, hour, minute, second);
        }

        public static DateTime ToDateTime(this string me, string format, IFormatProvider provider = null)
        {
            return DateTime.ParseExact(me, format, provider ?? CultureInfo.InvariantCulture);
        }
    }
}