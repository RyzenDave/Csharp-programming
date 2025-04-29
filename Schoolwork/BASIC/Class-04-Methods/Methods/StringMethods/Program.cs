namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "  Hello, World! Welcome to C# string methods examples.   ";

            // Trim: Removes whitespace from the beginning and end of a string.
            string trimmed = original.Trim();
            Console.WriteLine("Trimmed: " + trimmed);

            // StartsWith: Checks if the string begins with the specified substring.
            bool startsWithHello = trimmed.StartsWith("Hello");
            Console.WriteLine("Starts with 'Hello': " + startsWithHello);

            // EndsWith: Checks if the string ends with the specified substring.
            bool endsWithExclamation = trimmed.EndsWith("!");
            Console.WriteLine("Ends with '!': " + endsWithExclamation);

            // Contains: Determines whether the string contains the specified substring.
            bool containsWorld = trimmed.Contains("World");
            Console.WriteLine("Contains 'World': " + containsWorld);

            // Replace: Replaces all occurrences of a specified substring with another substring.
            string replaced = trimmed.Replace("World", "Universe");
            Console.WriteLine("After Replace: " + replaced);

            // Substring: Retrieves a substring from a specified starting index and length.
            // For example, get 5 characters starting from index 7.
            string substr = trimmed.Substring(7, 5);
            Console.WriteLine("Substring (index 7, length 5): " + substr);

            // ToUpper: Converts the string to uppercase.
            string upper = trimmed.ToUpper();
            Console.WriteLine("ToUpper: " + upper);

            // ToLower: Converts the string to lowercase.
            string lower = trimmed.ToLower();
            Console.WriteLine("ToLower: " + lower);

            // Split: Splits the string into an array of substrings based on the specified delimiter.
            string[] parts = trimmed.Split(' ');
            Console.WriteLine("Split into words:");
            foreach (var part in parts)
            {
                Console.WriteLine("  " + part);
            }

            // IndexOf: Returns the index of the first occurrence of a specified substring.
            int index = trimmed.IndexOf("World");
            Console.WriteLine("Index of 'World': " + index);

            // LastIndexOf: Returns the index of the last occurrence of a specified substring.
            int lastIndex = trimmed.LastIndexOf("l");
            Console.WriteLine("Last index of 'l': " + lastIndex);

            // Format: Creates a formatted string by replacing format items with specified values.
            string formatted = string.Format("Formatted Number: {0:n0}, String: {1}", 12345, "example");
            Console.WriteLine("Formatted: " + formatted);

            // Join: Concatenates the elements of a string array using the specified separator.
            string joined = string.Join(", ", parts);
            Console.WriteLine("Joined: " + joined);
            string s = "Hello, World!";

            // Existing methods (from previous example) are great, but here are a few more:

            // Insert: Inserts a specified string at a specified index.
            string inserted = s.Insert(7, "Beautiful ");
            Console.WriteLine("After Insert: " + inserted);

            // Remove: Removes characters from the string starting at a specified index.
            // In this example, removes 7 characters starting at index 5.
            string removed = s.Remove(5, 7);
            Console.WriteLine("After Remove: " + removed);

            // PadLeft: Pads the string on the left with a specified character until it reaches the desired total length.
            string paddedLeft = s.PadLeft(20, '*');
            Console.WriteLine("PadLeft: " + paddedLeft);

            // PadRight: Pads the string on the right with a specified character until it reaches the desired total length.
            string paddedRight = s.PadRight(20, '*');
            Console.WriteLine("PadRight: " + paddedRight);

            // TrimStart: Removes all leading occurrences of a specified character or characters.
            // In this case, if 'H' occurs at the beginning, it'll be removed.
            string trimStart = s.TrimStart('H');
            Console.WriteLine("TrimStart: " + trimStart);

            // TrimEnd: Removes all trailing occurrences of a specified character or characters.
            // Here, it'll remove the '!' at the end if present.
            string trimEnd = s.TrimEnd('!');
            Console.WriteLine("TrimEnd: " + trimEnd);

            // ToCharArray: Converts the string into an array of characters.
            char[] charArray = s.ToCharArray();
            Console.WriteLine("Char Array: " + string.Join(", ", charArray));

            // Static methods to check string content:
            // IsNullOrEmpty: Returns true if the string is null or empty.
            bool isEmpty = string.IsNullOrEmpty(s);
            // IsNullOrWhiteSpace: Returns true if the string is null, empty, or consists only of white-space characters.
            bool isWhiteSpace = string.IsNullOrWhiteSpace("   ");
            Console.WriteLine($"IsNullOrEmpty: {isEmpty}, IsNullOrWhiteSpace: {isWhiteSpace}");

            // Compare: Compares two specified string objects using the specified rules.
            int comparison = string.Compare("apple", "banana", StringComparison.Ordinal);
            Console.WriteLine("Comparison result of 'apple' and 'banana': " + comparison);
        }
    }
}
