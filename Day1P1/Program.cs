using System;
using System.IO;

namespace Day1P1
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationResult result = new OperationResult();
            StringProcessor stringProcessor = new StringProcessor();

            Console.WriteLine("Processing file...");
            string userString;
            using (StreamReader reader = new StreamReader("C:/Users/mark.amabeli/Desktop/AdventOfCode/Day1P1/Day1P1Input.txt"))
            {
                userString = reader.ReadLine();
            }

            result = stringProcessor.ProcessString(userString);

            if (result.HadValidInput == true)
            {
                Console.WriteLine($"The answer for the given input is {result.Message}");
            }

            if (result.HadValidInput == false)
            {
                Console.WriteLine($"There was an error with the input: {result.Message}");
            }
        }
    }
}
