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
            var eachLine = Regex.Split(input.Trim(), @"\n");

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

                for(int i=0; i<lineNumbers.Count; i++)
                {
                    for(int j=0; j<lineNumbers.Count; j++)
                    {
                        if(lineNumbers[j]%lineNumbers[i] == 0 && lineNumbers[j] > lineNumbers[i])
                        {
                            int lineValue = lineNumbers[j]/lineNumbers[i];
                            // store into array
                            runningDifferences.Add(lineValue);
                        }
                    }
                }
                
            }

            int result = runningDifferences.Sum();

            return result;
        }
    }
}