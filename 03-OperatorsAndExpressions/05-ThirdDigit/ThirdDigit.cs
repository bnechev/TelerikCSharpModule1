using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            N = N / 100;
            int thirdDigit = N % 10;
            if ( thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
