using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _15_ReferenceObjectsInLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet p1 = new Pet("Raichu", 2);
            Pet p2 = new Pet("MeiMei", 3);
            List<Pet> pets = new();
            pets.Add(p1);
            pets.Add(p2);

            var element0 = pets.ElementAt(0);
            var element2 = pets.ElementAt(1);

            element0._name = "Raichu2";
            Console.WriteLine(element0._name);
            Console.WriteLine(p1._name);
            //Console.WriteLine(element0 == p1);
            //Console.WriteLine(element2 == p2);
        }
    }
}
