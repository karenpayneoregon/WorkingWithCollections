using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operations.Interfaces;

namespace Operations.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Add item to collection if not already exists in collection
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="self">Collection of type</param>
        /// <param name="item">instance of T</param>
        /// <remarks>
        /// T must implement IBase
        /// </remarks>
        public static void AddUnique<T>(this ICollection<T> self, T item) where T : IBase
        {
            if (self.FirstOrDefault(data => data.Id == item.Id) == null)
            {
                self.Add(item);
            }
        }

        /// <summary>
        /// Adds only items that do not exist in source.
        /// Can be slow for large collections and some complex types of source.
        /// </summary>
        /// <typeparam name="T">Type in the collection.</typeparam>
        /// <param name="self">Source collection</param>
        /// <param name="predicate">Predicate to determine whether a new item is already in source.</param>
        /// <param name="items">New items.</param>
        public static void AddArrangeUniqueBy<T>(this ICollection<T> self, Func<T, T, bool> predicate, IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                if (!self.Any(data => predicate(data, item)))
                {
                    self.Add(item);
                }
            }
        }
    }
}
