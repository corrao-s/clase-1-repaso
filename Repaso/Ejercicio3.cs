using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repaso
{
    internal static class Ejercicio3
    {
        public static void EjecutarConLista()
        {
            List<int> listaNumeros = new List<int>();
            Console.WriteLine("Ingrese los numeros que desee, cuando quiera parar ingrese un numero negativo");
            int numero = int.Parse(Console.ReadLine());
            while (numero >= 0)
            {
                listaNumeros.Add(numero);
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($@"
* El maximo numero ingresado es: {listaNumeros.Max()}
* El minimo numero ingresado es: {listaNumeros.Min()}
* El promedio de los numeros ingresados es: {listaNumeros.Average()}");

        }
        public static void EjecutarSinLista()
        {
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma = 0;
            int cantidad = 0;
            Console.WriteLine("Ingrese los numeros que desee, cuando quiera parar ingrese un numero negativo");
            int numero = int.Parse(Console.ReadLine());
            while (numero >= 0)
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
                if (numero > maximo)
                {
                    maximo = numero;
                }
                suma += numero;
                cantidad++;
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($@"
* El maximo numero ingresado es: {maximo}
* El minimo numero ingresado es: {minimo}
* El promedio de los numeros ingresados es: {suma*1.0/cantidad}");
        }
    }
}
