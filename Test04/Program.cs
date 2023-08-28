using System;

namespace Test04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            TextService textService = new TextService();
            string meaninglessTextOne = "Some  text,. for(( test!@#$%^&*()_+<>:7{}!№;%:?*()_+,ЭЪ/лллююю/*-+text";
            string fio = "Зубенко Михаил Петрович";
            string kek = "и";
            string[] curvaArray = textService.SplitTextByLetter(fio, kek);
            techService.Write1DArray(curvaArray);
        }
    }
}
