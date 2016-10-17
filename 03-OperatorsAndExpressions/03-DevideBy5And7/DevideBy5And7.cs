using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideBy5And7
{
    class DevideBy5And7
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 5 == 0 && n % 7 == 0)
            {
                Console.WriteLine("true {0}", n);
            }
            else
            {
                Console.WriteLine("false {0}", n);
            }
        }
    }
}
