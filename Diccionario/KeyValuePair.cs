using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class KeyValuePair
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public KeyValuePair(string key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
