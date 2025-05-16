using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Tenis
    {
        static void Main(string[] args)
        {
            int puntos_j1 = 0;
            int puntos_j2 = 0;

            Console.WriteLine("Ingrese el nombre del jugador 1: ");
            string jugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2: ");
            string jugador2 = Console.ReadLine();

            Console.WriteLine("¿Cuantos puntos hizo el primer jugador en el set 1?");
            int set1_j1 = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos hizo el segundo jugador en el set 1?");
            int set1_j2 = int.Parse(Console.ReadLine());

            if (set1_j1 > set1_j2)
            {
                puntos_j1++;
            }
            else
            {
                puntos_j2++;
            }
            Console.Clear();

            Console.WriteLine("¿Cuantos puntos hizo el primer jugador en el set 2?");
            int set2_j1 = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos hizo el segundo jugador en el set 2?");
            int set2_j2 = int.Parse(Console.ReadLine());

            if (set2_j1 > set2_j2)
            {
                puntos_j1++;
            }
            else
            {
                puntos_j2++;
            }
            Console.Clear();

            Console.WriteLine("¿Cuantos puntos hizo el primer jugador en el set 3?");
            int set3_j1 = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos hizo el segundo jugador en el set 3?");
            int set3_j2 = int.Parse(Console.ReadLine());

            if (set3_j1 > set3_j2)
            {
                puntos_j1++;
            }
            else
            {
                puntos_j2++;
            }

            Console.Clear();

            Console.WriteLine($"Partido: {jugador1}, {jugador2}");
            Console.WriteLine($"Sets: ({set1_j1}, {set1_j2}) ; ({set2_j1}, {set2_j2}) ; ({set3_j1}, {set3_j2})");
            if (puntos_j1 > puntos_j2)
            {
                Console.WriteLine("El ganador es: " + jugador1);
            }
            else
            {
                Console.WriteLine("El ganador es: " + jugador2);
            }
        }
    }
}
