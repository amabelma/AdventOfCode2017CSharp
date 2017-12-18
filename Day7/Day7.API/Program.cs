using System;
using System.Collections.Generic;
using System.IO;

namespace Day7.API
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>();
            using(StreamReader reader = new StreamReader("../Day7Input.txt"))
            {
                while(!reader.EndOfStream)
                {
                    input.Add(reader.ReadLine());
                }
            }

            TowerSorter towerSorter = new TowerSorter();
            string baseValue = towerSorter.GetBaseValue(input);
            Console.WriteLine($"The base value is {baseValue}.");
        }
    }
}
