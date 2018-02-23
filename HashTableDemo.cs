using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("EId", 101);
            h.Add("EName", "pqr");
            h.Add("EDept", "accountant");
            h.Add("EGmail", "pqr@gmail.com");
            Console.WriteLine("the keys are:");
            foreach (Object obj in h.Keys)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("the values are:");
            foreach (Object obj in h.Values)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine("the key and value pairs are");
            foreach (Object obj in h.Keys)
            {
                Console.WriteLine(obj + ":" + h[obj]);
            }
            Console.ReadLine();
        }

    }
}
