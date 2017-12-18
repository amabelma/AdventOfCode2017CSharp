using System;
using System.IO;

namespace Day2P1.API
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get information from txt file
            string rawText = string.Empty;
            Console.Write("Retrieving data from text file... ");
            using(StreamReader reader = new StreamReader("../Day2P2Data.txt"))
            {
                rawText = reader.ReadToEnd();
            }
            
            if(rawText != string.Empty)
            {
                Console.WriteLine("Done.");
            }

            // Process information from txt file
            StringProcessor stringProcessor = new StringProcessor();
            int checksum = stringProcessor.ProcessString(rawText);

            // Output the results
            Console.WriteLine($"The checksum is {checksum}");
        }
    }
}
