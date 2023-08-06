using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberService numberService = new NumberService();
            int inputNumThree = int.Parse(Console.ReadLine());
            bool numberIsEasy = numberService.IsPrimeNumber(inputNumThree);
            Console.WriteLine(numberIsEasy);
        }
    }
}
