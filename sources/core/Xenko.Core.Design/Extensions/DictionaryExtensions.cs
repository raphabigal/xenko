// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Collections.Generic;
using Xenko.Core.Annotations;

namespace Xenko.Core.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue TryGetValue<TKey, TValue>([NotNull] this IReadOnlyDictionary<TKey, TValue> thisObject, [NotNull] TKey key)
        {
            TValue result;
            thisObject.TryGetValue(key, out result);
            return result;
        }

        public static void AddRange<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> thisObject, [NotNull] IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            foreach (var keyValuePair in keyValuePairs)
            {
                thisObject.Add(keyValuePair);
            }
        }

        public static void Merge<TKey, TValue>([NotNull] this IDictionary<TKey, TValue> thisObject, [NotNull] IEnumerable<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            foreach (var keyValuePair in keyValuePairs)
            {
                thisObject[keyValuePair.Key] = keyValuePair.Value;
            }
        }
    }
}
