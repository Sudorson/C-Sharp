using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingNumber
{

    class MissingNo
    {
        public void MissingArray(int[] intArray)
        {
            Array.Sort(intArray);
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                int j = (intArray[i + 1] - intArray[i]) - 1;
                if (j >= 1)
                {
                    while (j != 0)
                    {
                        Console.Write(++intArray[i]+" ");
                        j--;
                    }
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MissingNo missing = new MissingNo();
            missing.MissingArray(new int[] { 1, 5, 9 });
            Console.ReadKey();
        }

    }

   
}
