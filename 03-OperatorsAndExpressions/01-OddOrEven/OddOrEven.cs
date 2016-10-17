using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int n = Math.Abs(i);
            if (n % 2 == 0)
            {
                Console.WriteLine("even {0}", i);
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("odd {0}", i);
            }
        }
    }
}
