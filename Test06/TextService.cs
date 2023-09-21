using System;
using System.Collections.Generic;
using System.Text;

namespace Test06Feature542
{
    class TextService : ICharable
    {
        readonly TechService techService = new TechService();
        public Dictionary<char, int> GetCharStatistics(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Срабатывание в GetCharStatistics");
                return null;
            }
            Dictionary<char, int> charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(charsCount.ContainsKey(text[i])))
                {
                    charsCount.Add(text[i], 0);
                }
                if (charsCount.ContainsKey(text[i]))
                {
                    charsCount[text[i]]++;
                }
            }
            return charsCount;
        }
        public Dictionary<string, int> GetWordStatistics(string text)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Срабатывание в GetWordStatistics");
                return null;
            }
            text = techService.ClearText(text);
            string[] keysArray = text.Split(" ");
            Dictionary<string, int> charsCount = new Dictionary<string, int>();
            for (int i = 0; i < keysArray.Length; i++)
            {
                
                if (!(charsCount.ContainsKey(keysArray[i])))
                {
                    charsCount.Add(keysArray[i], 0);
                }
                if (charsCount.ContainsKey(keysArray[i]))
                {
                    charsCount[keysArray[i]]++;
                }
            }
            return charsCount;
        }
    }
}
