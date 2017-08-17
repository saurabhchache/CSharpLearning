using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Assignments
{
    public class SimpleCache
    {
        private static Dictionary<string, Object> _cache;
                
        public SimpleCache()
        {
            _cache = new Dictionary<string, Object>();
        }

        public void Remove(string key)
        {
            _cache.Remove(key);
        }

        public void Clear()
        {
            _cache.Clear();
        }

        public Object this[string key]
        {
            get
            {
                ValidateKey(key);

                return _cache[key];
            }
            set
            {
                ValidateKey(key);

                if (_cache.ContainsKey(key))
                {
                    _cache[key] = new WeakReference(value, false);
                }
            }
        }

        public void Add(string key, Object value)
        {
            ValidateKey(key);

            if (_cache.ContainsKey(key))
            {
                throw new ArgumentException("An item with the same key has already been added.");
            }
            else
            {
                _cache.Add(key, new WeakReference(value, false));
            }
        }

        public Object Get(string key)
        {
            ValidateKey(key);

            return _cache[key];
        }

        public T Get<T>(string key)
        {
            return (T)Get(key);
        }

        public void Update(string key, Object value)
        {
            ValidateKey(key);

            if (_cache.ContainsKey(key))
            {
                _cache[key] = new WeakReference(value, false);
            }
        }

        private void ValidateKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("Invalid key");
        }
    }
}
