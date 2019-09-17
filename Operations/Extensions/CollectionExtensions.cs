using System;
using System.Collections.Generic;
using System.Linq;
using Operations.Interfaces;

namespace Operations.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Add item to collection if not already exists in collection
        /// </summary>
        /// <typeparam name="TType">Class type</typeparam>
        /// <param name="self">Collection of type</param>
        /// <param name="item">instance of T</param>
        /// <remarks>
        /// T must implement IBase
        /// </remarks>
        public static void AddUnique<TType>(this ICollection<TType> self, TType item) where TType : IBase
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
        /// <typeparam name="TType">Type in the collection.</typeparam>
        /// <param name="self">Source collection</param>
        /// <param name="predicate">Predicate to determine whether a new item is already in source.</param>
        /// <param name="items">New items.</param>
        public static void AddRangeUnique<TType>(this ICollection<TType> self, Func<TType, TType, bool> predicate, IEnumerable<TType> items)
        {
            foreach (TType item in items)
            {
                if (!self.Any(data => predicate(data, item)))
                {
                    self.Add(item);
                }
            }
        }
        /// <summary>
        /// Add KeyValue pair if key does not already exists in Dictionary
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void AddSafe<TType>(this Dictionary<int, TType> dictionary, int key, TType value)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary.Add(key, value);
            }
        }
    }
}
