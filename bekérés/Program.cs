using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bekérés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy számolt: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 9 == 0) 
            {
                Console.WriteLine("Osztható 9-el és 3-al is");
            }
            else if (a % 4 == 0)
             {
                Console.WriteLine("Osztható 4-el");
            }
            else if (a % 3 == 0) 
            {
                Console.WriteLine("Osztható 3-al");
            }
            Console.ReadKey();
        }
    }
}