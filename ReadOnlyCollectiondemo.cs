//ReadOnly Collection
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class ReadOnlyCollectiondemo
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            //list.Add(6);
            //list.Add(8);
            ReadOnlyCollection<int> read = new ReadOnlyCollection<int>(list);
            foreach(int i in read)
            {
                Console.WriteLine("read:{0}", i);
            }
            Console.WriteLine();
            int count = read.Count;
            Console.WriteLine("Number of elements in the read-only Collection are:"+count);
            //Console.WriteLine("Number of distinct elements in the read-only collectio are:"+read.Distinct());
            Console.ReadLine();
        }
    }
}

//ReadOnly collection makes the array or list readonly