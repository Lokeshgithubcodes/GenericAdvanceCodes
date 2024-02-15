using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculationProj
{
    public class GenericDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        public Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }

        public TValue GetValue(TKey key)
        {
            if (!dictionary.ContainsKey(key))
                Console.WriteLine("Key not Found");

            return dictionary[key];
        }
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
