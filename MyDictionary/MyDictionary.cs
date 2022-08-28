using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    public class MyDictionary<TKey,TValue> 
    {
        KeyValuePair<TKey, TValue>[] item;
        

        public MyDictionary()
        {
            item = new KeyValuePair<TKey, TValue>[0];
        }
        public void Add(TKey key, TValue value)
        {
            KeyValuePair<TKey?, TValue>[] tmp = item;
            item = new KeyValuePair<TKey, TValue>[tmp.Length+1];
            for (int i =0;i<tmp.Length;i++)
            {
                item[i] = tmp[i];
            }
            item[tmp.Length] =KeyValuePair.Create(key, value);
         
        }
        
      
    }
}
