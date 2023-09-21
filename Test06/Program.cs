using System;
using System.Collections.Generic;

namespace Test06Feature542
{
    class Program
    {
        static void Main(string[] args)
        {
            TextService textService = new TextService();
            TechService techService = new TechService();
            string text = "Эрвин Смит - 13-й Главнокомандующий Разведкорпуса. Рассудительный, умный и уважаемый человек. Несмотря на аналогичную Леви заботу о членах своего отряда, в случае необходимости без колебаний готов пожертвовать ими ради остального человечества. Он также разработал вид военного построения, позволяющего заранее обнаружить находящегося далеко противника. Также на протяжении большой части своей службы в качестве командира отстаивал независимость Разведкорпуса, тем самым спасая его от расформирования.";
            Dictionary<char, int> charsCount = textService.GetCharStatistics(text);
            techService.WriteDictionary(charsCount);
            Dictionary<string, int> wordsStatistic = textService.GetWordStatistics(text);
            techService.WriteDictionary(wordsStatistic);
        }
    }
}
