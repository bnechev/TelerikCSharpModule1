using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            if (n <= 1)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        temp = 1;
                    }
                }
                if (temp == 1)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    Console.WriteLine("true");
                }
            }           
        }
    }
}
