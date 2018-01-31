using System;
using System.Collections.Generic;

namespace KWIC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do not add <.txt> extension to the input and output file names.");
            Console.WriteLine("Insert input file name:");
            string input = Console.ReadLine();
            Console.WriteLine("Insert output file name:");
            string output = Console.ReadLine();

            Input.Parse(input);

            CircularShifter.Setup();
            Alphabetizer.AlphaSort();
            Output.Print(output);
            
        }
    }
}
