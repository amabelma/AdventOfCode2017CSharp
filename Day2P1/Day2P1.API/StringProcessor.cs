using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day2P1
{
    public class StringProcessor
    {
        public int ProcessString(string input)
        {
            // Split the input by line
            var eachLine = Regex.Split(input.Trim(), @"\r\n");

            var runningDifferences = new List<int>();
            foreach(string line in eachLine)
            {
                // separate by tabs or spaces
                var lineElements = Regex.Split(line, @"\t");
                var lineNumbers = new List<int>();

                // convert each to numbers
                foreach(string element in lineElements)
                {
                    lineNumbers.Add(Convert.ToInt32(element));
                }

                // calculate Max - Min
                int max = lineNumbers.Max();
                int min = lineNumbers.Min();
                int lineValue = max - min;

                // store into array
                runningDifferences.Add(lineValue);
            }

            int result = runningDifferences.Sum();

            return result;
        }
    }
}