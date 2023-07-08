using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class CustomDictionary
    {
        private const int DefaultCapacity = 10;
        private const double LoadFactor = 0.75;
        private KeyValuePair[] entries;
        private int count;

        public CustomDictionary()
        {
            entries = new KeyValuePair[DefaultCapacity];
            count = 0;
        }

        public void Add(string key, int value)
        {
            if ((double)count / entries.Length >= LoadFactor)
            {
                Resize();
            }

            int index = GetIndex(key);
            entries[index] = new KeyValuePair(key, value);
            count++;
        }

        public int Get(string key)
        {
            int index = GetIndex(key);
            return entries[index].Value;
        }

        private int GetIndex(string key)
        {
            int hashCode = key.GetHashCode();
            int index = Math.Abs(hashCode) % entries.Length;
            return index;
        }

        private void Resize()
        {
            int newSize = entries.Length * 2;
            KeyValuePair[] newEntries = new KeyValuePair[newSize];

            foreach (var entry in entries)
            {
                if (entry != null)
                {
                    int index = GetIndex(entry.Key);
                    newEntries[index] = entry;
                }
            }

            entries = newEntries;
        }
    }

    /*
    class CustomDictionary
    {
        private const int DefaultCapacity = 10;
        private KeyValuePair[] entries;

        public CustomDictionary()
        {
            entries = new KeyValuePair[DefaultCapacity];
        }

        public void Add(string key, int value)
        {
            int index = GetIndex(key);
            entries[index] = new KeyValuePair(key, value);
        }

        public int Get(string key)
        {
            int index = GetIndex(key);
            return entries[index].Value;
        }

        private int GetIndex(string key)
        {
            int hashCode = key.GetHashCode();
            int index = Math.Abs(hashCode) % entries.Length;
            return index;
        }
    }
    */
}
