using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int num = int.Parse(Console.ReadLine());
            int menor = num;
            int posMenor = 1;

            Console.WriteLine("Ingrese el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 < menor)
            {
                menor = num2;
                posMenor = 2;
            }
            Console.WriteLine("Ingrese el tercer numero");
            int num3 = int.Parse(Console.ReadLine());
            if (num3 < menor)
            {
                menor = num3;
                posMenor = 3;
            }

            Console.WriteLine("Ingrese el cuarto numero");
            int num4 = int.Parse(Console.ReadLine());
            if (num4 < menor)
            {
                menor = num4;
                posMenor = 4;
            }

            Console.WriteLine("Ingrese el quinto numero");
            int num5 = int.Parse(Console.ReadLine());
            if (num5 < menor)
            {
                menor = num5;
                posMenor = 5;
            }

            Console.WriteLine($"El menor numero ingresado es: {menor} y esta en la posicion {posMenor}");
        }
    }
}
