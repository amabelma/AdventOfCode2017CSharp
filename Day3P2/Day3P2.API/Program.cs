using System;
using System.IO;

namespace Day3P2.API
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValueFromFile = string.Empty;
            using(StreamReader reader = new StreamReader("../Day3P2Data.txt"))
            {
                inputValueFromFile = reader.ReadToEnd();
            }

            int inputValue = Convert.ToInt32(inputValueFromFile);
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            int returnValue = distanceCalculator.FindFirstHigherValueInSpiral(inputValue);

            Console.WriteLine($"The first value that exceeds the entered value of {inputValue} is {returnValue}.");

        }
    }
}
