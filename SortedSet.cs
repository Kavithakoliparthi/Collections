using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class SortedSet
    {
        static void Main(string[] args)
        {
            SortedSet<string> h = new SortedSet<string>();
            h.Add("welcome");
            h.Add("hai");
            h.Add("hello");
            h.Add("test");
            h.Add("welcome");   //duplicate elements not added
            Console.WriteLine("initially the set elements are:");
            foreach (string obj in h)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("the removed element is:"+h.RemoveWhere(element => element.StartsWith("w")));
            Console.WriteLine("after removing the set elements are:");
            foreach (string obj in h)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(h.AsParallel<string>());
            Console.WriteLine(h.Contains<string>("language"));
            Console.ReadLine();
        }
    }
}
