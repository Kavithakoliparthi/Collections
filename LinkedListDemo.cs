using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            l.AddLast(40);
            l.AddLast(45);
            l.AddLast(60);
            l.AddFirst(20);
            l.AddLast(50);
            Console.WriteLine("the linked list elements are:");
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            LinkedListNode<int> ln = l.Find(60);
            l.AddAfter(ln, 65);
            l.AddBefore(ln, 55);
            foreach (int i in l)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }

}
}
