namespace RGomes.Escola.Domain
{
    using System.Text.RegularExpressions;
    internal static class StringExtensions
    {
        public static bool Matches(this string value, string pattern)
        {
            if (value.IsNullOrEmpty()) return false;
            var regex = new Regex(pattern);
            return regex.Match(value).Success;
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
