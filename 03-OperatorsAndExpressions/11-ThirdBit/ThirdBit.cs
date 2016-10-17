using System;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n / 2;
            n = n / 2;
            n = n / 2;
            n = n % 2;
            Console.WriteLine(n);
        }
    }
}
