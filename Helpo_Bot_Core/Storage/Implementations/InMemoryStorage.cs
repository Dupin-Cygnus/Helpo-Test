using System;
using System.Collections.Generic;
using System.Text;

namespace Helpo_Bot_Core.Storage.Implementations
{
    public class InMemoryStorage : IDataStorage
    {
        private Dictionary<string, object> _dictionary = new Dictionary<string, object>;

        public T RestoreObject<T>(string key)
        {
            if (!_dictionary.ContainsKey(key))
                throw new ArgumentException($"The provided kry '{key}' wasn't found.");

            return (T)_dictionary[key];
        }

        public void StoreObject(object obj, string key)
        {
            if (_dictionary.ContainsKey(key)) return;
            else
                _dictionary.Add(key, obj);
        }
    }
}
