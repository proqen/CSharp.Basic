using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14._3
{
    class MyDictionary<TKey, TValue> : IEnumerable<object>, IEnumerator<object> where TKey : notnull
    {
        private TKey[] Keys;
        private TValue[] Values;
        private int position = -1;
        public MyDictionary() => (Keys, Values) = (new TKey[0], new TValue[0]);

        public (TKey, TValue) this[TKey key]
        {
            get
            {
                if (Keys.Contains(key))
                {
                    int index = Array.IndexOf(Keys, key);
                    return (Keys[index], Values[index]);
                }
                else
                    throw new Exception("Error");
            }
        }

        public void Add(TKey key, TValue value)
        {
            if (Keys.Contains(key))
                throw new Exception("Error");
            else
            {
                Array.Resize(ref Keys, Keys.Length + 1);
                Keys[^1] = key;
                Array.Resize(ref Values, Values.Length + 1);
                Values[^1] = value;
            }
        }
        public object Current => (Keys[position], Values[position]);
        public object Key => Keys[position];
        public object Value => Values[position];
        public void Dispose() => Reset();

        public IEnumerator<object> GetEnumerator() => this;

        public bool MoveNext() => Keys.Length-1 > position++ && position > -1 ? true : false;

        public void Reset() => position = -1;

        IEnumerator IEnumerable.GetEnumerator() => this;
    }
}
