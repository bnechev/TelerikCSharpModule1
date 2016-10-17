﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double triangle = Math.Pow((x-1) * (x-1) + (y-1) * (y-1), 0.5);
            if (triangle <= 1.5)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }
            if ( x >= -1 && x <= 5 && y >= -1 && y <= 1)
            {
                Console.Write("inside rectangle");
            }
            else
            {
                Console.Write("outside rectangle");
            }
        }
    }
}
