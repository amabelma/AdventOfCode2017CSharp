using System.Collections.Generic;
using System.Linq;

namespace Day4P1
{
    public class PasswordValidator
    {
        public int ValidPasswordCount(List<string> passwordList)
        {
            int validPasswordCount = 0;

            foreach(string passwordToCheck in passwordList)
            {
                bool isValid = true;
                var wordsWithinPassword = passwordToCheck.Split(" ");
                for(int i=0; i<wordsWithinPassword.Length; i++)
                {
                    for(int j=i+1; j<wordsWithinPassword.Length; j++)
                    {
                        var dme1 = string.Concat(wordsWithinPassword[i].OrderBy(a => a));
                        var dme2 = string.Concat(wordsWithinPassword[j].OrderBy(b => b));
                        if(string.Concat(wordsWithinPassword[i].OrderBy(a => a)) == string.Concat(wordsWithinPassword[j].OrderBy(b => b)))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if(isValid)
                {
                    validPasswordCount++;
                }
            }

            return validPasswordCount;
        }
    }
}