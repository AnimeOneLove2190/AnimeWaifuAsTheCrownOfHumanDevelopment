using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class PersonService
    {
        readonly TechnicalService techService = new TechnicalService();
        public List<Person> SortPersonByName(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            char[] charArray = new char[list.Count];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = list[i].Name[0];
            }
            techService.BubbleSort(charArray);
            List<Person> nameSortList = new List<Person>();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Name[0] == charArray[i])
                    {
                        nameSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < nameSortList.Count; i++)
            {
                for (int j = i + 1; j < nameSortList.Count; j++)
                {
                    if (nameSortList[i] == nameSortList[j])
                    {
                        nameSortList.RemoveAt(j);
                    }
                }
            }
            return nameSortList;
        }
    }
}
