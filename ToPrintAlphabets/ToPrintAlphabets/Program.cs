using System;


namespace SamplePrograms
{
    class Alphabets
    {
        public static void Main()
        {
            for (char i ='a'; i <= 'z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}