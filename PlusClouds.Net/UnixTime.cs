using System;

namespace PlusCloudsNet
{
    public static class UnixTime
    {
        public static long ToUnixTime(this DateTime time)
        {
            return
                (long)
                    (time.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))).TotalSeconds;
        }

        public static long UnixTimeNow()
        {
            return DateTime.Now.ToUnixTime();
        }

        public static DateTime ToDateTime(this long epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch).ToLocalTime();
        }

        public static DateTime ToUtcDateTime(this long epoch)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(epoch);
        }
    }
}