using System;
using System.Collections.Generic;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            PersonService personService = new PersonService();
            Person personOne = new Person();
            personOne.Name = "Misato";
            personOne.Age = 29;
            personOne.Weight = 47;
            personOne.Height = 163;
            Person personTwo = new Person();
            personTwo.Name = "Asuna";
            personTwo.Age = 19;
            personTwo.Weight = 54;
            personTwo.Height = 168;
            Person personThree = new Person();
            personThree.Name = "Rafutaria";
            personThree.Age = 10;
            personThree.Weight = 56;
            personThree.Height = 170;
            Person personFour = new Person();
            personFour.Name = "Hanji";
            personFour.Age = 31;
            personFour.Weight = 60;
            personFour.Height = 170;
            Person personFive = new Person();
            personFive.Name = "Violet";
            personFive.Age = 18;
            personFive.Weight = 42;
            personFive.Height = 161;
            List<Person> waifuList = new List<Person>();
            waifuList.Add(personOne);
            waifuList.Add(personTwo);
            waifuList.Add(personThree);
            waifuList.Add(personFour);
            waifuList.Add(personFive);
            List<Person> nameSortList = personService.SortPersonByName(waifuList);
            techService.WriteList(nameSortList);
        }
    }
}
