using System;

namespace Test04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            TextService textService = new TextService();
            string meaninglessTextOne = "Some  text,. for(( test!@#$%^&*()_+<>:{}!№;%:?*()_+,ЭЪ/лллююю/*-+text";
            string crashTest = "        ";
            string firstLetter = textService.GetFirstLetterInWord(meaninglessTextOne);
            Console.WriteLine(firstLetter);
        }
    }
}
