using System;
using System.Collections.Generic;
using System.Text;

namespace Test02
{
    class PersonService
    {
        public PersonParams CheckMaxAge(PersonParams waifuOne, PersonParams waifuTwo)
        {
            PersonParams maxAgePersonS = new PersonParams();
            if (waifuOne.age > waifuTwo.age)
            {
                maxAgePersonS = waifuOne;
            }
            if (waifuOne.age < waifuTwo.age)
            {
                maxAgePersonS = waifuTwo;
            }
            if (waifuOne.age == waifuTwo.age)
            {
                Console.WriteLine("У них одинаковые возраста, я хз чо делать");
            }
            return maxAgePersonS;
        }
        public void WriteParams(PersonParams waifuWithMaxAge)
        {
            Console.WriteLine(waifuWithMaxAge.age);
            Console.WriteLine(waifuWithMaxAge.weight);
            Console.WriteLine(waifuWithMaxAge.height);
        }
    }
}
