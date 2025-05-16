using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un año");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a%4==0 && a % 100 == 0 && a%400==0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
        }
    }
}
