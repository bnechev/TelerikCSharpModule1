using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = Math.Pow((x * x + y * y), 0.5);
            if (r > 2)
            {
                Console.WriteLine("no {0:F2}", r);
            }
            else
            {
                Console.WriteLine("yes {0:F2}", r);
            }
        }
    }
}
