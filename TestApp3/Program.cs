﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char op;

            if (args.Length == 0)
            {
                Console.WriteLine("Az első szám: ");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("A második szám: ");               
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("A művelet(+, -, *, /: ");
                op = Convert.ToChar(Console.Read());
            }
        }
    }
}
