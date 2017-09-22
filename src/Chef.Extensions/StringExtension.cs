using System;
using System.Linq;

namespace Chef.Extensions
{
    public static class StringExtension
    {
        public static string Left(this string me, int length)
        {
            length = Math.Max(length, 0);

            return me.Length > length ? me.Substring(0, length) : me;
        }

        public static string Right(this string me, int length)
        {
            length = Math.Max(length, 0);

            return me.Length > length ? me.Substring(me.Length - length, length) : me;
        }

        public static string ToHtml(this string me)
        {
            return string.Join(
                string.Empty,
                me.ToCharArray().Select(c => c > 127 ? string.Concat("&#", (int)c, ";") : c.ToString()));
        }

        public static bool EqualsIgnoreCase(
            this string me,
            string value,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            return me != null && me.Equals(value, comparisonType);
        }

        public static bool EndsWithIgnoreCase(
            this string me,
            string value,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            return me != null && me.EndsWith(value, comparisonType);
        }

        public static bool StartsWithIgnoreCase(
            this string me,
            string value,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            return me != null && me.StartsWith(value, comparisonType);
        }

        public static bool ContainsIgnoreCase(
            this string me,
            string value,
            StringComparison comparisonType = StringComparison.OrdinalIgnoreCase)
        {
            return me != null && me.IndexOf(value, comparisonType) >= 0;
        }
    }
}