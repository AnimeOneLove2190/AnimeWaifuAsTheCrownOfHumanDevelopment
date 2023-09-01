using System;
using System.Collections.Generic;
using System.Text;

namespace Test05DateTimes
{
    class TechnicalService
    {
        public int GetRandomNumber(int minValue, int maxValue)
        {
            Random godOfNumbers = new Random();
            int randomNumber = godOfNumbers.Next(minValue, maxValue);
            return randomNumber;
        }
        public int GetLengthOfTheInterval(DateTime firstDate, DateTime lastDate)
        {
            if (firstDate == lastDate)
            {
                return 1;
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            int countOfDays = 1;
            while (!(firstDate == lastDate))
            {
                firstDate = firstDate.AddDays(1);
                countOfDays++;
            }
            return countOfDays;
        }
        public int GetCountOfWeekends(DateTime firstDate, DateTime lastDate)
        {
            if (firstDate == lastDate)
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    return 1;
                }
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            DateTime tempStor = lastDate.AddDays(1);
            int countOfWeekends = 0;
            while (!(firstDate == tempStor))
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    countOfWeekends++;
                }
                firstDate = firstDate.AddDays(1);
            }
            return countOfWeekends;
        }
        public void Write1DArray(DateTime[] dateArray)
        {
            if (dateArray == null || dateArray.Length == 0)
            {
                Console.WriteLine("Массив пуст, милорд");
                return;
            }
            for (int i = 0; i < dateArray.Length; i++)
            {
                Console.Write($"{dateArray[i]} ");
            }
        }
    }
}
