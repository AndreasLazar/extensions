using System;

namespace Extensions
{
    public static class DateTimeExt
    {
        public static bool Between(this DateTime dateTime, DateTime start, DateTime end)
            => dateTime.Ticks >= start.Ticks && dateTime.Ticks <= end.Ticks;

        public static bool IsWeekend(this DateTime dateTime)
            => dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;

        public static bool IsWeekday(this DateTime dateTime)
            => !dateTime.IsWeekend();
    }
}