using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkForDictionary
{
    public class MyDictionary<T, K>
    {
        KeyValuePair<T, K>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T _key, K _value)
        {
            if (Control(_key))
            {
                Configuration();
                items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value);
            }
            else
            {
                Console.WriteLine(_key + " : Numaralı key, daha önceden kullanmılmış lütfen değiştirin.");
            }

        }

        public void ShowList()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("Key : {0}, Value : {1}", items[i].Key, items[i].Value);
            }
        }
        private void Configuration()
        {
            KeyValuePair<T, K>[] tempArray = items;
            items = new KeyValuePair<T, K>[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

        }
        private bool Control(T _Key)
        {
            bool control = true;

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Key.ToString() == _Key.ToString())
                {
                    control = false;
                }
            }

            return control;
        }

    }
}
