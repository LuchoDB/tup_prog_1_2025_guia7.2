using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("El numero es cero");
            }
            else
            {
                Console.WriteLine("El numero es positivo");
            }
        }
    }
}
