using System;
using System.Collections.Generic;

namespace Jtk.Extensions
{
    /// <summary>
    /// Extensions method for all general objects    
    /// </summary>
    public static class ObjectExtensions
    {
        public static TResult NullSafe<TInput, TResult>(this TInput value, Func<TInput, TResult> evaluator)
            where TInput : class
        {
            return (value != null) ? evaluator(value) : default(TResult);
        }

        public static TResult NullSafe<TInput, TResult>(this TInput value, Func<TInput, TResult> evaluator, TResult failureValue)
            where TInput : class
        {
            return (value != null) ? evaluator(value) : failureValue;
        }

        /// <summary>
        /// Whether the object is null
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns>Whether the object is null</returns>
        public static bool IsNull(this object inputObject)
        {
            return inputObject == null;
        }

        /// <summary>
        /// Whether the object is not null
        /// </summary>
        /// <param name="inputObject"></param>
        /// <returns>Whether the object is not null</returns>
        public static bool IsNotNull(this object inputObject)
        {
            return inputObject != null;
        }

        /// <summary>
        /// Convert dictionary of object field and value to the original object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static T ToObject<T>(this IDictionary<string, object> source)
            where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();

            foreach (var item in source)
            {
                someObjectType
                            .GetProperty(item.Key)
                            .SetValue(someObject, item.Value, null);
            }

            return someObject;
        }
    }
}
