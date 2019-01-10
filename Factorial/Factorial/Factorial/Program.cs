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
            Console.WriteLine("Please enter the number ");
            int tangetNumber = Convert.ToInt32(Console.ReadLine());
            if (tangetNumber==0)
            {
                Console.WriteLine("Factorial Is 1");
            }
            else if (tangetNumber<0)
            {
                Console.WriteLine("please enter a positive number");
            }
            else 
            {
                Double factorial = 1;

                for (int i = tangetNumber; i >=1; i--)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine("Factorial of {0}={1}", tangetNumber, factorial);
            }
            Console.ReadKey();
        }
    }
}
