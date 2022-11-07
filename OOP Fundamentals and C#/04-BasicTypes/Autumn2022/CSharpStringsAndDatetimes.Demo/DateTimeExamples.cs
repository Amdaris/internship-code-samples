using System.Globalization;
using System.Runtime.Serialization;

namespace CSharpStringsAndDatetimes.Demo
{
    internal static class DateTimeExamples
    {
        internal static void ShowExamples()
        {
            string date = "7/12/2022 09:00 AM";
            DateTime dateTime = DateTime.Parse(date);
            Console.WriteLine($"{dateTime:D}");

            //TODO: Add / Subtract

            //1. DateTime Offset
            DateTimeOffset dateTimeOffset = new(DateTime.Now);

            Console.WriteLine($"{dateTimeOffset.DateTime}, {dateTimeOffset.DateTime.Kind}");

            Console.WriteLine($"{dateTimeOffset.LocalDateTime}, {dateTimeOffset.LocalDateTime.Kind}");

            Console.WriteLine($"{dateTimeOffset.UtcDateTime}, {dateTimeOffset.UtcDateTime.Kind}");

            //2. TimeZone Info

            TimeZoneInfo info = TimeZoneInfo.Local;
            bool isDayLight = info.IsDaylightSavingTime(DateTime.Now);
            // False

            var offset = info.GetUtcOffset(DateTime.Now);
            // 02:00:00

            var allZones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var zone in allZones)
            {
                Console.WriteLine(zone.DisplayName);
            }

            //3. Culture Info Format Provider
            CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
            Console.WriteLine(3.ToString("C", uk));
            Console.WriteLine(3.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture));
            // 11 / 07 / 2022 09:14:25

            Console.WriteLine(DateTime.Now.ToString(new CultureInfo("en - US")));
            // 11 / 7 / 2022 9:14:25 AM

            //4. Number Format Info
            NumberFormatInfo formatter = new();
            formatter.NumberGroupSeparator = "-";
            Console.WriteLine(4235211.43.ToString("N3", formatter));
        }
    }
}
