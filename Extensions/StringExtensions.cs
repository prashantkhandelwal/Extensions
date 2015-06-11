using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

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

        /// <summary>
        /// Indicates if the URL is valid
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(this string url)
        {
            return Uri.IsWellFormedUriString(url.Trim(), UriKind.Absolute);
        }

        /// <summary>
        /// Checks if the given string is a number
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNumber(this string str)
        {
            if (str.Trim().Length == 0) return false;

            foreach (char c in str)
            {
                if (!char.IsNumber(c)) return false;
            }
            return true;
        }

        /// <summary>
        /// Check if the given string is GUID
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsGuid(this string str)
        {
            if (str == null)
                throw new ArgumentNullException();

            Regex format = new Regex(
                "^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
            Match match = format.Match(str);

            return match.Success;
        }

        /// <summary>
        /// Returns the string with a proper title casing
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ToProperCase(this string text)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(text);
        }
    }
}
