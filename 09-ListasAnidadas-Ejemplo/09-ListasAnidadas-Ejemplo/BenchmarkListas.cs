using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System;

namespace _09_ListasAnidadas_Ejemplo
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.Declared)]
    [RankColumn]
    public class BenchmarkListas
    {
        public List<object> _listaPadre;
        public BenchmarkListas()
        {
            _listaPadre = new()
            {
                new List<object>()
                {
                    1,2,3,4,5,6,7,8,9,10
                },
                new List<object>()
                {
                    11,12,13,14,15,16,17,18,19,20
                }
            };
        }
        [Benchmark]
        public void ClearSoloListaPadre()
        {
            _listaPadre.Clear();
        }
        [Benchmark]
        public void ClearManualIterativo()
        {

            foreach (List<object> listaAnidada in _listaPadre)
            {
                listaAnidada.Clear();
            }
            _listaPadre.Clear();
        }
    }
}
