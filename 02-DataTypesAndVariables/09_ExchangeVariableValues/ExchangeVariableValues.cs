﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
