using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomb01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tömb deklarálása
            int sor = 10;  //sorok száma
            int oszlop = 10;  //generált szám felső határa
            int alsohatar = 10;  //generált szám alsó határa
            int felsohatar = 1000;  //generált szám felső határa
            int[,] tomb = new int[sor,oszlop];
            Random rnd = new Random();

            //Tömb feltöltése véletlen számokkal
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0;j < sor; i++)
                    tomb[i,j] = rnd.Next(alsohatar, felsohatar);
            }

            //Tömb kiiratása
                
            for (int i = 0; i < sor; i++)
                    { 
                    for (int j = 0; j < oszlop; j++)
                    Console.Write(tomb[i,j]);
                    Console.WriteLine();
                    }
            //Tömb kiiratása máshogy 2
            foreach (int i in tomb)
                Console.WriteLine(i);
            Console.ReadKey();
            
        }
    }
}
