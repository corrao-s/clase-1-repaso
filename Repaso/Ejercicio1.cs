using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    internal static class Ejercicio1
    {
        public static void Ejecutar()
        {
            int a, b;
            Console.WriteLine("Ingrese el número A:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número B:");
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"A y B son iguales: {a}");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"A es mayor que B  {a} > {b}");
                }
                else
                {
                    Console.WriteLine($"B es mayor que A  {b} > {a}");
                }
            }
        }
    }
}
