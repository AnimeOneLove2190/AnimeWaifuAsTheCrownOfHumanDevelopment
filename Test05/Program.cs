using System;

namespace Test05
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFile misatoFile = new TextFile
            {
                name = "Misato Katsuragi",
                description = "Misato Katsuragi is a captain and then a major in Nerv. She runs the Tactical Operations Division at Nerv Headquarters, being responsible for coordinating the Evangelions in actual combat (as opposed to the Science Division, which is headed by Misato's old friend Dr. Ritsuko Akagi). She is the daughter of Dr. Katsuragi and the sole survivor of his expedition that was destroyed in Second Impact. Suffered severe psychological trauma at the age of thirteen, which led to the development of borderline personality disorder, due to which the mature Misato became incapable of serious long-term relationships.",
                weight = 47
            };
            TextService textService = new TextService();
            textService.ClearTextFile(misatoFile);
            Console.WriteLine(misatoFile.name);
            Console.WriteLine(misatoFile.description);
            Console.WriteLine(misatoFile.weight);
        }
    }
}
