using System;

namespace Test05DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            DateService dateService = new DateService();
            DateTime randomDate = new DateTime(2023, 09, 5);
            Console.WriteLine(randomDate);
            DateTime randomDatePlus = new DateTime(2023, 09, 22);
            Console.WriteLine(randomDatePlus);
            int countOfWeekends = techService.GetCountOfWeekends(randomDate, randomDatePlus);
            Console.WriteLine(countOfWeekends);
            DateTime[] dateArray = dateService.GetDateArray(randomDate, randomDatePlus);
            techService.Write1DArray(dateArray);
        }
    }
}
