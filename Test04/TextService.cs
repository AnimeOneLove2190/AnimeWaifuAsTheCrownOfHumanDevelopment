using System;
using System.Collections.Generic;
using System.Text;

namespace Test04Strings
{
    class TextService
    {
        readonly TechnicalService techService = new TechnicalService();
        public int GetCountOfSearchLetter(string text, string searchLetter)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Сработала защита в GetCountOfSearchLetter");
                return 0;
            }
            clearText = clearText.ToLower();
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            int countOfSearchWords = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == searchLetter[0])
                {
                    countOfSearchWords++;
                }
            }
            return countOfSearchWords;
        }
        public string[] SplitTextByLetter(string text, string seletcedLetter)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(clearText) || string.IsNullOrWhiteSpace(clearText))
            {
                Console.WriteLine("Сработала защита в SplitTextByLetter");
                return null;
            }
            int savedCounter = 0;
            int savedCounterPlus = 0;
            int countOfSelectedLetter = GetCountOfSearchLetter(clearText, seletcedLetter);
            string[] curvaArray = new string[countOfSelectedLetter + 1];
            for (int i = 0, o = 0; i < clearText.Length; i++)
            {
                if (clearText[i] == seletcedLetter[0])
                {
                    char[] charArray = new char[i - savedCounter];
                    for (int j = 0, z = savedCounter; j < charArray.Length && z < clearText.Length; j++, z++)
                    {
                        charArray[j] = clearText[z];
                    }
                    curvaArray[o] = new string(charArray);
                    o++;
                    savedCounter = i + 1;
                    savedCounterPlus = o;
                }
            }
            for (int i = savedCounter; i < clearText.Length; i++)
            {
                char[] charArray = new char[clearText.Length - savedCounter];
                for (int j = 0, z = savedCounter; j < clearText.Length && z < clearText.Length; j++, z++)
                {
                    charArray[j] = clearText[z];
                }
                curvaArray[savedCounterPlus] = new string(charArray);
            }
            return curvaArray;
        }
    }
}
