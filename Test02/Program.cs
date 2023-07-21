using System;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonParams misatoParams = new PersonParams();
            misatoParams.age = 29;
            misatoParams.weight = 47;
            misatoParams.height = 163;
            PersonParams asunaParams = new PersonParams();
            asunaParams.age = 19;
            asunaParams.weight = 54;
            asunaParams.height = 168;
            PersonService checkMaxAge = new PersonService();
            PersonParams personWithMaxAge = checkMaxAge.CheckMaxAge(misatoParams, asunaParams);
            PersonService wrritePersonWithMaxAge = new PersonService();
            wrritePersonWithMaxAge.WriteParams(personWithMaxAge);
        }
    }
}
