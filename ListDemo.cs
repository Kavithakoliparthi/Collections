using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            List<char> l = new List<char>();
            l.Add('h');
            l.Add('e');
            l.Add('l');
            l.Add('l');
            l.Add('o');
            foreach (Object obj in l)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
        }
    }
}
