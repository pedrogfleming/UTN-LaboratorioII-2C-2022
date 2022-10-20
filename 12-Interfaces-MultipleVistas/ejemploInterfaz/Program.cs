using Borrador;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ejemploInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new();
            numeros.Add(1);
            numeros.Add(2);
            numeros.Add(-3);
            ContadorDeNumeros contador = new ContadorDeNumeros();
            IEnumerable<int> positivos =  contador.filtrarPositivos(numeros);
            List<int> resultadoFiltrado = positivos.ToList();
            resultadoFiltrado.Add(5);
            
            foreach (int n in contador.filtrarPositivos(resultadoFiltrado))
            {
                Console.WriteLine(n);
            }
        }
    }
}
