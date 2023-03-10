using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlaghomerseklet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[5, 10];
            for (int i =0; i <5; i++) 
            {
                for (int j = 0 ; j < 10; j++) 
                {
                    Console.WriteLine("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            #region Függvényekkel való használata
            Console.WriteLine("Ez a függvénnyel létrehozott mátrix: ");
            int[,] ezisegymatrix
        }
    }
}
