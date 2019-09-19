using System;

namespace Samples
{
    public static class ExtensionsSpecial 
    {
        /// <summary>
        /// Determines if a string is within another string with Comparison options
        /// </summary>
        /// <param name="source"></param>
        /// <param name="compareToken">string to see if it exists in source string</param>
        /// <param name="comparer">StringComparison</param>
        /// <returns></returns>
        public static bool ContainsWithOptions(this string source,
            string compareToken, StringComparison comparer = StringComparison.OrdinalIgnoreCase) =>
            source?.IndexOf(compareToken, comparer) >= 0;
    }
}


