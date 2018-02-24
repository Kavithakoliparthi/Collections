//IList
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class IListDemo
    {
        static void Display(IList<int> list)
        {
            Console.WriteLine("the array elements Count is:", list.Count);
            foreach (int value in list)
            {
                Console.WriteLine(value);
            }
        }
        static void Display1(IList<string> list)
        {
            Console.WriteLine("The list elements Count is:", list.Count);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
        
        static void Main()
        {
            int[] array = new int[3];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            Display(array);
            
            List<string> list = new List<string>();
            list.Add("Jan");
            list.Add("Feb");
            list.Add("Mar");
            list.Add("Apr");
            Display1(list);
            Console.WriteLine("First elemnt is:"+array.First<int>());
            Console.WriteLine("hahscode value is :"+array.GetHashCode());
            Console.WriteLine("array type is:"+array.GetType());
            Console.WriteLine("no.of elements in the array:"+array.Length);
            Console.WriteLine(array.IsSynchronized);
            Console.WriteLine(array.IsFixedSize);
            Console.WriteLine(array.IsReadOnly);
            Console.ReadLine();
        }
    }
}
//List and arrays are implemented by IList