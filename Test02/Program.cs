using System;

namespace Test02Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            MathService numberService = new MathService();
            int[] randomArray = new int[10];
            int[] randomArrayPlus = new int[10];
            numberService.FillArray(randomArray);
            numberService.FillArray(randomArrayPlus);
            int[] evenArray = arrayService.GetEvenArray(randomArray);
            arrayService.PrintArray(evenArray);
        }
    }
}
