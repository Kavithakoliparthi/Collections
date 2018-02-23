using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            int[] a= new int[10];
            
           Console.Write("enter the input size array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[i])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Elements are sorted  in ascending order:");
            for (int k = 0; k < n; k++)
            {
                Console.Write("{0} ", a[k]);
            }
            Console.Write("\n");
            Console.Read();
        }
    }
}
