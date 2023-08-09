using System;

namespace Test02Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            MathService numberService = new MathService();
            int[] randomArray = new int[4];
            numberService.FillArray(randomArray);
            int[] randomArrayPlus = new int[6];
            numberService.FillArray(randomArrayPlus);
            arrayService.PrintArrayNumber(randomArray);
            arrayService.PrintArrayNumber(randomArrayPlus);
            int[] arraySum = arrayService.GetArraySum(randomArray, randomArrayPlus);
            arrayService.PrintArrayNumber(arraySum);
        }
    }
}
