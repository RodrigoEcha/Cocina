using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RodrigoEchandia
{
    class Program
    {
        static void Main(string[] args)
        {

            Taza taza = new Taza("Fredd",10);
            Console.WriteLine(taza.cantidad);
            Console.WriteLine(taza.capacidad);

            taza.Agregar(5);
            Console.WriteLine(taza.cantidad);
            Console.WriteLine(taza.capacidad);

            taza.Agregar(20);
            Console.WriteLine(taza.cantidad);
            Console.WriteLine(taza.capacidad);



            Console.ReadLine();
        }
    }
}
