using System.Collections.Generic;
using System.Linq;

namespace Jtk.Extensions
{
    /// <summary>
    /// Extensions for Enumberable and its subtypes    
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Return calling collection if not null, otherwise return an empty collection
        /// </summary>
        /// <param name="collection">The collection</param>        
        public static IEnumerable<T> NullSafe<T>(this IEnumerable<T> collection)
        {
            return collection ?? Enumerable.Empty<T>();
        }

        /// <summary>
        /// Return collection count is not null, otherwise return count of 0
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection</param>
        public static int NullSafeCount<T>(this IEnumerable<T> collection)
        {
            return collection != null ? collection.Count() : 0;
        }

        /// <summary>
        /// Whether the collection is null or empty
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || !collection.Any();
        }

        /// <summary>
        /// Whether the collection is not null or empty
        /// </summary>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return !IsNullOrEmpty(collection);
        }
    }
}
