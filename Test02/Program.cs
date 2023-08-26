using System;

namespace Test02Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            TechnicalService techService = new TechnicalService();
            Person personOne = new Person();
            personOne.name = "Misato Katsuragi";
            personOne.age = 29;
            Person personTwo = new Person();
            personTwo.name = "Yuuki Asuna";
            personTwo.age = 19;
            Person personThree = new Person();
            personThree.name = "Rafutaria";
            personThree.age = 10;
            Person personFour = new Person();
            personFour.name = "Hanji Zoe";
            personFour.age = 31;
            Person personFive = new Person();
            personFive.name = "Violet Evergarden";
            personFive.age = 14;
            Person personSix = new Person();
            personSix.name = "Holo";
            personSix.age = 834;
            int[,] random2DArray = techService.Create2DArray(4, 5, 0, 10);
            techService.Write2DArray(random2DArray);
            Console.WriteLine();
            int[,] array2DWithNewLength = arrayService.Change2DArray(random2DArray, 3, 4);
            techService.Write2DArray(array2DWithNewLength);
        }
    }
}
