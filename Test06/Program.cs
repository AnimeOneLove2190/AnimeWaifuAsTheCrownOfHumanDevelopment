using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberService numberService = new NumberService();
            int inputNumFive = int.Parse(Console.ReadLine());
            int resultMinOfEnteredNumbers = numberService.FindMinNumbers(inputNumFive);
            Console.WriteLine(resultMinOfEnteredNumbers);
        }
    }
}
