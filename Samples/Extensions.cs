using System;

namespace Samples
{
    public static class Extensions
    {
        /// <summary>
        /// Perform case insensitive equal on two strings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="item"></param>
        /// <returns>true if both strings are a match, false if not a match</returns>
        public static bool AreEqual(this string sender, string item) => string.Equals(sender, item, StringComparison.OrdinalIgnoreCase);
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}


