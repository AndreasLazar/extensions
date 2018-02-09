using System;
using System.Collections.Generic;

namespace Lazar.Extensions
{
    public static class DictionaryExt
    {
        public static bool IsNullOrEmpty<TKey,TValue>(this Dictionary<TKey,TValue> dict)
            => dict == null || dict.Count == 0;
    }
}