using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class MovieService
    {
        readonly TechnicalService techService = new TechnicalService();
        public List<Movie> SortMoviesByPremiereDate(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в SortMoviesByPremiereDate");
                return null;
            }
            DateTime[] dateArray = new DateTime[list.Count];
            for (int i = 0; i < dateArray.Length; i++)
            {
                dateArray[i] = list[i].PremiereDate;
            }
            techService.BubbleSort(dateArray);
            List<Movie> ageSortList = new List<Movie>();
            for (int i = 0; i < dateArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].PremiereDate == dateArray[i])
                    {
                        ageSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < ageSortList.Count; i++)
            {
                for (int j = i + 1; j < ageSortList.Count; j++)
                {
                    if (ageSortList[i] == ageSortList[j])
                    {
                        ageSortList.RemoveAt(j);
                    }
                }
            }
            return ageSortList;
        }
    }
}
