using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Extensions.String
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the number of occurences in the given string
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public static int GetOccurencesOf(this string str, string searchString)
        {
            if (searchString.IsNullOrEmpty())
                return 0;

            int count = 0;
            int searchIndex = str.IndexOf(searchString);

            while (searchIndex > -1)
            {
                ++count;
                searchIndex = str.IndexOf(searchString, searchIndex + searchString.Length);
            }
            return count;
        }

        /// <summary>
        /// Removes all the vowels from the given string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <remarks>Based on the benchmark results here: https://gist.github.com/yellis/9110421 </remarks>
        public static string RemoveVowels(this string str)
        {
            var pattern = @"[aeiou]";
            return Regex.Replace(str, pattern, "", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Reverse the string
        /// </summary>
        /// <param name="str">String to be reversed</param>
        /// <returns>String</returns>
        public static string Reverse(this string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        /// <summary>
        /// Checks if the string is null or empty
        /// For lazy guys
        /// </summary>
        /// <param name="str">String to check for null or empty</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        /// <summary>
        /// Returns true if the given string is palindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalindrome(this string str)
        {
            return str == str.Reverse();
        }

        /// <summary>
        /// Terminate the string with ... after specified length
        /// </summary>
        /// <param name="str"></param>
        /// <param name="TerminateLength"></param>
        /// <returns></returns>
        public static string TruncateWithEllipses(this string str, int TerminateLength)
        {
            if (str.IsNullOrEmpty())
                return str;
            if (TerminateLength > str.Length)
                return str;

            return str.Substring(0, TerminateLength) + "...";
        }

    }
}
