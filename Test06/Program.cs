using System;

namespace Test06
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberService numberService = new NumberService();
            int inputNumOne = int.Parse(Console.ReadLine());
            int inputDegree = int.Parse(Console.ReadLine());
            double resultFlipNumber = numberService.GetWhat(inputNumOne, inputDegree);
            Console.WriteLine(resultFlipNumber);
        }
    }
}
