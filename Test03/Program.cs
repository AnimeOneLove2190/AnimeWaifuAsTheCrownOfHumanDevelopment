using System;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumOne = int.Parse(Console.ReadLine());
            int inputNumTwo = int.Parse(Console.ReadLine());
            int inputOperation = int.Parse(Console.ReadLine());
            MathService performOperation = new MathService();
            int result = performOperation.PerformOperation(inputNumOne, inputNumTwo, (Operation)inputOperation);
            Console.WriteLine(result);
        }
    }
}
