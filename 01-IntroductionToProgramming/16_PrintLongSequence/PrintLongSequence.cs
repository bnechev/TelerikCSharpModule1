﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 1001; i++)
            {
                int a = i;
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    a = a * (-1);
                    Console.WriteLine(a);
                }
            }
        }
    }
}
