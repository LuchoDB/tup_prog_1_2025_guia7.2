using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int condicion;
            int n1, n2, n3;
            float prom;

            Console.WriteLine("Ingrese la nota minima para promocionar: ");
            condicion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del primer examen: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo examen: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del tercer examen: ");
            n3 = int.Parse(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3;

            if (prom >= condicion)
            {
                Console.WriteLine("El alumno promociona");
            }
            else
            {
                Console.WriteLine("El alumno rinde final");
            }
        }
    }
}
