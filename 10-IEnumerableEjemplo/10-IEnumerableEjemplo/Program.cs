using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10_IEnumerableEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> nums = Enumerable.Empty<int>();
            for (int i = 0; i < 10; i++)
            {
                // https://stackoverflow.com/a/61022281
                nums = nums.Append(i);
            }
            Console.WriteLine("IEnumerable:");
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            
            ICollection<int> nums2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                nums2.Add(i);
            }
            Console.WriteLine("ICollection:");
            foreach (int n in nums2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
