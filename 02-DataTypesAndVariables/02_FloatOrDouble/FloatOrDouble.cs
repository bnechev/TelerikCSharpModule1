using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            float mina = float.MinValue;
            float maxa = float.MaxValue;
            double minb = double.MinValue;
            double maxb = double.MaxValue;
            Console.WriteLine("With Zeros Float minA: " + mina.ToString("0"));
            Console.WriteLine("Origianl Value Float minB: " + mina);
            Console.WriteLine("With Zeros Float maxA: " + maxa.ToString("0"));
            Console.WriteLine("Origianl Value Float maxA: " + maxa);
            Console.WriteLine("With Zeros Double minB: " + minb.ToString("0"));
            Console.WriteLine("Origianl Value Double minB: " + minb);
            Console.WriteLine("With Zeros Double maxB: " + maxb.ToString("0"));
            Console.WriteLine("Origianl Value Double maxB: " + maxb);
        }
    }
}