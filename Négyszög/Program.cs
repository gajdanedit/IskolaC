using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace negyszog
{
    internal class Program
    {
        class negyszog
        {
            //osztályváltozók
            private int a;
            private int b;
            private int terulet;
            private int kerulet;

            //konstruktorok
            public negyszog() { }

            public negyszog(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public negyszog(int a)
            { 
              this.a = a;
              this.b = a;
            }
            //metódusok
            public void setA(int a) 
            {
                if (a > 1000)
                {
                    Console.WriteLine("Az oldal nem lehet nagyobb, mint 1000!");
                }else
                this.a = a; 
            }
            public void setB(int b) { this.b = b; }

            public int getA() { return this.a; }
            public int getB() { return this.b; }

            public void setTerulet() 
            {
                this.terulet = this.a * this.b;
            }
            public int getTerulet() 
            {
                return this.terulet;
            }
            public void setKerulet()
            {
                this.kerulet = 2 * (this.a + this.b);
            }
            public int getKerulet()
            {
                return this.kerulet;
            }
        }
        enum nyomtat { oldal, kerter}
        static void Main(string[] args)
        {
            //első példa
            negyszog n1= new negyszog();
            kiir(n1, nyomtat.oldal);

            n1.setA(5);
            n1.setB(6);

            kiir(n1, nyomtat.oldal);

            n1.setTerulet();
            n1.setKerulet();
            kiir(n1, nyomtat.kerter);


            //2. példa
            negyszog n2= new negyszog(6, 2);

            kiir(n2, nyomtat.oldal);
            n2.setTerulet();
            n2.setKerulet();
            kiir(n2, nyomtat.kerter);

            //3. negyzet pelda
            negyszog n3 = new negyszog(6);

            kiir(n3, nyomtat.oldal);
            n3.setTerulet();
            n3.setKerulet();
            kiir(n3, nyomtat.kerter);

            Console.ReadKey();
        }
        static private void kiir(negyszog obj, nyomtat v)
        {
            if (v == nyomtat.oldal)
            {
                Console.WriteLine($"Az négyszög oldalai: a = {obj.getA()}, b = {obj.getB()}");
            }
            else
                Console.WriteLine($"Az négyszög területe = {obj.getTerulet()}, kerülete = {obj.getKerulet()}");
        }
    }
}
