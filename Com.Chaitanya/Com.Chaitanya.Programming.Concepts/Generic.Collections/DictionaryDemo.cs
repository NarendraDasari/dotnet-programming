using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Chaitanya.Programming.Concepts.Generic.Collections
{
    public class DictionaryDemo
    {
        public void TestDictionary()
        {
            Dictionary<int,string> dic=new Dictionary<int,string>();
            dic.Add(10,"Jarman" );
            dic.Add(20,"Peters");
            dic.Add(30, "Clark");
            dic.Add(40, "Rosa Park");


            foreach (KeyValuePair<int, string> keyvalue in dic)
            {
                Console.WriteLine("{0} {1}", keyvalue.Key, keyvalue.Value);
            }




        }
    }
}
