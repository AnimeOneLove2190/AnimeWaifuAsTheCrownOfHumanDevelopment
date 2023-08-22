using System;
using System.Collections.Generic;
using System.Text;

namespace Test04Strings
{
    class TextService
    {
        readonly TechnicalService techService = new TechnicalService();
        public string GetFirstLetterInWord(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            string firstLetter = clearText.Substring(0, 1);
            return firstLetter;
        }
    }
}
