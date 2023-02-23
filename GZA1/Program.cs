using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GZA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            int max = 0;

            Console.Write("0 Vége az adatbevitelnek ");

            do
            {
                Console.Write("Kérem a/az " + max + ". adatot : ");
                tomb[max] = Convert.ToInt32(Console.ReadLine());
                max++;
            }   while (tomb[max - 1] != 0);
            max--;
            Boolean voltcsere;
            int i, j;
            do
            {
                voltcsere = false;
                for (int j = 0; j < max - 1; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tap = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tap;
                        voltcsere= true;
                    }
                }
            } while (voltcsere);

            for (j = 0;)
        }
    }
}
