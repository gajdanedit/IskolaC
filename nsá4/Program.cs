﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsá4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            while(a>=20)
                a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            Console.Write("START");

            Console.ReadKey();
        }
    }
}
