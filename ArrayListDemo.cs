using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class ArrayListDemo
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();  
            Console.WriteLine("initially the array list capacity is:");
            Console.WriteLine(al.Capacity);
            al.Add(90);
            al.Add(20);
            al.Add(5);
            Console.WriteLine("after inserting elements the arraylist capacity is:");
            Console.WriteLine(al.Capacity);
            al.Add(null);
            al.Add("hi");
            al.Add(50);
            al.Add(20);
            Console.WriteLine(al.Capacity);
            Console.WriteLine("the arraylist elements are:");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

            al.Insert(3, 55);
            al.Insert(5, 45);
            al.Insert(6, 55);
            Console.WriteLine("after inserting new element the arraylist elements are:");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            al.Remove(50);
            al.RemoveAt(3);
            al.RemoveRange(3, 5);
            Console.WriteLine("after removing the arraylist elements are:");
            foreach (Object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.WriteLine("finally the arraylist capacity is:");
            Console.WriteLine(al.Capacity);
            al.Sort();
            Console.WriteLine("after sorting arraylist elements are:");
            for (int i = 0; i < al.Count; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("the array list elements count is:" + al.Count);
            al.Clear();
            Console.WriteLine("to clear the array list:" + al.Count);
            Console.ReadLine();
        }
    }
}
