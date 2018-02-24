using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class StringDictionaryDemo
    {
        static void Main()
        {
            StringDictionary sd = new StringDictionary();
            sd.Add("cat", "feline");
            sd.Add("dog", "canine");
                       
            Console.WriteLine(sd["cat"]);
            Console.WriteLine(sd["test"] == null);

            
            Console.WriteLine(sd.ContainsKey("puppet"));
            Console.WriteLine(sd.ContainsValue("feline"));
            Console.WriteLine(sd.IsSynchronized);
            Console.WriteLine("elements in the stringdictionary are:");
            foreach (DictionaryEntry entry in sd)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            foreach (string key in sd.Keys)
            {
                Console.WriteLine(key);
            }


            foreach (string value in sd.Values)
            {
                Console.WriteLine(value);
            }

            sd.Remove("cat");
            Console.WriteLine("the no.of elements in the stringdictionary :");
            Console.WriteLine(sd.Count);
           sd.Clear();
            Console.WriteLine("after clear() no.of elements in the stringdictionary :");
            Console.WriteLine(sd.Count);
            Console.ReadLine();
        }
    }
}
