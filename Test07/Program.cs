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
            string meaninglessTextOne = "     Some              text,. for((      test!@#$%^&*()_+<>:{}!№;%:?*()_+,ЭЪ/лллююю/*-+text ";
            string crashTest = "  ";
            string clearMeaninglessTextOne = techService.ClearText(meaninglessTextOne);
            string clearCrashTest = techService.ClearText(crashTest);
            Console.WriteLine(clearMeaninglessTextOne);
            Console.WriteLine(clearCrashTest);
            Console.WriteLine("Мяв");
        }
    }
}
