//SortedDictionary
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> s = new SortedDictionary<string, string>();
            s.Add("5", "Andriod");
            s.Add("3", "python");
            s.Add("4", "Haddop");
            s.Add("1", "Bigdata");
            s.Add("2", "Java");
            Console.WriteLine("the elements in the sorted dictionary is");
            foreach (KeyValuePair<string, string> sd in s)
            {
                Console.Write(sd.Key + " " + sd.Value);
                Console.WriteLine();
            }
            Console.WriteLine("particular key is contained:"+s.ContainsKey("6"));
            Console.WriteLine("if the particular value is contained:"+s.ContainsValue("Haddop"));
            Console.ReadLine();
        }
    }
}
