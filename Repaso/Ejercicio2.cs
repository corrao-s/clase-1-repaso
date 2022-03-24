using System;
using System.Collections.Generic;
using System.Text;

namespace Repaso
{
    internal static class Ejercicio2
    {
        public static void Ejecutar()
        {
            int cantidadMayusculas = 0, cantidadMinusculas = 0, cantidadNumeros = 0, cantidadEspeciales = 0;
            string text;
            Console.WriteLine("Ingrese el texto a analizar");
            text = Console.ReadLine();
            foreach (char c in text)  //Por cada caracter que haya en la variable text voy a ejecuar el codigo entre las llaves y la variable c contiene el caracter actual
            {
                if (char.IsLetter(c))// Si el valor de la variable c es una letra
                {
                    if (char.IsUpper(c)) // y además es Mayuscula
                    {
                        cantidadMayusculas++; //Aumento la cantidad de Mayusculas
                    }
                    else // Si es una letra pero no es mayuscula
                    {
                        cantidadMinusculas++;
                    }
                }
                else // Si no es una letra
                {
                    if (char.IsDigit(c)) //Compruebo si es un Numero
                    {
                        cantidadNumeros++; //Aumento la cantidad de numeros
                    }
                    else // Si no es letra y no es numero 
                    {
                        cantidadEspeciales++; //Aumento la cantidad de Especiales
                    }
                }
            }
            //Una vez terminada de analizar la cadena de texto Imprimimos en la Consola el resultado

            Console.WriteLine(@$"
La cadena de texto contiene:
* {cantidadMayusculas} Letras en mayusculas.
* {cantidadMinusculas} Letras en minusculas.
* {cantidadNumeros} numeros.
* {cantidadEspeciales} caracteres especiales.");
        }
    }
}
