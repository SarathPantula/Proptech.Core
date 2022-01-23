namespace Proptech.Core.Extensions
{
    public static class DateTimeExtension
    {
        public static DateTime? GetDateTime(this long? dateTime)
        {
            if (dateTime != null)
            {
                return DateTimeOffset.FromUnixTimeMilliseconds(dateTime.Value).DateTime;
            }

            return null;
        }

        public static long EpochTime(this DateTime dateTime)
        {
            return (long)dateTime.Subtract(new DateTime(1970, 1, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
        }
    }
}
