using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class QueueDemocs
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("java");
            q.Enqueue("dotnet");
            q.Enqueue("C");
            q.Enqueue("C++");
            q.Enqueue("languages");
            Console.WriteLine("the elements in the queue are:");
            foreach (string s in q)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine("the retrived element is:" + q.Peek());
            Console.WriteLine("the removed element is:" + q.Dequeue());
            Console.WriteLine("after retrieving and removing the elements in the queue are:");
            foreach (string s in q)
            {
                Console.Write(s + " ");
            }
            Console.ReadLine();
        }

    }
}
