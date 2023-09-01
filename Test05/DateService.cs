using System;
using System.Collections.Generic;
using System.Text;

namespace Test05DateTimes
{
    class DateService
    {
        readonly TechnicalService techService = new TechnicalService();
        public DateTime GetDateWithSelectedYear(int year)
        {
            int month = techService.GetRandomNumber(1, 12);
            int day = techService.GetRandomNumber(1, 28);
            int hour = techService.GetRandomNumber(1, 23);
            int minute = techService.GetRandomNumber(1, 59);
            int second = techService.GetRandomNumber(1, 59);
            DateTime dateWithSelectedYear = new DateTime(year, month, day, hour, minute, second);
            return dateWithSelectedYear;
        }
        public DateTime[] GetDateArray(DateTime firstDate, DateTime lastDate)
        {
            DateTime[] dateArray = new DateTime[0];
            if (firstDate == lastDate)
            {
                if (firstDate.DayOfWeek == DayOfWeek.Saturday || firstDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateArray = new DateTime[1];
                    dateArray[0] = firstDate;
                }
            }
            if (firstDate > lastDate)
            {
                DateTime tempStorage = lastDate;
                lastDate = firstDate;
                firstDate = tempStorage;
            }
            int countOfDays = techService.GetLengthOfTheInterval(firstDate, lastDate);
            dateArray = new DateTime[countOfDays];
            DateTime tempStore = firstDate;
            for (int i = 0; i < countOfDays; i++)
            {
                dateArray[i] = tempStore;
                tempStore = tempStore.AddDays(1);
            }
            return dateArray;
        }
    }
}
