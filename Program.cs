using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[12, 30];
            setMatrix(data);

            kiirMatrix(data);
            Hofokszamitas afok = new Hofokszamitas(data);
            afok.szamitas();
            prLegmelegebbNap(afok);
            prLeghidegebbNap(afok);
            prLegmelegebbHonap(afok);
            prLeghidegebbHonap(afok);
            Console.ReadKey();
        }


        private static void prOtMinusz(Hofokszamitas p)
        {
            NapiAdat[] napiAdats = new NapiAdat[5];
            napiAdats = p.getOtMinusz();

            if (napiAdats[0].hofok < 0 )
            {
                Console.WriteLine("Az öt összefüggő mínuszos nap a következő: ");
                for (int i = 0; i < napiAdats.Length; i++)
                    Console.WriteLine("{0} {1}: {2}", napiAdats[i].honap, napiAdats[i].nap, napiAdats[i].hofok);
            }
            else 
            {
                Console.WriteLine("Nem volt 5 mínuszos összefüggő nap");
            }
        }

        private static void prLeghidegebbHonap(Hofokszamitas afok)
        {
            HaviAdat adat = new HaviAdat();
            adat = afok.getHaviMin();
            Console.WriteLine("Az év leghidegebb napja: {0}: {1} fok", adat.honap, adat.hofok);
        }

        private static void prLegmelegebbHonap(Hofokszamitas afok)
        {
            HaviAdat adat = new HaviAdat();
            adat = afok.getHaviMin();

            Console.WriteLine("Az év legmelegebb napja: {0}: {1} fok", adat.honap, adat.hofok);
        }

        private static void prLeghidegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb napja: {0} {1}: {2} fok", afok.getNapiMin().honap, afok.getNapiMin().nap, afok.getNapiMin().hofok);
        }
        private static void prLegmelegebbNap(Hofokszamitas afok)
        {
            Console.WriteLine("Az év leghidegebb napja: {0} {1}: {2} fok", afok.getNapiMax().honap, afok.getNapiMax().nap, afok.getNapiMax().hofok);
        }


        private static void kiirMatrix(int[,] data) 
        {
            Console.WriteLine("\nAz éves hőmérséklet adatok:");
            for (int i= 0; i< data.GetLength(0); i++)
            {
                Console.Write("\n {0}. hónap:", i + 1);
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write("{0}, ", data[i, j]);
                }
            }
        }
        private static void setMatrix(int[,] data) 
        {
            int[,] minmax =
            {
                { -20, 5 },
                { -12 , 5 },
                { -7, 14 },
                { -2, 17 },
                { 10, 19 },
                { 18, 32 },
                { 25, 38 },
                { 25, 30 },
                {12, 25 },
                {5, 17 },
                {-7, 18 },
                {-10, 5 },
            };
            int mn = 0;
            int mx = 0;

            Random rn = new Random();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                mn = minmax[i, 0];
                mx= minmax[i, 1];
                for (int j = 0; j < data.GetLength(1); j++)
                    data[i,j] = rn.Next(minmax[i, 1]);

            }
            
        }

    }
}
