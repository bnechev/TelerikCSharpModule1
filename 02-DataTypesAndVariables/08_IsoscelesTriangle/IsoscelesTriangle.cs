using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            int unicode = 169;
            char character = (char)unicode;
            string text = character.ToString();
            Console.WriteLine("  " + " " + text);
            Console.WriteLine("  " + text + " " + text);
            Console.WriteLine(" " + text + " " + " " + " " + text);
            Console.WriteLine(text + " " + text + " " + text + " " + text);
        }
    }
}
