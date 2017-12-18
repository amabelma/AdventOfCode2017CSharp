using System;
using System.IO;

namespace Day3P1.API
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValueFromFile = string.Empty;
            using(StreamReader reader = new StreamReader("../Day3P1Data.txt"))
            {
                inputValueFromFile = reader.ReadToEnd();
            }

            int inputValue = Convert.ToInt32(inputValueFromFile);
            DistanceCalculator distanceCalculator = new DistanceCalculator();
            int returnValue = distanceCalculator.CalculateDistanceToTravel(inputValue);

            Console.WriteLine($"The shortest distance for {inputValue} is {returnValue}.");

        }
    }
}
