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
            string num = Convert.ToString(n, 2).PadLeft(32, '0');
            var array = num.ToCharArray();
            var temp3 = array[5];
            var temp4 = array[6];
            var temp5 = array[7];
            array[5] = array[26];
            array[6] = array[27];
            array[7] = array[28];
            array[26] = temp3;
            array[27] = temp4;
            array[28] = temp5;
            double converted = 0;
            for (int i = array.Length - 1, t = 0; i >= 0; i--, t++)
            {
                int temp = array[i] - 48;
                converted = converted + temp * Math.Pow(2, t);
            }
            Console.WriteLine(converted);
        }
    }
}