# 1ra Clase - Repaso y Diagnostico
Durante esta clase estuvimos repasando algunos conceptos vistos en los años anteriores y realizando algunos ejercicios practicos con el objetivo de revisar los siguientes conceptos:
* Manejo de la Consola (Lectura y Escritura de Datos)
* Estructuras de Control (Condicional y Repetitivas)
* Tipos de datos y Conversion entre Enteros y Cadenas de Texto
* Arreglos y Colecciones

Para ello se propuso la realizacion de 3 ejercicios.

## Ejercicio 1 - ¿Cual es mayor?

Dados dos numeros enteros A y B ingresados por el usuario mediante la consola,
el programa deberá indicarle al usuario, si los numeros son iguales o cual de ellos es mayor

Ejemplo de la salida de la Consola:
```
Ingrese el número A:
1

Ingrese el número B:
8

B es mayor que A  8 > 1
```
## Ejercicio 2 - Contar Caracteres
Dada una cadena de texto ingresada por el usuario utilizando la consola,
el programa debe determinar:
* La cantidad de letras en Mayusculas.
* La cantidad de letras en Minusculas.
* La cantidad de numeros.
* La cantidad de caracteres especiales.

Ejemplo de salida de la Consola:
```
Hello World!
Ingrese el texto a analizar
Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.

La cadena de texto contiene:
* 14 Letras en mayusculas.
* 453 Letras en minusculas.
* 8 numeros.
* 99 caracteres especiales.
```

### Ayuda
Para determinar si un caracter es letra, mayuscula, minuscula o numero puede utilizar las siguientes funciones de C#
```C#
// c es una variable de tipo char
char.IsLetter(c);
char.IsUpper(c);
char.IsLowwer(c);
char.IsDigit(c);
```

## Ejercicio 3 - Muchos enteros
El programa debe permitir al usuario ingresar numeros enteros hasta que encuentre un numero negativo.
Una vez finalizada la carga de numeros, el programa deberá informar:
* El mayor numero ingresado.
* El menor numero ingresado.
* El promedio de los numeros ingresados.

Ejemplo de salida de la Consola:
```
Hello World!
Ingrese los numeros que desee, cuando quiera parar ingrese un numero negativo
1
2
3
4
5
6
7
8
9
10
-1

* El maximo numero ingresado es: 10
* El minimo numero ingresado es: 1
* El promedio de los numeros ingresados es: 5,5
```
