using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _09_ListasAnidadas_Ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BenchmarkListas>();
        }
    }
}
