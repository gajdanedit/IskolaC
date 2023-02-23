using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
     class Kor
    {
        private int r;
        private double terulet;
        private double kerulet;

        public Kor() { }

        public Kor(int r){
        this.r = r;
        }
        public void setR(int r)
        {
            this.r = r;
        }

        public int getR() 
        {
            return this.r; 
        }
        public void setTerulet()
        {
            this.terulet = this.r*this.r*Math.PI;
        }
        public double getTerulet()
        {
            return this.terulet;
        }
        public double getKerulet()
        {
            return this.kerulet;
        }
        public void setKerulet()
        {
            this.kerulet = 2*this.r * Math.PI;
        }



    }
        internal class Program
    { 
        static void Main(string[] args)
        {
            Kor kor = new Kor();
            kor.setR(1);
            kor.setTerulet();
            kor.setKerulet();
            Console.WriteLine($"A kör területe: {kor.getTerulet()}, kerülete:, {kor.getKerulet()}");

            Console.ReadKey();
        }
    }
}
