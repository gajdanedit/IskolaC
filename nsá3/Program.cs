using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsá3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("A: {0}", c);
                c = c * a;
                Console.WriteLine("A: {0}", c);
            }
            Console.WriteLine("A hatvány: {0}", c);
            Console.ReadKey();
        }
    }
}
