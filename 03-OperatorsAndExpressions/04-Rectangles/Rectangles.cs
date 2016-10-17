using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = w * h;
            double perimeter = (w + h) * 2;
            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}
