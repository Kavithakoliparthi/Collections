using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collec
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> d = new Dictionary<string, object>();
            d.Add("EId", 104);
            d.Add("EName", "lmn");
            d.Add("EPhone", 9741924799);
            d.Add("EGmail", "lmn@gmail.com");
            if (d.ContainsKey("EAge"))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            foreach (string obj in d.Keys)
            {
                Console.WriteLine(obj + " : " + d[obj]);
            }

            Console.ReadLine();
        }

    }
}
