﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rovidforma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
             int b = 20;
            int c = 30;
            int d = 40;

            Console.WriteLine("a++ = {0}", a++);
            Console.WriteLine("++a = {0}", ++a);
            Console.WriteLine("b-- = {0}", b--);
            Console.WriteLine("--b = {0}", --b);
            
            Console.ReadKey();
        }
    }
}

