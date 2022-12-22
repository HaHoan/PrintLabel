using System;
using System.Collections.Generic;

namespace PrintLabel.Common
{
    public static class DictionaryMethods
    {
        private const int _MAX_COUNT = 1000;

        private const int _RESERVED_COUNT = 100;

        private static readonly object _Lock_ = new object();

        public static TKey[] GetKeys<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (dictionary.Count > 0)
            {
                TKey[] array = new TKey[dictionary.Count];
                dictionary.Keys.CopyTo(array, 0);
                return array;
            }
            return new TKey[0];
        }

        public static TValue[] GetValues<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (dictionary.Count > 0)
            {
                TValue[] array = new TValue[dictionary.Count];
                dictionary.Values.CopyTo(array, 0);
                return array;
            }
            return new TValue[0];
        }

        public static TValue LoadValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector)
        {
            return dictionary.LoadValue(key, valueSelector, null, true);
        }

        public static TValue LoadValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator)
        {
            return dictionary.LoadValue(key, valueSelector, valueValidator, true);
        }

        public static TValue LoadValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator, bool triming)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (key.IsNull<TKey>())
            {
                throw Error.ArgumentNull("key");
            }
            TValue result;
            lock (DictionaryMethods._Lock_)
            {
                TValue tValue;
                if (!dictionary.TryGetValue(key, out tValue) && valueSelector != null)
                {
                    tValue = valueSelector();
                    if (valueValidator == null || valueValidator(tValue))
                    {
                        if (triming)
                        {
                            DictionaryMethods.Trim_core<TKey, TValue>(dictionary, 1000, 100);
                        }
                        dictionary.Add(key, tValue);
                    }
                }
                result = tValue;
            }
            return result;
        }

        public static KeyValuePair<TKey, TValue>[] MakeArray<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (dictionary.Count > 0)
            {
                KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[dictionary.Count];
                ((ICollection<KeyValuePair<TKey, TValue>>)dictionary).CopyTo(array, 0);
                return array;
            }
            return new KeyValuePair<TKey, TValue>[0];
        }

        public static IDictionary<TKey, TValue> Trim<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            lock (DictionaryMethods._Lock_)
            {
                DictionaryMethods.Trim_core<TKey, TValue>(dictionary, 1000, 100);
            }
            return dictionary;
        }

        public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector)
        {
            return dictionary.TryAdd(key, valueSelector, null, true);
        }

        public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator)
        {
            return dictionary.TryAdd(key, valueSelector, valueValidator, true);
        }

        public static bool TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator, bool triming)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (key.IsNull<TKey>())
            {
                throw Error.ArgumentNull("key");
            }
            if (valueSelector == null)
            {
                throw Error.ArgumentNull("valueSelector");
            }
            bool result;
            lock (DictionaryMethods._Lock_)
            {
                if (!dictionary.ContainsKey(key))
                {
                    TValue tValue = valueSelector();
                    if (valueValidator == null || valueValidator(tValue))
                    {
                        if (triming)
                        {
                            DictionaryMethods.Trim_core<TKey, TValue>(dictionary, 1000, 100);
                        }
                        dictionary.Add(key, tValue);
                        result = true;
                        return result;
                    }
                }
                result = false;
            }
            return result;
        }

        public static bool TryRemove<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (key.IsNull<TKey>())
            {
                throw Error.ArgumentNull("key");
            }
            bool result;
            lock (DictionaryMethods._Lock_)
            {
                result = (dictionary.Count > 0 && dictionary.Remove(key));
            }
            return result;
        }

        public static bool TrySetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            return dictionary.TrySetValue(key, () => value, null, true);
        }

        public static bool TrySetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector)
        {
            return dictionary.TrySetValue(key, valueSelector, null, true);
        }

        public static bool TrySetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator)
        {
            return dictionary.TrySetValue(key, valueSelector, valueValidator, true);
        }

        public static bool TrySetValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueSelector, Func<TValue, bool> valueValidator, bool triming)
        {
            if (dictionary == null)
            {
                throw Error.ArgumentNull("dictionary");
            }
            if (key.IsNull<TKey>())
            {
                throw Error.ArgumentNull("key");
            }
            if (valueSelector == null)
            {
                throw Error.ArgumentNull("valueSelector");
            }
            bool result;
            lock (DictionaryMethods._Lock_)
            {
                TValue tValue = valueSelector();
                if (valueValidator == null || valueValidator(tValue))
                {
                    if (dictionary.ContainsKey(key))
                    {
                        dictionary[key] = tValue;
                    }
                    else
                    {
                        if (triming)
                        {
                            DictionaryMethods.Trim_core<TKey, TValue>(dictionary, 1000, 100);
                        }
                        dictionary.Add(key, tValue);
                    }
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        private static void Trim_core<TKey, TValue>(Dictionary<TKey, TValue> source, int maxCount, int reserveCount)
        {
            int count = source.Count;
            if (count == 0 || count < maxCount || count < reserveCount)
            {
                return;
            }
            KeyValuePair<TKey, TValue>[] array = new KeyValuePair<TKey, TValue>[count];
            if (0 < reserveCount)
            {
                ((ICollection<KeyValuePair<TKey, TValue>>)source).CopyTo(array, 0);
            }
            source.Clear();
            if (0 < reserveCount)
            {
                for (int i = count - reserveCount; i < count; i++)
                {
                    KeyValuePair<TKey, TValue> keyValuePair = array[i];
                    source.Add(keyValuePair.Key, keyValuePair.Value);
                }
            }
        }
    }
}
