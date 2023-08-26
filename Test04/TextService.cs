using System;
using System.Collections.Generic;
using System.Text;

namespace Test04Strings
{
    class TextService
    {
        readonly TechnicalService techService = new TechnicalService();
        public string GetRussianAlphabet()
        {
            const int startLetter = 1072;
            const int endLetter = 1103;
            const int ё = 1105;
            char[] charArray = new char[endLetter - startLetter + 2];
            for (int i = startLetter, j = startLetter, z = 0; z < charArray.Length; z++, i++)
            {
                if (i == 1078)
                {
                    charArray[z] = (char)ё;
                    continue;
                }
                charArray[z] = (char)j;
                j++;
            }
            string alphabetLower = new string(charArray);
            string alphabetUpper = alphabetLower.ToUpper();
            string alphabetFull = $"{alphabetLower}{alphabetUpper}";
            return alphabetFull;
        }
    }
}
