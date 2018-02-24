using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class ICollection
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("JAN");
            l.Add("FEB");
            l.Add("MAR");
            l.Add("APR");
            l.Add("MAY");
            
            foreach(string s in l)
            {
                Console.Write(s + " ");
            }
            ICollection<string> i = (ICollection<string>)l;
            Console.WriteLine("count is:"+i.Count());
            Console.WriteLine("if particular element is contained or not:" + i.Contains("JUN"));
            Console.WriteLine("element remove:" +i.Remove("MAY"));
            Console.ReadLine();
        }
    }
}
