using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArry = { 12, 18, 203, 589, 15, 158 };
            Array.Sort(numberArry);
            Console.WriteLine("Minimun Number Is={0}", numberArry[0]);
            Console.WriteLine("Maximum Number Is={0}", numberArry[numberArry.Length-1]);

            Console.ReadKey();
        }
    }
}
