namespace TicketApp.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToJsFriendlyProperty(this string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return string.Empty;

            var property = value.Substring(value.IndexOf('.') + 1);
            var jsFriendly = char.ToLower(property[0]) + property.Substring(1);
            if (!jsFriendly.Contains('.')) return jsFriendly;
            return ToJsFriendlyProperty(jsFriendly);
        }
    }
}
