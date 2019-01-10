using System;
using System.Collections.Generic;
using System.Linq;


namespace SamplePrograms
{
    class ReverseCharacters
    {
        public static void Main()
        {
            // Prompt the user to enter the string
            Console.WriteLine("Please enter your string");


            // Read the user string from console
            string UserString = Console.ReadLine();


            // The simple way to reverse a string is to use
            // the built-in .net framework Reverse() function
            List<char> StringCharacters = UserString.Reverse().ToList();

            // Finally print each character from the collection
            foreach (char c in StringCharacters)
            {
                Console.Write(c);
            }


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}