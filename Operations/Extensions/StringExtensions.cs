using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Perform case insensitive equal on two strings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="item"></param>
        /// <returns>true if both strings are a match, false if not a match</returns>
        public static bool AreEqual(this string sender, string item) => 
            string.Equals(sender, item, StringComparison.OrdinalIgnoreCase);
        /// <summary>
        /// Determines if a string is within another string with Comparison options
        /// </summary>
        /// <param name="source"></param>
        /// <param name="compareToken">string to see if it exists in source string</param>
        /// <param name="comparer">StringComparison</param>
        /// <returns></returns>
        public static bool Contains(this string source, 
            string compareToken, StringComparison comparer = StringComparison.OrdinalIgnoreCase) => 
            source?.IndexOf(compareToken, comparer) >= 0;
    }
}
