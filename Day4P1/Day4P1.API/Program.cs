using System;
using System.IO;
using System.Collections.Generic;

namespace Day4P1.API
{
    class Program
    {
        static void Main(string[] args)
        {
            var passwordList = new List<string>();
            using(StreamReader reader = new StreamReader("../Day4P1Data.txt"))
            {
                while(!reader.EndOfStream)
                {
                    passwordList.Add(reader.ReadLine());
                }
            }

            PasswordValidator passwordValidator = new PasswordValidator();
            int NumberOfValidPasswords = passwordValidator.ValidPasswordCount(passwordList);

            Console.WriteLine($"Of the {passwordList.Count} passwords provided, {NumberOfValidPasswords} were valid.");
        }
    }
}
