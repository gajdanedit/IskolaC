using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimletek
{
    internal class CimletezOOP
    {
        private int a;
        private int[] lista = { 5, 10, 50, 100, 200, 500, 1000, 2000, 5000, 10000, 20000 };

        public CimletezOOP() { }
        public CimletezOOP(int a)
        {
            this.a = a;
        }

        public int getA() { return this.a; }

        public void setA(int a)
        {
            this.a = a;
            int mar = 0;
            for (int i = lista.Length - 1; i >= 0; i--)
            {
                while (a >= lista[i])
                {
                    a -= lista[i];
                    mar++;
                }
            }
            Console.WriteLine(mar);
        }
    }
}
