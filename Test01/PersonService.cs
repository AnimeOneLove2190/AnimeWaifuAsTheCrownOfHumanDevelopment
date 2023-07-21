using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class PersonService
    {
        public PersonFullInfo SetPersonFullInfo(PersonInfo persoInfo, PersonParams personParams)
        {
            PersonFullInfo personFullInfoSer = new PersonFullInfo();
            personFullInfoSer.name = persoInfo.name;
            personFullInfoSer.floor = persoInfo.floor;
            personFullInfoSer.age = personParams.age;
            personFullInfoSer.weight = personParams.weight;
            personFullInfoSer.height = personParams.height;
            return personFullInfoSer;
        }
        public void WritePerson(PersonFullInfo personFullInfo)
        {
            Console.WriteLine(personFullInfo.name);
            Console.WriteLine(personFullInfo.floor);
            Console.WriteLine(personFullInfo.age);
            Console.WriteLine(personFullInfo.weight);
            Console.WriteLine(personFullInfo.height);
        }
    }
}
