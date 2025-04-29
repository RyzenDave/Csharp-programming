using System;

namespace DateTim
{
    internal class Program
    {
        #region DateTime examples
        static void Main(string[] args)
        {
            DateTimeExamples();
            Console.WriteLine(); // Empty line for separation
            DateTimeProperties();
            Console.WriteLine(); // Empty line for separation
            DateTimeAdditionalMethods();
            Console.WriteLine(); // Empty line for separation
            DateTimeFormattingExamples();
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        // Method that demonstrates various basic DateTime examples.
        static void DateTimeExamples()
        {
            Console.WriteLine("===== DateTime Examples =====");

            // 1. Creating an empty DateTime (defaults to 01/01/0001 00:00:00)
            DateTime emptyDate = new DateTime();
            Console.WriteLine("Empty DateTime: " + emptyDate);

            // 2. Current Local Date and Time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current local date and time: " + now);

            // 3. Current UTC Date and Time
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine("Current UTC date and time: " + utcNow);

            // 4. Creating a Specific DateTime instance
            // Example: March 6, 2025 at 2:30:00 PM
            DateTime specificDate = new DateTime(2025, 3, 6, 14, 30, 0);
            Console.WriteLine("Specific DateTime: " + specificDate);

            // 5. Formatting DateTime to a Customized String
            // Format pattern: weekday, day month year hour:minute:second
            string formatted = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            Console.WriteLine("Formatted current date and time: " + formatted);

            // 6. Parsing a DateTime from a String
            string dateStr = "03/06/2025 14:30:00";
            DateTime parsedDate = DateTime.Parse(dateStr);
            Console.WriteLine("Parsed DateTime: " + parsedDate);

            // 7. Adding Days to a DateTime
            DateTime plusDays = now.AddDays(5);
            Console.WriteLine("Date plus 5 days: " + plusDays);

            // 8. Subtracting Hours from a DateTime
            DateTime minusHours = now.AddHours(-3);
            Console.WriteLine("Date minus 3 hours: " + minusHours);

            // 9. Calculating the Difference Between Two Dates
            TimeSpan diff = now - specificDate;
            Console.WriteLine("Difference between now and specific date (in total days): " + diff.TotalDays);

            // 10. Comparing Two DateTime Values
            // CompareTo returns:
            // < 0 if this instance is earlier than value,
            // 0 if they are equal,
            // > 0 if this instance is later than value.
            int comparison = now.CompareTo(specificDate);
            Console.WriteLine("Now compared to specific date: " + (comparison < 0 ? "Earlier" : comparison == 0 ? "Same" : "Later"));
        }
        #endregion
        // Method that prints all properties from one specific DateTime instance.
        static void DateTimeProperties()
        {
            // Create a specific DateTime instance.
            DateTime dt = new DateTime(2025, 3, 6, 14, 30, 45, 123, DateTimeKind.Local);

            Console.WriteLine("===== DateTime Properties =====");
            Console.WriteLine("Date: " + dt.Date);             // Date component (time set to midnight)
            Console.WriteLine("Day: " + dt.Day);               // Day of the month
            Console.WriteLine("DayOfWeek: " + dt.DayOfWeek);   // Day of the week
            Console.WriteLine("DayOfYear: " + dt.DayOfYear);   // Day of the year
            Console.WriteLine("Hour: " + dt.Hour);             // Hour component
            Console.WriteLine("Kind: " + dt.Kind);             // DateTimeKind: Local, Utc, or Unspecified
            Console.WriteLine("Millisecond: " + dt.Millisecond); // Millisecond component
            Console.WriteLine("Minute: " + dt.Minute);         // Minute component
            Console.WriteLine("Month: " + dt.Month);           // Month component
            Console.WriteLine("Second: " + dt.Second);         // Second component
            Console.WriteLine("Ticks: " + dt.Ticks);           // Total ticks representing the date and time
            Console.WriteLine("TimeOfDay: " + dt.TimeOfDay);   // Time elapsed since midnight
            Console.WriteLine("Year: " + dt.Year);             // Year component
        }

        // Method that demonstrates additional DateTime methods.
        static void DateTimeAdditionalMethods()
        {
            Console.WriteLine("===== Additional DateTime Methods =====");

            DateTime now = DateTime.Now;
            Console.WriteLine("Now: " + now);

            // AddMilliseconds: Adds 500 milliseconds.
            DateTime plusMilliseconds = now.AddMilliseconds(500);
            Console.WriteLine("Now + 500 milliseconds: " + plusMilliseconds);

            // AddSeconds: Adds 30 seconds.
            DateTime plusSeconds = now.AddSeconds(30);
            Console.WriteLine("Now + 30 seconds: " + plusSeconds);

            // AddMinutes: Adds 10 minutes.
            DateTime plusMinutes = now.AddMinutes(10);
            Console.WriteLine("Now + 10 minutes: " + plusMinutes);

            // AddMonths: Adds 2 months.
            DateTime plusMonths = now.AddMonths(2);
            Console.WriteLine("Now + 2 months: " + plusMonths);

            // AddYears: Adds 1 year.
            DateTime plusYears = now.AddYears(1);
            Console.WriteLine("Now + 1 year: " + plusYears);

            // Subtract: Using the Subtract method with a TimeSpan.
            TimeSpan tenDays = TimeSpan.FromDays(10);
            DateTime minusTenDays = now.Subtract(tenDays);
            Console.WriteLine("Now - 10 days: " + minusTenDays);

            // ToLocalTime: Converts a UTC DateTime to local time.
            DateTime utcNow = DateTime.UtcNow;
            DateTime localFromUtc = utcNow.ToLocalTime();
            Console.WriteLine("UTC Now: " + utcNow);
            Console.WriteLine("UTC Now converted to local: " + localFromUtc);

            // ToUniversalTime: Converts a local DateTime to UTC.
            DateTime utcFromLocal = now.ToUniversalTime();
            Console.WriteLine("Local (Now) converted to UTC: " + utcFromLocal);

            // IsDaylightSavingTime: Checks if the current DateTime is in daylight saving time.
            bool isDST = now.IsDaylightSavingTime();
            Console.WriteLine("Is now in Daylight Saving Time? " + isDST);

            // DateTime.Compare: Compares two DateTime instances.
            DateTime earlier = now.AddHours(-5);
            int compareResult = DateTime.Compare(earlier, now);
            Console.WriteLine("Comparing earlier and now using DateTime.Compare: " + (compareResult < 0 ? "Earlier" : compareResult > 0 ? "Later" : "Equal"));

            // ToFileTime: Converts the current DateTime to a Windows file time (a long).
            long fileTime = now.ToFileTime();
            Console.WriteLine("Now in FileTime: " + fileTime);
        }

        // Method that demonstrates various DateTime formatting options.
        static void DateTimeFormattingExamples()
        {
            Console.WriteLine("===== DateTime Formatting Examples =====");

            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date/Time: " + now);

            // Standard format specifiers:
            Console.WriteLine("Short date (d): " + now.ToString("d"));    // MM/dd/yyyy (culture-specific)
            Console.WriteLine("Long date (D): " + now.ToString("D"));      // Day, Month dd, yyyy
            Console.WriteLine("Full date/time (short time) (f): " + now.ToString("f"));
            Console.WriteLine("Full date/time (long time) (F): " + now.ToString("F"));
            Console.WriteLine("General date/time (short time) (g): " + now.ToString("g"));
            Console.WriteLine("General date/time (long time) (G): " + now.ToString("G"));
            Console.WriteLine("Month day pattern (M): " + now.ToString("M"));
            Console.WriteLine("Round-trip (o): " + now.ToString("o"));     // ISO 8601 format
            Console.WriteLine("RFC1123 (r): " + now.ToString("r"));
            Console.WriteLine("Sortable (s): " + now.ToString("s"));
            Console.WriteLine("Universal sortable (u): " + now.ToString("u"));

            // Custom format specifiers:
            Console.WriteLine("Custom format (yyyy-MM-dd HH:mm:ss): " + now.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("Custom format (dd/MM/yyyy): " + now.ToString("dd/MM/yyyy"));
            Console.WriteLine("Custom format with literal text: " + now.ToString("'Today is' dddd, dd MMMM yyyy"));
        }
    }
}
