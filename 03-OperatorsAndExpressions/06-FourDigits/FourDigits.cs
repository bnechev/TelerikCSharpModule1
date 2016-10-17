using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigits
{
    class FourDigits
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());
            int d = abcd % 10;
            abcd = abcd / 10;
            int c = abcd % 10;
            abcd = abcd / 10;
            int b = abcd % 10;
            abcd = abcd / 10;
            int a = abcd % 10;
            Console.WriteLine("{0}", a + b + c + d);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
