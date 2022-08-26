﻿using System.Linq;

namespace _01_ValidadorDeRangos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 0;
            //Declaro un array y lo inicializo con un largo de 10 elementos
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un  número");
                string input = Console.ReadLine();
                int numeroIngresado = 0;
                bool esEntero = int.TryParse(input, out numeroIngresado);
                while (!esEntero || !Validador.Validar(numeroIngresado,-100,100))
                {
                    Console.WriteLine("Error, ingrese unicamente un número entre -100 y 100");
                    input = Console.ReadLine();
                    esEntero = int.TryParse(input, out numeroIngresado);
                }
                numeros[i] = (numeroIngresado);
                totalNumeros++;
            }
            int posicion = 0;
            foreach (var item in numeros)
            {
                Console.WriteLine($"El número en la posición {posicion} es {item}");
                posicion++;
            }
            Console.WriteLine($"El número más grande es {numeros.Max()}");
            Console.WriteLine($"El número más chico es {numeros.Min()}");
            Console.WriteLine($"El promedio de los números ingresados es {numeros.Average()}");
        }
    }
}