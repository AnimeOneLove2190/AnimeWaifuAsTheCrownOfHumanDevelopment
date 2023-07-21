using System;

namespace Test04
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
            TextFile asunaFile = new TextFile
            {
                name = "Yuuki Asuna",
                description = "Yuuki Asuna is the main character and partner of Kirito. She was a sub-leader in the Knights of the Blood guild in Old Aincrad. She is the daughter of the executive director of the RECTO company, which owned Alfheim Online.",
                weight = 54
            };
            TextService connectedTextFile = new TextService();
            TextFile finalTextFile = connectedTextFile.ConnectedTextFile(misatoFile, asunaFile);
            Console.WriteLine(finalTextFile.name);
            Console.WriteLine(finalTextFile.description);
            Console.WriteLine(finalTextFile.weight);
            string meow = "Мяв.";
            TextService addedText = new TextService();
            addedText.AddedTextFile(asunaFile, meow);
        }
    }
}
