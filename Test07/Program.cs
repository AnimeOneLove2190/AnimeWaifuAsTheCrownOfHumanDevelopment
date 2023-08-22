using System;

namespace Test07
{
    class Program
    {
        static void Main(string[] args)
        {
            //char plug = Console.ReadKey().KeyChar;
            char plug = (char)32;
            Console.WriteLine();
            bool result = char.IsUpper(plug);
            Console.WriteLine(result);
            TechnicalService techService = new TechnicalService();
            string meaninglessTextOne = "     Some              text,. for((      test!@#$%^&*()_+<>:{}!№;%:?*()_+,ЭЪ/лллююю/*-+text";
            string crashTest = "  ";
            string clearText = techService.ClearText(meaninglessTextOne);
            string clearText1 = techService.ClearText(crashTest);
            Console.WriteLine(clearText);
            Console.WriteLine(clearText1);
            Console.WriteLine("Мяв");
        }
    }
}
