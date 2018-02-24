using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<string, string> s = new SortedList<string, string>();
            s.Add("9", "languages");
            s.Add("1", "Bigdata");
            s.Add("8", "AI");
            s.Add("2", "Java");
            s.Add("4", "Haddop");
            s.Add("6", "CSharp");
            s.Add("5", "Andriod");
            s.Add("3", "python");
            Console.WriteLine("the elements in the sorted dictionary is");
            foreach (KeyValuePair<string, string> sd in s)
            {
                Console.Write(sd.Key + " " + sd.Value);
                Console.WriteLine();
            }
            Console.WriteLine(s.AsParallel());
            
            Console.ReadLine();
        }
    }
}
