using System;
using System.Collections.Generic;
using System.Text;

namespace Test04Strings
{
    class TextService
    {
        readonly TechnicalService techService = new TechnicalService();
        public string GetFrequentSubstring(string[] text)
        {
            string[] clearTextArray = new string[text.Length];
            for (int i = 0; i < clearTextArray.Length; i++)
            {
                clearTextArray[i] = techService.ClearText(text[i]);
            }
            for (int i = 0; i < clearTextArray.Length; i++)
            {
                if (string.IsNullOrEmpty(clearTextArray[i]) || string.IsNullOrWhiteSpace(clearTextArray[i]))
                {
                    Console.WriteLine("Сработала защита в GetFrequentSubstring");
                    return null;
                }
            }
            int initialLenght = 0;
            char[][] arrayOfMatches = new char[clearTextArray.Length - 1][];
            char[] frequentSubstring = new char[0];
            for (int i = 1, j = 0; i < clearTextArray.Length; i++, j++)
            {
                for (int z = 0; z < clearTextArray[0].Length; z++)
                {
                    if (clearTextArray[i].Contains(clearTextArray[0][z]))
                    {
                        arrayOfMatches[j] = new char[initialLenght + 1];
                        arrayOfMatches[j][z] = clearTextArray[0][z];
                    }
                }
            }
            for (int i = 0; i < arrayOfMatches.Length; i++)
            {
                if (arrayOfMatches[i].Length == 0)
                {
                    return null;
                }
            }
            for (int i = 0, j = 0; i < arrayOfMatches.Length; i++)
            {
                for (int z = 0; z < arrayOfMatches[i].Length; z++)
                {
                    if (arrayOfMatches[i][z] == )
                }
            }
        }
    }
}
