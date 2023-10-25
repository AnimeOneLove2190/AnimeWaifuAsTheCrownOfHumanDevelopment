using System;
using System.Collections.Generic;
using System.Text;

namespace Test07
{
    class TextService
    {
        readonly TechService techService = new TechService();
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
