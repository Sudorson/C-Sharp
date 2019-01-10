using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();
            foreach (var num in array)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
