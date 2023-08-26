using System;
using System.Collections.Generic;
using System.Text;

namespace Test04Strings
{
    class TextService
    {
        readonly TechnicalService techService = new TechnicalService();
        public string UpFirstLetterInWord(string text)
        {
            string clearText = techService.ClearText(text);
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Сработала защита в GetFirstLetterInWord");
                return null;
            }
            char[] charArray = new char[clearText.Length];
            for (int i = 0; i < text.Length; i++)
            {
                charArray[i] = clearText[i];
            }
            charArray[0] = char.ToUpper(charArray[0]);
            clearText = new string(charArray);
            return clearText;
        }
    }
}
