using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryOdev
{
    class MyDictionary<K,V>
    {
        
        K[] key;
        K[] tempKey;

        V[] value;
        V[] tempValue;



        public MyDictionary()
        {
            
            key = new K[0];
            value = new V[0];
        }

        public void Add(K keyItem, V valueItem)
        {
            
            tempKey = key;
            key = new K[key.Length+ 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }

            key[key.Length - 1] = keyItem;



            tempValue = value;
            value = new V[value.Length + 1];
            for (int j = 0; j < tempValue.Length; j++)
            {
                value[j] = tempValue[j];
            }
            value[value.Length - 1] = valueItem;
        }



        public K[] Key { get { return key; } }

        public V[] Value { get { return value; } }



    }
}
