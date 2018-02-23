using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> h = new HashSet<string>();
            h.Add("welcome");
            h.Add("hai");
            h.Add("hello");
            h.Add("test");
            h.Add("welcome");   //duplicate elements not added
            foreach (string obj in h)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
}
