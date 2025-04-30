using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_method.Helpers
{
    public static class StringHelper
    {
        public static string Shorten(this string str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentException("The number of words should not be less than 1!");
            if (str.Length == 0)
                return "";
            string[] words = str.Split(' ');
            if (words.Length < numberOfWords)
                return str;
            List<string> substring = words.Take(numberOfWords).ToList();
            string result = string.Join(" ", substring);
            return result + "...";
        }
    }
}
