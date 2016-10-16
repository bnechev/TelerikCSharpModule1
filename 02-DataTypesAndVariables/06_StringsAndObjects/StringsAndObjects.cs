using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string h = "Hello";
            string w = "World";
            object a = h + " " + w;
            string all = a.ToString();
            Console.WriteLine(all);
        }
    }
}
