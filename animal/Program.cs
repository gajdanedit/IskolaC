using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        enum Animal { Cat = 2, Dog = 5, Tiger, Wolf};
    static void Main(string[] args)
        {
            Animal a = Animal.Cat;
            Animal b = Animal.Dog;

            //Értéktípusú változó nulla értéke  
            int c = 0;
            string s = "";
            //
            int? x = null;

            if (a != b) 
            {
                Console.WriteLine("a macska nem kutya");
            }
            Console.WriteLine("Macska indexe: {0}", (int)Animal.Cat);
            Console.WriteLine("Kutya indexe: {0}", (int)Animal.Dog);
            Console.WriteLine("Tigris indexe: {0}", (int)Animal.Tiger);
            Console.ReadKey();
        }
    }
}
