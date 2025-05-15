using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer nombre y libreta");
           string nombre1 = Convert.ToString(Console.ReadLine());
            int libreta1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el segundo nombre y libreta");
            string nombre2 = Convert.ToString(Console.ReadLine());
            int libreta2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer nombre y libreta");
            string nombre3 = Convert.ToString(Console.ReadLine());
            int libreta3 = int.Parse(Console.ReadLine());

            if (libreta1 > libreta2)
            {
                string auxN = nombre1;
                int auxL = libreta1;
                nombre1 = nombre2;
                libreta1 = libreta2;
                nombre2 = auxN;
                libreta2 = auxL;
            }
           
            if (libreta1 > libreta3)
            {
                string auxN = nombre1;
                int auxL = libreta1;
                nombre1 = nombre3;
                libreta1 = libreta3;
                nombre3 = auxN;
                libreta3 = auxL;
            }

            if (libreta2 > libreta3)
            {
                string auxN = nombre2;
                int auxL = libreta2;
                nombre2 = nombre3;
                libreta2 = libreta3;
                nombre3 = auxN;
                libreta3 = auxL;
            }

            Console.WriteLine("Lista ordenada por libreta:");
            Console.WriteLine($"Nro: {libreta1} - Alumno: {nombre1}");
            Console.WriteLine($"Nro: {libreta2} - Alumno: {nombre2}");
            Console.WriteLine($"Nro: {libreta3} - Alumno: {nombre3}");
        }
    }
}
