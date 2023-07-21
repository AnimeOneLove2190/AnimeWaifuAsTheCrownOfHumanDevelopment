using System;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo misatoInfo = new PersonInfo();
            misatoInfo.name = "Misato Katsuragi";
            misatoInfo.floor = "Female";
            PersonInfo asunaInfo = new PersonInfo();
            asunaInfo.name = "Yuuki Asuna";
            asunaInfo.floor = "Female";
            PersonParams misatoParams = new PersonParams();
            misatoParams.age = 29;
            misatoParams.weight = 47;
            misatoParams.height = 163;
            PersonParams asunaParams = new PersonParams();
            asunaParams.age = 19;
            asunaParams.weight = 54;
            asunaParams.height = 168;
            PersonService personServiceSetInfo = new PersonService();
            PersonFullInfo personFullInfoMisato = personServiceSetInfo.SetPersonFullInfo(misatoInfo, misatoParams);
            PersonService writeService = new PersonService();
            writeService.WritePerson(personFullInfoMisato);
            PersonFullInfo personFullInfoAsuna = personServiceSetInfo.SetPersonFullInfo(asunaInfo, asunaParams);
            writeService.WritePerson(personFullInfoAsuna);
        }
    }
}
