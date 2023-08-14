using System;

namespace Test02Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayService arrayService = new ArrayService();
            TechnicalService techService = new TechnicalService();
            int[] randomArray = new int[10];
            techService.FillArray(randomArray);
            int[] randomArrayPlus = new int[6];
            techService.FillArray(randomArrayPlus);
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
            Person[] personArray = new Person[6];
            personArray[0] = personOne;
            personArray[1] = personTwo;
            personArray[2] = personThree;
            personArray[3] = personFour;
            personArray[4] = personFive;
            personArray[5] = personSix;
            techService.PrintArrayNumber(randomArray);
            int[] arrayWithoutSelectedSegmentNum = arrayService.RemoveSelectedSegmentFromArray(randomArray, 3, 6);
            techService.PrintArrayNumber(arrayWithoutSelectedSegmentNum);
            techService.PrintArrayPerson(personArray);
            Person[] arrayWithoutSelectedSegmentPer = arrayService.RemoveSelectedSegmentFromArray(personArray, 2, 4);
            techService.PrintArrayPerson(arrayWithoutSelectedSegmentPer);
        }
    }
}
