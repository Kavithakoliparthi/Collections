using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class Stackdemo
    {
        static void Main(string[] args)
        {
            Stack<string> s = new Stack<string>();
            s.Push("dot");
            s.Push("net");
            s.Push("language");
            s.Push("net");
            foreach (string obj in s)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.WriteLine("retrived element:" + s.Peek());
            Console.WriteLine("removed element:" + s.Pop());
            Console.WriteLine("the elements in the stack are:");

            foreach (string s1 in s)
            {
                Console.Write(s1 + " ");
            }
            Console.WriteLine("the elemnts in the stack are:" + s.Count);
            Console.ReadLine();
        }
    }
}
