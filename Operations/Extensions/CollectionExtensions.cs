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
            if (self.FirstOrDefault(x => x.Id == item.Id) == null)
            {
                self.Add(item);
            }
        }
    }
}
