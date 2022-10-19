using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _13_LINQ_Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new()
            {
                "Raichu",
                "Bulbazor",
                "Rafael"
            };
            var result = words.Where(x => x.Contains("Raichu"));
            Console.WriteLine(result.ToList());
        }
    }
}
