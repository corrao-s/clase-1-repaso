using System;

namespace Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Ingrese el numero de ejercicio que desea ejecutar, para salir ingrese 0");
                int ejercicio = int.Parse(Console.ReadLine());
                switch (ejercicio)
                {
                    case 0:
                        return;
                    case 1:
                        Ejercicio1.Ejecutar();
                        break;
                    case 2:
                        Ejercicio2.Ejecutar();
                        break;
                    case 3:
                        Ejercicio3.EjecutarConLista();
                        break;
                    default:
                        Console.WriteLine("El ejercicio seleccionado no existe");
                        break;
                }
                Console.WriteLine("Para continuar pulse cualquier tecla");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
