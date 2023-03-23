using Cimletek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletezesOOP
{
    internal class CimletOOP
    {
        static void Main(string[] args) 
        {
            CimletezOOP c1 = new CimletezOOP();
            Console.WriteLine("Add meg a pénzt!!!!!!!!! ");
            int penz = Convert.ToInt32(Console.ReadLine());
            c1.setA(penz);
            Console.ReadLine();
        }
    }
}
