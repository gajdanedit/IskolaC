using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HofokOOP
{
    struct NapiAdat 
    {
        public string honap; // Hónap neve
        public int nap; // Nap sorszáma
        public int hofok; // Napi hőmérséklet
    }
    
    struct HaviAdat 
    {
        public string honap; // Hónap neve
        public int hofok; // Hónap átlaghőmérséklete

    }
    internal class Hofokszamitas
    {
        //Osztályváltozók
        private int[,] adat = null; //Hőfokok tárolására
        private int[] haviAtlag = new int[12]; // Havi átlaghőfokok
        private NapiAdat napiMax,    // Legmagasabb hőmérsékletű napi adatai
            napiMin;    // Legalacsonyabb hőmérsékletű napi adatai

        private HaviAdat haviMax,    // Legmagasabb átlaghőmérsékletű hónap adatai
            haviMin;    // Legalacsonyabb átlaghőmérsékletű hónap adatai

        private NapiAdat[] otMinusz = new NapiAdat[5];  //Az öt mínuszos nap tömbje

        static string[] honapok = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "szeptember", "október", "november", "december" };

    
        //Konstruktorok
        public Hofokszamitas(int[,] p) 
        {
            this.adat = p;
        }
        // Eredményeket átadó metódusok
        public  NapiAdat getNapiMin() 
        {
            return this.napiMin;
        }
        public NapiAdat getNapiMax()
        {
            return this.napiMax;
        }
        public HaviAdat getHaviMin() 
        {
            return this.haviMin;
        }
        public HaviAdat getHaviMax() 
        {
            return this.haviMax;
        }
        public NapiAdat[] getOtMinusz() 
        {
            return this.otMinusz; 
        }

        // Számítások
        public void szamitas() 
        {
            // Legmelegebb és leghidegebb napok kiszámítása
            setNapiMaxMin();

            // Leghidegebb és legmelegebb átlaghőmérsékletű hónap kíiszámítása
            setHaviAtlag();
            setHaviMaxMin();
            // Folyamatos 5 mínuszos nap kiszámítása
        }

        private void setHaviAtlag()
        {
            int osszeg = 0; // Gyűjtés
            for (int i = 0; i < adat.GetLength(0); i++) //Hónapok
            {
                osszeg = 0;
                    for (int j = 0; j < adat.GetLength(1); j++)
                    {
                        osszeg += adat[i, j];
                        this.haviAtlag[i] = osszeg / adat.GetLength(1);
                    }
            }
        }

        private void setOtMinusz()
        {
            int mDb = 0;  // Ezzel szzámolom, hogy hanyadik mínuszos napon tartunk
            for (int i = 0; i < adat.GetLength(0); i++)
            {
                for (int j = 0; j < adat.GetLength(1); j++)
                {
                    if (this.adat[i,j] < 0) 
                    {
                        this.otMinusz[mDb].honap = honapok[i];
                        this.otMinusz[mDb].nap = j + 1;
                        this.otMinusz[mDb].hofok = this.adat[i,j];
                        mDb++;
                    }
                    else 
                    {
                        for (int k = 0; k < mDb + 1; k++)
                        {
                            this.otMinusz[k].honap = String.Empty;
                            this.otMinusz[k].nap = 0;
                            this.otMinusz[k].hofok = 0;
                        }
                        mDb = 0;
                    }
                }
            }
        }

   

        private void setHaviMaxMin()
        {
            int max = int.MinValue,
                maxInd = 0,
                min = int.MaxValue,
                minInd = 0;
            for (int i = 0; i < haviAtlag.Length; i++)
            {
                if (haviAtlag[i] > max) 
                {
                    max = this.haviAtlag[i];
                    maxInd = i;
                }
                else if (this.haviAtlag[i] < min) 
                {
                    min = this.haviAtlag[i];
                    minInd = i;
                }
            }
            // Erdedmények letárolása
            this.haviMax.hofok = max;
            this.haviMax.honap = honapok[maxInd];

            this.haviMax.hofok = min;
            this.haviMax.honap = honapok[minInd];
        }

        private void setNapiMaxMin()
        {
            int max = int.MinValue,
                maxI = 0,
                maxJ = 0,
                min = int.MaxValue,
                minI = 0,
                minJ = 0;
            for (int i = 0; i < adat.GetLength(0); i++)  //Hónapok ciklusa
            {
                for (int j = 0; j < adat.GetLength(1); j++)  //Napok ciklusa
                {
                    if (this.adat[i,j] > max) 
                    {
                        max = this.adat[i,j];
                        maxI = i;
                        maxJ = j;
                    }
                    if (this.adat[i, j] < min)
                    {
                        min = this.adat[i, j];
                        minI = i;
                        minJ = j;
                    }
                    // Eredmény átadása a tömbnek
                    this.napiMin.honap = honapok[maxI];
                    this.napiMax.nap = maxJ + 1; //Mivel nincs 0. nap
                    this.napiMax.hofok = max;

                    this.napiMin.honap = honapok[minI];
                    this.napiMax.nap = minJ + 1; //Mivel nincs 0. nap
                    this.napiMax.hofok = max;
                }
            }
        }
    }
}
