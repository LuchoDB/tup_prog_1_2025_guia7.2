using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero");
            int n1 = int.Parse(Console.ReadLine());
            int grande = n1;

            Console.WriteLine("Ingrese el segundo numero");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 > grande)
            {
                grande = n2;
            }
            Console.WriteLine("Ingrese el tercer numero");
            int n3 = int.Parse(Console.ReadLine());
            if (n3 > grande)
            {
                grande = n3;
            }

            Console.WriteLine("Ingrese el cuarto numero");
            int n4 = int.Parse(Console.ReadLine());
            if (n4 > grande)
            {
                grande = n4;
            }

            Console.WriteLine("Ingrese el quinto numero");
            int n5 = int.Parse(Console.ReadLine());
            if (n5 > grande)
            {
                grande = n5;
            }

            Console.WriteLine($"El mayor numero ingresado es: {grande}");
        }
    }
}
