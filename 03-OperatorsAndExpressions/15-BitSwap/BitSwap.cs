using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchange
{
    class BitExchange
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            string num = Convert.ToString(n, 2).PadLeft(32, '0');
            var array = num.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < k; i++)
            {
                var temp = array[p+i];
                array[p+i] = array[q+i];
                array[q+i] = temp;
            }
            double converted = 0;
            for (int i = array.Length - 1, t = array.Length-1; i >= 0; i--, t--)
            {
                int temp = array[i] - 48;
                converted = converted + temp * Math.Pow(2, t);
            }
            Console.WriteLine(converted);
        }
    }
}