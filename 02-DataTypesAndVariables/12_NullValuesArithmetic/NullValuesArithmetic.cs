using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? someInteger = null;
            Console.WriteLine(
              "This is the integer with Null value -> "
                + someInteger);
            someInteger = 5;
            Console.WriteLine(
              "This is the integer with value 5 -> "
                + someInteger);

            double? someDouble = null;
            Console.WriteLine(
              "\n\nThis is the real number with Null value -> "
              + someDouble);
            someDouble = 2.5;
            Console.WriteLine(
              "This is the real number with value 5 -> "
                + someDouble);
        }
    }
}
