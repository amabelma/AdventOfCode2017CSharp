using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Day1P1
{
    public class StringProcessor
    {
        public OperationResult ProcessString(string input)
        {
            // remove any spaces in front or back of input
            input = input.Trim();
            
            OperationResult result = new OperationResult();

            // ensure the string is not null or empty
            if (input == null || input.Length <= 0)
            {
                result.HadValidInput = false;
                result.Message = "Input must be a string of at least one number.";
                return result;
            }

            // ensure the string is all integers
            var inputValidator = new Regex("[^0123456789]");
            var invalidCharacters = inputValidator.Matches(input);
            if (invalidCharacters.Count > 0)
            {
                result.HadValidInput = false;
                result.Message = "Input must be a string that contains only numbers. Letters and special characters not permitted.";
                return result;
            }

            // If the string has only one digit, the result should be 0
            if (input.Length == 1)
            {
                result.HadValidInput = true;
                result.Message = "0";
                return result;
            }

            List<int> toSum = new List<int>();
            List<int> test = new List<int>();
            input.ToList().ForEach(v => test.Add(int.Parse(v.ToString())));
            int[] test2 = test.ToArray();

            // process the string to get the results
            for (int i=0; i < test2.Length; i++)
            {
                int interval = test2.Length/2;
                int j = i + interval;
                if(j > test2.Length-1)
                {
                    j -= test2.Length;
                }

                if (test2[i] == test2[j])
                {
                    toSum.Add(test2[i]);
                }
            }

            // Sum the values that satisfied the conditions
            int summationValue = toSum.Sum();

            // Populate the fields of the return object
            result.HadValidInput = true;
            result.Message = summationValue.ToString();

            return result;
        }
    }
}